-- Check Constraints later

-- Topic [top_id, top_name, crs_id]

CREATE TABLE [Topic]
(
    top_id INTEGER PRIMARY KEY IDENTITY(10000, 1000),
    top_name varChar(100) UNIQUE NOT NULL,
    crs_id INTEGER NOT NULL,
    FOREIGN KEY (crs_id) REFERENCES Course(crs_id) ON DELETE CASCADE,
);