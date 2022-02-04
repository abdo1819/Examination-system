-- Student [std_id, dept_id]
CREATE TABLE [Student]
(
    std_id INTEGER PRIMARY KEY ,
    dept_id INTEGER NOT NULL,
    FOREIGN KEY (std_id) REFERENCES [User](usr_id) ON DELETE CASCADE,
);
GO
ALTER TABLE [Student] ADD CONSTRAINT [Student_fk_1] FOREIGN KEY (dept_id) REFERENCES Department(dept_id);