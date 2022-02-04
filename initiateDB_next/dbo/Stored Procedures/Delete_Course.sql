/* ------------------------------------------------------------------------------- */
/*                                Delete Course                                    */
/* ------------------------------------------------------------------------------- */

create procedure Delete_Course @crs_name varchar(20)
as
if exists (select crs_name from [Course] where crs_name = @crs_name)
	delete from [Course] where crs_name = @crs_name
else 
	select 'There is no course named ' + @crs_name