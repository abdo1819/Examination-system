/*      -------------------------------------------------------------------------------     */
/*    		Report that takes exam number and the student ID then							*/
/*			returns the Questions in this exam with the student answers.   			        */
/*     -------------------------------------------------------------------------------      */

create procedure getStudentAnswer @exam_id int, @stduent_id int
as
if exists (select ex_id from [Exam] where ex_id = @exam_id)
	begin
		if exists (select std_id from Student where std_id = @stduent_id)
			begin
				select q.q_text, q.q_type, ea.std_answer, q.corr_answer
				from Exam_Answer ea
				inner join Exam_Question eq
				on ea.ex_id = eq.ex_id
				inner join Question q
				on eq.q_id = q.q_id
				where (ea.ex_id = @exam_id and ea.std_id = @stduent_id)
			end
		else 
			select CONCAT('There is no student with this ID', @stduent_id)
	end
else
	select CONCAT('There is no exam with this ID', @exam_id)