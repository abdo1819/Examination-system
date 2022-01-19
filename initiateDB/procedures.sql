
------------------------------------------------------------------------
GO
create or alter procedure Insert_Student @f_name varchar(20), @l_name varchar(20), @address varchar(30), @email varchar(20), @password varchar(30), @dept_name varchar(20), @id_std int output
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
GO


create or alter procedure Insert_Instructor @f_name varchar(20), @l_name varchar(20), @address varchar(30), @email varchar(20), @password varchar(30), @sal int, @degree varchar(50), @hire_date date = getdate, @dept_name varchar(20), @id_ins int output
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
GO

create or alter procedure Insert_Department @dept_name varchar(20), @id_mgr int, @dept_id int output
as
	if not exists (select usr_id from [User] where usr_id = @id_mgr)
	begin
		insert into [Department] values (@dept_id, @dept_name, @id_mgr)
		select @dept_id = dept_id from Department where dept_name = @dept_name
		return 1
	end
	else
	begin
		select 'no instructor with ID ' + @id_mgr' found'
		return 0
	end
------------------------------------------------------------------------
GO
create or alter procedure Delete_Department @dept_name varchar(20)
as
if exists (select dept_name from [Department] where dept_name = @dept_name)
begin
	begin try
		delete from [Department] where dept_name = @dept_name
		return  1 -- deleted successfully 
	end try
	begin catch
		select 'Please check for instructors and students in this department'
		return 0
	end catch
end
else 
begin
	select 'No department with name ' + @dept_name
	return 0
end

GO
------------------------------------------------------------------------

create or alter procedure Update_Department_Manager @dept_name varchar(20), @mgr_id int
as
if exists (select dept_name from [Department] where dept_name = @dept_name)
begin
	begin try
		update [Department] set mgr_id = @mgr_id where dept_name = @dept_name
	end try
	begin catch
		select 'Error: There is no an instructor with ID ' + @mgr_id
	end catch
end
else 
	select 'No department with name ' + @dept_name

------------------------------------------------------------------------
GO

create or alter procedure Insert_Course @crs_name varchar(20)
as
if not exists (select @crs_name from [Course] where crs_name = @crs_name)
	insert into [course] values(@crs_name)
else
	select 'This course already exists'

GO
------------------------------------------------------------------------

create or alter procedure Delete_Course @crs_name varchar(20)
as
if exists (select crs_name from [Course] where crs_name = @crs_name)
	delete from [Course] where crs_name = @crs_name
else 
	select 'There is no course named ' + @crs_name

------------------------------------------------------------------------
GO

create or alter procedure Insert_Topic @top_name varchar(20), @crs_name varchar(20)
as
declare @id_crs int
if not exists (select top_name from [Topic] where top_name = @top_name)
	begin
		begin try
			select @id_crs = crs_id from [Course] where crs_name = @crs_name
			insert into Topic values (@top_name, @id_crs)
		end try
		begin catch
			select 'There is no course named ' + @crs_name
		end catch
	end
else 
	select 'This Topic already exists'

GO
------------------------------------------------------------------------
create or alter procedure Delete_Topic @top_name varchar(20)
as
if exists (select top_name from [Topic] where top_name = @top_name)
	begin
	begin try
			delete from Topic where top_name = @top_name 
	end try
	begin catch
			select 'Error'
	end catch
	end 
else 
	select 'There is no topic named ' + @top_name
Go
------------------------------------------------------------------------

create or alter procedure Assign_Course_to_Instructor @crs_name varchar(20), @ins_id int
as
if not exists (select crs_name from [course] where crs_name = @crs_name)
	begin
		if not exists (select @ins_id from [Instructor] where ins_id = @ins_id)
			begin try
				insert into [Ins_Course] (crs_id, ins_id)
				values ((select crs_id from [Course] where crs_name = @crs_name), @ins_id)
			end try
			begin catch
				select 'the Instructor is already assgined to this course'
			end catch
		else
			select 'There is no Instructor ID ' + @ins_id
	end
else 
	select 'There is no Course named ' + @crs_name

Go
------------------------------------------------------------------------

create or alter procedure End_Course_with_Instructor @crs_name varchar(20), @ins_id int
as
if not exists (select crs_name from [course] where crs_name = @crs_name)
	begin
		if not exists (select ins_id from [Instructor] where ins_id = @ins_id)
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
GO

create or alter procedure Student_Take_course_with_Instructor @std_id int, @crs_id int, @ins_id int
as
if not exists (select ins_id from [Instructor] where ins_id = @ins_id)
and not exists (select std_id from [Student] where std_id = @std_id)
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
GO

create or alter procedure End_Course_for_Student @crs_name varchar(20), @std_id int
as
if exists (select crs_name from [course] where crs_name = @crs_name)
	begin
		if exists (select std_id from [Student] where std_id = @std_id)
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
			select 'There is no Course with this ID'
	end
else 
	select 'There is no Course named ' + @crs_name

-----------------------------------------------------------------