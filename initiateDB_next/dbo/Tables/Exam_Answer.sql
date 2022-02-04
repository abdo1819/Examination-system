CREATE TABLE [Exam_Answer]
(
    std_id INTEGER ,
    ex_id INTEGER ,
    q_id INTEGER ,
    std_answer VARCHAR(1),
	std_mark AS dbo.getQuestionMark(q_id), -- std_mark is computed based on the function
    FOREIGN KEY (std_id) REFERENCES Student(std_id) on delete cascade,
    FOREIGN KEY (ex_id) REFERENCES Exam(ex_id) on delete cascade, 
	CONSTRAINT c_EA CHECK (std_answer IN ('a','b','c','d','T','F')), -- Possible trigger on insert 
	PRIMARY KEY (std_id,ex_id,q_id)
);
GO
ALTER TABLE [Exam_Answer] ADD CONSTRAINT [Exam_Answer_fk_1] FOREIGN KEY (q_id) REFERENCES Question(q_id) ;