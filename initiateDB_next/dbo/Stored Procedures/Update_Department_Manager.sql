/* -------------------------------------------------------------------------- */
/*                     Update Department Manager                              */
/* -------------------------------------------------------------------------- */

create procedure Update_Department_Manager @dept_name varchar(20), @mgr_id int
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