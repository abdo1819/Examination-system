-- Check constraints

-- MCQ [q_id, ch_a, ch_b, ch_c, ch_d]
CREATE TABLE [MCQ]
(
    q_id INTEGER ,
    ch_a varChar(300) NOT NULL,
    ch_b varChar(300) NOT NULL,
    ch_c varChar(300) NOT NULL,
    ch_d varChar(300) NOT NULL,
    FOREIGN KEY (q_id) REFERENCES Question(q_id) ON DELETE CASCADE,
	PRIMARY KEY (q_id)
);