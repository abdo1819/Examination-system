/* ------------------------------------------------------------------------------- */
/*                                  Course CRUDs                                   */
/* ------------------------------------------------------------------------------- */


/* ------------------------------------------------------------------------------- */
/*                               Insert Course                                     */
/* ------------------------------------------------------------------------------- */

create procedure Insert_Course @crs_name varchar(20)
as
if not exists (select @crs_name from [Course] where crs_name = @crs_name)
	insert into [course] values(@crs_name)
else
	select 'This course already exists' as [Error Message]