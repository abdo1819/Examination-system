-- Instructor [ins_id, salary, degree, dept_id]

CREATE TABLE [Instructor]
(
    ins_id INTEGER PRIMARY KEY ,
    salary MONEY ,
    degree varChar(50) ,
    dept_id INTEGER NOT NULL,
	hire_date DATE DEFAULT GETDATE(),
    FOREIGN KEY (ins_id) REFERENCES [User](usr_id) ON DELETE CASCADE,
);
GO
-- Check Constraints later
ALTER TABLE [Instructor] ADD CONSTRAINT [Instructor_fk_1] FOREIGN KEY (dept_id) REFERENCES Department(dept_id);