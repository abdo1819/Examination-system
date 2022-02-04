/* ------------------------------------------------------------------------------- */
/*                                   Delete Topic                                  */
/* ------------------------------------------------------------------------------- */

create procedure Delete_Topic @top_name varchar(20)
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