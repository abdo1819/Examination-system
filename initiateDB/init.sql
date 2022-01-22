-- WARNNING this script will drop all tables in the database
-- and create new ones.


/* -------------------------------------------------------------------------- */
/*                      create the database if not exist                      */
/* -------------------------------------------------------------------------- */

-- Create a new database called 'Examination'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT name
        FROM sys.databases
        WHERE name = N'Examination'
)
CREATE DATABASE Examination
GO
USE Examination;
GO
/* -------------------------------------------------------------------------- */
/*                       remove all tables if the exist                       */
/* -------------------------------------------------------------------------- */
-- ref https://stackoverflow.com/questions/8439650/how-to-drop-all-tables-in-a-sql-server-database

-- remove FOREIGN key CONSTRAINT
DECLARE @Sql NVARCHAR(500) DECLARE @Cursor CURSOR

SET @Cursor = CURSOR FAST_FORWARD FOR
SELECT DISTINCT sql = 'ALTER TABLE [' + tc2.TABLE_SCHEMA + '].[' +  tc2.TABLE_NAME + '] DROP [' + rc1.CONSTRAINT_NAME + '];'
FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS rc1
LEFT JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc2 ON tc2.CONSTRAINT_NAME =rc1.CONSTRAINT_NAME

OPEN @Cursor FETCH NEXT FROM @Cursor INTO @Sql

WHILE (@@FETCH_STATUS = 0)
BEGIN
Exec sp_executesql @Sql
FETCH NEXT FROM @Cursor INTO @Sql
END

CLOSE @Cursor DEALLOCATE @Cursor
GO

-- drop actual tables
EXEC sp_MSforeachtable 'DROP TABLE ?'
GO

-- create PRIVATE schema if not exist in the database
-- PRIVATE schema is procedure not intended for end-user(developer)
IF NOT EXISTS (SELECT *
FROM sys.schemas
WHERE name = 'PRIVATE')
BEGIN
    EXEC('CREATE SCHEMA [PRIVATE] ');
END
GO

-- User [usr_id, user_type, f_name, l_name, address, email, password]

CREATE TABLE [User]
(
    usr_id INTEGER PRIMARY KEY IDENTITY,
    user_type varChar(1) NOT NULL,
    f_name varChar(50) NOT NULL,
    l_name varChar(50) NOT NULL,
    address varChar(150) ,
    email varChar(90) UNIQUE NOT NULL,
    hashed_password varChar(255) NOT NULL, 
	CONSTRAINT c_user_type CHECK (user_type IN ('I','S'))
);

-- Student [std_id, dept_id]
CREATE TABLE [Student]
(
    std_id INTEGER PRIMARY KEY ,
    dept_id INTEGER NOT NULL,
    FOREIGN KEY (std_id) REFERENCES [User](usr_id) ON DELETE CASCADE,
);

-- Instructor [ins_id, salary, degree, dept_id]

CREATE TABLE [Instructor]
(
    ins_id INTEGER PRIMARY KEY ,
    salary MONEY ,
    degree varChar(50) ,
    dept_id INTEGER NOT NULL,
	hire_date DATE DEFAULT GETDATE(),
    FOREIGN KEY (ins_id) REFERENCES [User](usr_id) ON DELETE CASCADE,
);
-- Course [crs_id, crs_name]

CREATE TABLE [Course]
(
    crs_id INTEGER PRIMARY KEY IDENTITY(1000, 100),
    crs_name varChar(100) UNIQUE NOT NULL,
);

-- Course_Attendance [crs_id, std_id, ins_id, grade]
-- Fathy Comment: Attempting to turn grade into a computed value
-- getQuestionMark must be created before Course_Attendance Table is created
go
CREATE OR ALTER FUNCTION getStudentGrade(@crs_id INT, @std_id INT)
RETURNS INT
AS
BEGIN
DECLARE @result INT
SELECT @result = (SELECT SUM(EA.std_mark) FROM Exam_Answer EA, Exam E WHERE EA.ex_id = E.ex_id AND E.crs_id = @crs_id AND EA.std_id = @std_id )
	RETURN @result
END
go
CREATE TABLE [Course_Attendance]
(
    crs_id INTEGER ,
    std_id INTEGER ,
    ins_id INTEGER ,
    grade AS dbo.getStudentGrade(crs_id, std_id),
    FOREIGN KEY (crs_id) REFERENCES Course(crs_id) on delete cascade ,
    FOREIGN KEY (std_id) REFERENCES Student(std_id) on delete cascade,
    FOREIGN KEY (ins_id) REFERENCES Instructor(ins_id) ,
	PRIMARY KEY (crs_id,std_id,ins_id)
);

-- Ins_Course [crs_id, ins_id, evaluation, dept_id]

CREATE TABLE [Ins_Course]
(
    crs_id INTEGER ,
    ins_id INTEGER ,
    evaluation INTEGER ,
    FOREIGN KEY (crs_id) REFERENCES Course(crs_id) on delete cascade,
    FOREIGN KEY (ins_id) REFERENCES Instructor(ins_id) on delete cascade,
	CONSTRAINT c_CA_PK PRIMARY KEY (crs_id,ins_id),
	CONSTRAINT c_IC_eval CHECK (evaluation BETWEEN 0 AND 10)
);

-- Department [dept_id, dept_name, mgr_id]

CREATE TABLE [Department]
(
    dept_id INTEGER PRIMARY KEY IDENTITY(100, 100),
    dept_name varChar(100) UNIQUE NOT NULL,
    mgr_id INTEGER NOT NULL ,
    FOREIGN KEY (mgr_id) REFERENCES Instructor(ins_id) , -- Check Constraints later
);

ALTER TABLE [Student] ADD CONSTRAINT [Student_fk_1] FOREIGN KEY (dept_id) REFERENCES Department(dept_id); -- Check Constraints later
ALTER TABLE [Instructor] ADD CONSTRAINT [Instructor_fk_1] FOREIGN KEY (dept_id) REFERENCES Department(dept_id); -- Check Constraints later

-- Topic [top_id, top_name, crs_id]

CREATE TABLE [Topic]
(
    top_id INTEGER PRIMARY KEY IDENTITY(10000, 1000),
    top_name varChar(100) UNIQUE NOT NULL,
    crs_id INTEGER NOT NULL,
    FOREIGN KEY (crs_id) REFERENCES Course(crs_id) ON DELETE CASCADE,
);

-- Exam [ex_id, date, crs_id]

CREATE TABLE [Exam]
(
    ex_id INTEGER PRIMARY KEY IDENTITY(10, 10),
    date Date NOT NULL DEFAULT GETDATE(),
    crs_id INTEGER NOT NULL,
    FOREIGN KEY (crs_id) REFERENCES Course(crs_id) , -- Check constraints later
);

-- Exam_Question [ex_id, q_id]

CREATE TABLE [Exam_Question]
(
    ex_id INTEGER ,
    q_id INTEGER ,
    FOREIGN KEY (ex_id) REFERENCES Exam(ex_id),
	PRIMARY KEY (ex_id,q_id)
);

-- Exam_Answer [std_id, ex_id, q_id, std_answer]

-- Fathy Comment: Attempting to add a computed column for student mark
-- getQuestionMark must be created before Exam_Answer Table is created
go
CREATE OR ALTER FUNCTION getQuestionMark(@q_id INT)
RETURNS INT
AS
BEGIN
DECLARE @result INT, @corr_answer VARCHAR(1), @std_answer VARCHAR(1)
	SELECT @corr_answer = (SELECT corr_answer FROM Question WHERE q_id = @q_id)
	SELECT @std_answer = (SELECT std_answer FROM Exam_Answer WHERE q_id = @q_id)
	IF (@corr_answer = @std_answer)
		SET @result = 1
	ELSE
		SET @result = 0

	RETURN @result
END
go
CREATE TABLE [Exam_Answer]
(
    std_id INTEGER ,
    ex_id INTEGER ,
    q_id INTEGER ,
    std_answer VARCHAR(1),
	std_mark AS dbo.getQuestionMark(q_id), -- std_mark is computed based on the function
    FOREIGN KEY (std_id) REFERENCES Student(std_id) on delete cascade,
    FOREIGN KEY (ex_id) REFERENCES Exam(ex_id) on delete cascade, 
	CONSTRAINT c_EA CHECK (std_answer IN ('a','b','c','d','T','F')), -- Possible trigger on insert 
	PRIMARY KEY (std_id,ex_id,q_id)
);

-- Question [q_id, q_type, q_text, corr_answer, top_id]
CREATE TABLE [Question]
(
    q_id INTEGER PRIMARY KEY IDENTITY(500, 50),
    q_type varChar(3) NOT NULL,
    q_text varChar(300) NOT NULL,
    corr_answer varChar(1) NOT NULL,
    top_id INTEGER NOT NULL,
    FOREIGN KEY (top_id) REFERENCES Topic(top_id) ON DELETE CASCADE,
	CONSTRAINT c_questype CHECK (q_type IN ('TF', 'MCQ')) ,
	CONSTRAINT c_corr_answer CHECK ( ( (q_type = 'TF') AND (corr_answer IN ('T', 'F') ) ) OR ( (q_type = 'MCQ') AND (corr_answer IN ('a', 'b','c','d')) ) ) 
);

ALTER TABLE [Exam_Question] ADD CONSTRAINT [Exam_Question_fk_1] FOREIGN KEY (q_id) REFERENCES Question(q_id) ;
ALTER TABLE [Exam_Answer] ADD CONSTRAINT [Exam_Answer_fk_1] FOREIGN KEY (q_id) REFERENCES Question(q_id) ; -- Check constraints

-- MCQ [q_id, ch_a, ch_b, ch_c, ch_d]
CREATE TABLE [MCQ]
(
    q_id INTEGER ,
    ch_a varChar(300) NOT NULL,
    ch_b varChar(300) NOT NULL,
    ch_c varChar(300) NOT NULL,
    ch_d varChar(300) NOT NULL,
    FOREIGN KEY (q_id) REFERENCES Question(q_id) ON DELETE CASCADE,
	PRIMARY KEY (q_id)
);

