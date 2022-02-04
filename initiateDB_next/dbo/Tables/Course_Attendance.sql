CREATE TABLE [Course_Attendance]
(
    crs_id INTEGER ,
    std_id INTEGER ,
    ins_id INTEGER ,
    grade AS dbo.getStudentGrade(crs_id, std_id),
    FOREIGN KEY (crs_id) REFERENCES Course(crs_id) on delete cascade ,
    FOREIGN KEY (std_id) REFERENCES Student(std_id) on delete cascade,
    FOREIGN KEY (ins_id) REFERENCES Instructor(ins_id) ,
	PRIMARY KEY (crs_id,std_id,ins_id)
);