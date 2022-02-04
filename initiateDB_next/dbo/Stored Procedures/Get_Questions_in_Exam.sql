/* ------------------------------------------------------------------------------- */
/*    Report that takes exam number and returns the Questions in it and choices	   */
/* ------------------------------------------------------------------------------- */

-- Fathy Comment: It is mentioned it should be a "Freeform report", refer to this link
-- https://docs.microsoft.com/en-us/sql/reporting-services/tutorial-creating-a-free-form-report-report-builder?view=sql-server-ver15

create procedure Get_Questions_in_Exam @ex_id int
as
if exists(select ex_id from Exam where ex_id = @ex_id)
begin
	select q.q_text, q.q_type, mcq.ch_a, mcq.ch_b, mcq.ch_c, mcq.ch_d
	from Exam e
	inner join Exam_Question eq
	on e.ex_id = eq.ex_id
	inner join Question q
	on eq.q_id = q.q_id
	left join MCQ mcq
	on q.q_id = mcq.q_id
	where e.ex_id = @ex_id
end
else
	select 'Wrong Exam ID'