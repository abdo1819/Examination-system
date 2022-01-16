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
    usr_id INTEGER PRIMARY KEY IDENTITY,
    user_type varChar(1) NOT NULL,
    f_name varChar(50) NOT NULL,
    l_name varChar(50) NOT NULL,
    address varChar(150) ,
    email varChar(90) UNIQUE NOT NULL,
    password varChar(255) NOT NULL, 
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
    crs_id INTEGER PRIMARY KEY ,
    crs_name varChar(100) NOT NULL,
);

-- Course_Attendance [crs_id, std_id, ins_id, grade]

CREATE TABLE [Course_Attendance]
(
    crs_id INTEGER ,
    std_id INTEGER ,
    ins_id INTEGER ,
    grade INTEGER , -- The grade of the last exam taken by student in this course -- Derived
    FOREIGN KEY (crs_id) REFERENCES Course(crs_id),
    FOREIGN KEY (std_id) REFERENCES Student(std_id),
    FOREIGN KEY (ins_id) REFERENCES Instructor(ins_id),
	PRIMARY KEY (crs_id,std_id,ins_id)
);
-- Ins_Course [crs_id, ins_id, evaluation, dept_id]

CREATE TABLE [Ins_Course]
(
    crs_id INTEGER ,
    ins_id INTEGER ,
    evaluation INTEGER ,
    FOREIGN KEY (crs_id) REFERENCES Course(crs_id) ,
    FOREIGN KEY (ins_id) REFERENCES Instructor(ins_id) ,
	CONSTRAINT c_CA_PK PRIMARY KEY (crs_id,ins_id),
	CONSTRAINT c_IC_eval CHECK (evaluation BETWEEN 0 AND 10)
);

-- Department [dept_id, dept_name, mgr_id]

CREATE TABLE [Department]
(
    dept_id INTEGER PRIMARY KEY ,
    dept_name varChar(100) NOT NULL,
    mgr_id INTEGER NOT NULL ,
    FOREIGN KEY (mgr_id) REFERENCES Instructor(ins_id) , -- Check Constraints later
);

ALTER TABLE [Student] ADD CONSTRAINT [Student_fk_1] FOREIGN KEY (dept_id) REFERENCES Department(dept_id); -- Check Constraints later
ALTER TABLE [Instructor] ADD CONSTRAINT [Instructor_fk_1] FOREIGN KEY (dept_id) REFERENCES Department(dept_id); -- Check Constraints later

-- Topic [top_id, top_name, crs_id]

CREATE TABLE [Topic]
(
    top_id INTEGER PRIMARY KEY ,
    top_name varChar(100) NOT NULL,
    crs_id INTEGER NOT NULL,
    FOREIGN KEY (crs_id) REFERENCES Course(crs_id) ON DELETE CASCADE,
);

-- Exam [ex_id, date, crs_id]

CREATE TABLE [Exam]
(
    ex_id INTEGER PRIMARY KEY ,
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

CREATE TABLE [Exam_Answer]
(
    std_id INTEGER ,
    ex_id INTEGER ,
    q_id INTEGER ,
    std_answer VARCHAR(1) NOT NULL,
    FOREIGN KEY (std_id) REFERENCES Student(std_id) ,
    FOREIGN KEY (ex_id) REFERENCES Exam(ex_id) , 
	CONSTRAINT c_EA CHECK (std_answer IN ('a','b','c','d','T','F')), -- Possible trigger on insert 
	PRIMARY KEY (std_id,ex_id,q_id)
);

-- Question [q_id, q_type, q_text, corr_answer, crs_id]
CREATE TABLE [Question]
(
    q_id INTEGER PRIMARY KEY ,
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



------------------------------------------------------------------------

alter procedure Insert_Student @f_name varchar(20), @l_name varchar(20), @address varchar(30), @email varchar(20), @password varchar(30), @dept_name varchar(20), @id_std int output
with encryption
as
declare @id_dept int
	begin try
		insert into [User] values ('s', @f_name, @l_name, @address, @email, @password)
		select @id_std = usr_id from [User] where email = @email
		select @id_dept = dept_id from [Department] where dept_name = @dept_name
		insert into [Student] values (@id_std, @id_dept)
		return @id_std
	end try
	begin catch
		select 'Duplicate Email'
	end catch

------------------------------------------------------------------------

alter procedure Insert_Instructor @f_name varchar(20), @l_name varchar(20), @address varchar(30), @email varchar(20), @password varchar(30), @sal int, @degree varchar(50), @hire_date date = getdate, @dept_name varchar(20), @id_ins int output
with encryption
as
declare @id_dept int
	begin try
		insert into [User] values ('i', @f_name, @l_name, @address, @email, @password)
		select @id_ins = usr_id from [User] where email = @email
		select @id_dept = dept_id from [Department] where dept_name = @dept_name
		insert into [Instructor] values (@id_ins, @sal, @degree, @id_dept, @hire_date)
		return @id_ins
	end try
	begin catch
		select 'Duplicate Email'
	end catch

------------------------------------------------------------------------

alter procedure Insert_Department @dept_id int, @dept_name varchar(20), @mgr_name varchar(20), @id_mgr int output
with encryption
as
if not exists (select dept_id from [Department] where dept_id = @dept_id)
begin
	begin try
		select @id_mgr = usr_id from [User] where f_name = @mgr_name
		insert into [Department] values (@dept_id, @dept_name, @id_mgr)
		return @id_mgr
	end try
	begin catch
		select 'no instructor with name ' + @mgr_name ' found'
	end catch
end
else 
	select 'duplicate Department ID'

------------------------------------------------------------------------

create procedure Delete_Department @dept_name varchar(20)
with encryption
as
if exists (select dept_name from [Department] where dept_name = @dept_name)
begin
	begin try
		delete from [Department] where dept_name = @dept_name
	end try
	begin catch
		select 'Please assign the manager to another department first'
	end catch
end
else 
	select 'No department with name ' + @dept_name

------------------------------------------------------------------------

create procedure Update_Department_Manager @dept_name varchar(20), @mgr_name varchar(20)
with encryption
as
if exists (select dept_name from [Department] where dept_name = @dept_name)
begin
declare @id_mgr int
	begin try
		select @id_mgr = usr_id from [User] where f_name = @mgr_name
		update [Department] set mgr_id = @id_mgr where dept_name = @dept_name
	end try
	begin catch
		select 'Error: There is no an instructor named ' + @mgr_name
	end catch
end
else 
	select 'No department with name ' + @dept_name

------------------------------------------------------------------------


create procedure Insert_Course @crs_id int, @crs_name varchar(20)
with encryption
as
if not exists (select crs_id from [Course] where crs_id = @crs_id)
		insert into [course] values(@crs_id, @crs_name)
else 
	select 'Duplicate ID'

------------------------------------------------------------------------

alter procedure Delete_Course @crs_name varchar(20)
with encryption
as
if exists (select crs_name from [Course] where crs_name = @crs_name)
	begin
		declare @id_course int
		select @id_course = crs_id from [Course] where crs_name = @crs_name

		delete from [Course_Attendance] where crs_id = @id_course			
		delete from [Course] where crs_name = @crs_name
	end
else 
	select 'There is no course named ' + @crs_name

------------------------------------------------------------------------

alter procedure Insert_Topic @top_id int, @top_name varchar(20), @crs_name varchar(20)
with encryption
as
declare @id_crs int
if not exists (select top_id from [Topic] where top_id = @top_id)
	begin
		select @id_crs = crs_id from [Course] where crs_name = @crs_name
		insert into Topic values (@top_id, @top_name, @id_crs)
	end 
else 
	select 'This Topic already exists'

------------------------------------------------------------------------

create procedure Delete_Topic @top_name varchar(20)
with encryption
as
if exists (select top_name from [Topic] where top_name = @top_name)
	begin
		delete from Topic where top_name = @top_name 
	end 
else 
	select 'There is no topic named ' + @top_name

------------------------------------------------------------------------

alter procedure Assign_Course_to_Instructor @crs_name varchar(20), @ins_id int
with encryption
as
if not exists (select crs_name from [course] where crs_name = @crs_name)
	begin
		if not exists (select @ins_id from [User] where usr_id = @ins_id)
			begin try
				insert into [Ins_Course] (crs_id, ins_id)
				values ((select crs_id from [Course] where crs_name = @crs_name), @ins_id)
			end try
			begin catch
				select 'the Instructor is already assgined to this course'
			end catch
		else
			select 'There is no Instructor named ' + @ins_id
	end
else 
	select 'There is no Course named ' + @crs_name

------------------------------------------------------------------------

alter procedure End_Course_with_Instructor @crs_name varchar(20), @ins_id int
with encryption
as
if not exists (select crs_name from [course] where crs_name = @crs_name)
	begin
		if not exists (select usr_id from [User] where usr_id = @ins_id)
			begin
				delete from [Ins_Course] where
				(ins_id = @ins_id and 
				crs_id = (select crs_id from [Course] where crs_name = @crs_name))
			end
		else
			select 'There is no Instructor with this ID'
	end
else 
	select 'There is no Course named ' + @crs_name

--------------------------------------------------------------------------

create procedure Student_Take_course_with_Instructor @std_id int, @crs_id int, @ins_id int
as
if not exists (select usr_id from [User] where usr_id = @ins_id)
and not exists (select usr_id from [User] where usr_id = @std_id)
	begin
		if not exists (select crs_id from [Course] where crs_id = @crs_id)
			begin
				if exists (select crs_id, ins_id from [Ins_Course] 
				where (crs_id = @crs_id and ins_id = @ins_id))
				insert into Course_Attendance (crs_id, std_id, ins_id)
				values(@crs_id, @std_id, @ins_id)
				
				else
					select 'This course is not assgined to this instructor'
			end 
		else
			select 'There is no course with this ID'
	end

else
	select 'Please check the Instructor and Student ID'

-----------------------------------------------------------------------

create procedure End_Course_for_Student @crs_name varchar(20), @std_id int
with encryption
as
if exists (select crs_name from [course] where crs_name = @crs_name)
	begin
		if exists (select usr_id from [User] where usr_id = @std_id)
			begin
				declare @id_course int
				select @id_course = crs_id from [Course] where crs_name = @crs_name
					if exists (select crs_id, std_id from [Course_Attendance] 
								where (crs_id = @id_course and std_id = @std_id))
						begin
							delete from [Course_Attendance]	
							where (crs_id = @id_course and std_id = @std_id)
						end
					else
						select 'This student does not take this course'
			end
		else
			select 'There is no student with this ID'
	end
else 
	select 'There is no Course named ' + @crs_name

-------------------------------------------------------------------------