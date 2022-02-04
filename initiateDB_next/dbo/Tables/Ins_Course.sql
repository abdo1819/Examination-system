-- Ins_Course [crs_id, ins_id, evaluation, dept_id]

CREATE TABLE [Ins_Course]
(
    crs_id INTEGER ,
    ins_id INTEGER ,
    evaluation INTEGER ,
    FOREIGN KEY (crs_id) REFERENCES Course(crs_id) on delete cascade,
    FOREIGN KEY (ins_id) REFERENCES Instructor(ins_id) on delete cascade,
	CONSTRAINT c_CA_PK PRIMARY KEY (crs_id,ins_id),
	CONSTRAINT c_IC_eval CHECK (evaluation BETWEEN 0 AND 10)
);