/* ------------------------------------------------------------------------------- */
/*    Report that takes the instructor ID and returns the name of the courses      */
/*    that he teaches and the number of student per course.                        */
/* ------------------------------------------------------------------------------- */

create proc Courses_and_Students_of_Instructor @ins_id int
as
if exists (select ins_id from [Instructor] where ins_id = @ins_id)
	begin
		select c.crs_name, count(ca.std_id) as 'number of students per course'  
		from Instructor i
		inner join Ins_Course ic
		on i.ins_id = ic.ins_id
		inner join Course c
		on ic.crs_id = c.crs_id
		inner join Course_Attendance ca
		on (c.crs_id = ca.crs_id and ca.ins_id = @ins_id)
		where i.ins_id = @ins_id
		group by c.crs_name
	end
else
	select CONCAT('There is no instructor with this ID ', @ins_id)