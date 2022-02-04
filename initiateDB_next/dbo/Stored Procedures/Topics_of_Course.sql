/* ------------------------------------------------------------------------------- */
/*   			 Report that takes course ID and returns its topics 	           */
/* ------------------------------------------------------------------------------- */

create procedure Topics_of_Course @crs_name varchar(20)
as
if exists(select crs_name from Course where crs_name = @crs_name)
begin
	select t.top_name
	from Course c
	inner join Topic t
	on c.crs_id = t.crs_id
	where c.crs_name = @crs_name
end
else
	select 'There is no course named ' + @crs_name