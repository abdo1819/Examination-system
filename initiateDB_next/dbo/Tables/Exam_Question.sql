-- Exam_Question [ex_id, q_id]

CREATE TABLE [Exam_Question]
(
    ex_id INTEGER ,
    q_id INTEGER ,
    FOREIGN KEY (ex_id) REFERENCES Exam(ex_id),
	PRIMARY KEY (ex_id,q_id)
);

-- Exam_Answer [std_id, ex_id, q_id, std_answer]

-- getQuestionMark must be created before Exam_Answer Table is created
GO
ALTER TABLE [Exam_Question] ADD CONSTRAINT [Exam_Question_fk_1] FOREIGN KEY (q_id) REFERENCES Question(q_id) ;