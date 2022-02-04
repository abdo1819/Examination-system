/* ----------------------- required helping procedure ----------------------- */

/* -------------------------------------------------------------------------- */
/*                            Create Department                               */
/* -------------------------------------------------------------------------- */

-- Department [dept_id, dept_name, mgr_id]
create procedure Insert_Department @dept_name varchar(20), @id_mgr int, @dept_id int output
as
	if exists (select ins_id from [Instructor] where ins_id = @id_mgr)
	begin
		insert into [Department] values (@dept_name, @id_mgr)
		select @dept_id = dept_id from Department where dept_name = @dept_name
		return 1
	end
	else
	begin
		select 'no instructor with ID ' + cast(@id_mgr as varchar) +' found'
		return 0
	end
------------------------------------------------------------------------