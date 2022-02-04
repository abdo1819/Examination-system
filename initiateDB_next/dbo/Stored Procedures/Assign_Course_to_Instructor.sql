/* ------------------------------------------------------------------------------- */
/*                    Course, Instructor CRUDs (Ins_Course table)                  */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*                           Assign Instructor to Course                           */
/* ------------------------------------------------------------------------------- */

create procedure Assign_Course_to_Instructor @crs_name varchar(20), @ins_id int
as
if exists (select crs_name from [Course] where crs_name = @crs_name)
	begin
		if exists (select @ins_id from [Instructor] where ins_id = @ins_id)
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