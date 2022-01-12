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


-- User [usr_id, user_type, f_name, l_name, address, email, password]

CREATE TABLE [User]
(
    usr_id INTEGER PRIMARY KEY ,
    user_type varChar(1) NOT NULL,
    f_name varChar(255) NOT NULL,
    l_name varChar(255) NOT NULL,
    address varChar(255) NOT NULL,
    email varChar(255) NOT NULL,
    password varChar(255) NOT NULL,
);

-- Student [std_id, dept_id]
CREATE TABLE [Student]
(
    std_id INTEGER PRIMARY KEY ,
    dept_id INTEGER NOT NULL,
);

-- Instructor [ins_id, salary, degree, dept_id]

CREATE TABLE [Instructor]
(
    ins_id INTEGER PRIMARY KEY ,
    salary INTEGER ,
    degree varChar(255) ,
    dept_id INTEGER NOT NULL,
);
-- Course [crs_id, crs_name]

CREATE TABLE [Course]
(
    crs_id INTEGER PRIMARY KEY ,
    crs_name varChar(255) NOT NULL,
);

-- Course_Attendance [crs_id, std_id, ins_id, grade]

CREATE TABLE [Course_Attendance]
(
    crs_id INTEGER NOT NULL,
    std_id INTEGER NOT NULL,
    ins_id INTEGER NOT NULL,
    grade varChar(255) NOT NULL,
    FOREIGN KEY (crs_id) REFERENCES Course(crs_id),
    FOREIGN KEY (std_id) REFERENCES Student(std_id),
    FOREIGN KEY (ins_id) REFERENCES Instructor(ins_id),
);
-- Ins_Course [crs_id, ins_id, evaluation, dept_id]

CREATE TABLE [Ins_Course]
(
    crs_id INTEGER NOT NULL,
    ins_id INTEGER NOT NULL,
    evaluation INTEGER ,
    FOREIGN KEY (crs_id) REFERENCES Course(crs_id),
    FOREIGN KEY (ins_id) REFERENCES Instructor(ins_id),
);

-- Department [dept_id, dept_name, mgr_id]

CREATE TABLE [Department]
(
    dept_id INTEGER PRIMARY KEY ,
    dept_name varChar(255) NOT NULL,
    mgr_id INTEGER NOT NULL,
    FOREIGN KEY (mgr_id) REFERENCES Instructor(ins_id),
);

ALTER TABLE [Student] ADD CONSTRAINT [Student_fk_1] FOREIGN KEY (dept_id) REFERENCES Department(dept_id);
ALTER TABLE [Instructor] ADD CONSTRAINT [Instructor_fk_1] FOREIGN KEY (dept_id) REFERENCES Department(dept_id);

-- Topic [top_id, top_name, crs_id]

CREATE TABLE [Topic]
(
    top_id INTEGER PRIMARY KEY ,
    top_name varChar(255) NOT NULL,
    crs_id INTEGER NOT NULL,
    FOREIGN KEY (crs_id) REFERENCES Course(crs_id),
);

-- Exam [ex_id, date, crs_id]

CREATE TABLE [Exam]
(
    ex_id INTEGER PRIMARY KEY ,
    date Date NOT NULL,
    crs_id INTEGER NOT NULL,
    FOREIGN KEY (crs_id) REFERENCES Course(crs_id),
);

-- Exam_Question [ex_id, q_id]

CREATE TABLE [Exam_Question]
(
    ex_id INTEGER NOT NULL,
    q_id INTEGER NOT NULL,
    FOREIGN KEY (ex_id) REFERENCES Exam(ex_id),
);

-- Exam_Answer [std_id, ex_id, q_id, std_answer]

CREATE TABLE [Exam_Answer]
(
    std_id INTEGER NOT NULL,
    ex_id INTEGER NOT NULL,
    q_id INTEGER NOT NULL,
    std_answer varChar(255) NOT NULL,
    FOREIGN KEY (std_id) REFERENCES Student(std_id),
    FOREIGN KEY (ex_id) REFERENCES Exam(ex_id),
);

-- Question [q_id, type, q_text, corr_answer, crs_id]
CREATE TABLE [Question]
(
    q_id INTEGER PRIMARY KEY ,
    type varChar(255) NOT NULL,
    q_text varChar(255) NOT NULL,
    corr_answer varChar(255) NOT NULL,
    crs_id INTEGER NOT NULL,
    FOREIGN KEY (crs_id) REFERENCES Course(crs_id),
);
ALTER TABLE [Exam_Question] ADD CONSTRAINT [Exam_Question_fk_1] FOREIGN KEY (q_id) REFERENCES Question(q_id);
ALTER TABLE [Exam_Answer] ADD CONSTRAINT [Exam_Answer_fk_1] FOREIGN KEY (q_id) REFERENCES Question(q_id);

-- MCQ [¬¬¬¬¬¬q_id, ch1, ch2, ch3, ch4]
CREATE TABLE [MCQ]
(
    q_id INTEGER NOT NULL,
    ch1 varChar(255) NOT NULL,
    ch2 varChar(255) NOT NULL,
    ch3 varChar(255) NOT NULL,
    ch4 varChar(255) NOT NULL,
    FOREIGN KEY (q_id) REFERENCES Question(q_id),
);
