-- Question [q_id, q_type, q_text, corr_answer, top_id]
CREATE TABLE [Question]
(
    q_id INTEGER PRIMARY KEY IDENTITY(500, 50),
    q_type varChar(3) NOT NULL,
    q_text varChar(300) NOT NULL,
    corr_answer varChar(1) NOT NULL,
    top_id INTEGER NOT NULL,
    FOREIGN KEY (top_id) REFERENCES Topic(top_id) ON DELETE CASCADE,
	CONSTRAINT c_questype CHECK (q_type IN ('TF', 'MCQ')) ,
	CONSTRAINT c_corr_answer CHECK ( ( (q_type = 'TF') AND (corr_answer IN ('T', 'F') ) ) OR ( (q_type = 'MCQ') AND (corr_answer IN ('a', 'b','c','d')) ) ) 
);