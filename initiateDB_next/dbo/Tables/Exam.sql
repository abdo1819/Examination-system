-- Exam [ex_id, date, crs_id]

CREATE TABLE [Exam]
(
    ex_id INTEGER PRIMARY KEY IDENTITY(10, 10),
    date Date NOT NULL DEFAULT GETDATE(),
    crs_id INTEGER NOT NULL,
    FOREIGN KEY (crs_id) REFERENCES Course(crs_id) , -- Check constraints later
);