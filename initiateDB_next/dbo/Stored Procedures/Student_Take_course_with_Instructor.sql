/* ------------------------------------------------------------------------------- */
/*            Student, Course, Instructor CRUDs (Course_Attendance table)          */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*                      Student Take Course with Instructor                        */
/* ------------------------------------------------------------------------------- */

create procedure Student_Take_course_with_Instructor @std_id int, @crs_id int, @ins_id int
as 
BEGIN TRY
if exists (select ins_id from [Instructor] where ins_id = @ins_id) 
and exists (select std_id from [Student] where std_id = @std_id)
	begin
		if exists (select crs_id from [Course] where crs_id = @crs_id)
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
END TRY
BEGIN CATCH
	SELECT 'Duplicate data , please check your data' AS [Error Message]
END CATCH