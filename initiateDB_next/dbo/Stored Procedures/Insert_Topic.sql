/* ------------------------------------------------------------------------------- */
/*                                  Topic CRUDs                                    */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*                                  Insert Topic                                   */
/* ------------------------------------------------------------------------------- */

create procedure Insert_Topic @top_name varchar(20), @crs_name varchar(20)
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