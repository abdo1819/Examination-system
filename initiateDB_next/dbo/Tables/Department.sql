-- Department [dept_id, dept_name, mgr_id]

CREATE TABLE [Department]
(
    dept_id INTEGER PRIMARY KEY IDENTITY(100, 100),
    dept_name varChar(100) UNIQUE NOT NULL,
    mgr_id INTEGER NOT NULL ,
    FOREIGN KEY (mgr_id) REFERENCES Instructor(ins_id) , -- Check Constraints later
);