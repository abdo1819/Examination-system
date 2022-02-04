-- Course [crs_id, crs_name]

CREATE TABLE [Course]
(
    crs_id INTEGER PRIMARY KEY IDENTITY(1000, 100),
    crs_name varChar(100) UNIQUE NOT NULL,
);

-- Course_Attendance [crs_id, std_id, ins_id, grade]

-- getQuestionMark must be created before Course_Attendance Table is created