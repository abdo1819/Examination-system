/* -------------------------------------------------------------------------- */
/*                             Delete Department                              */
/* -------------------------------------------------------------------------- */

create procedure Delete_Department @dept_name varchar(20)
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