-- User [usr_id, user_type, f_name, l_name, address, email, password]

CREATE TABLE [User]
(
    usr_id INTEGER PRIMARY KEY IDENTITY,
    user_type varChar(1) NOT NULL,
    f_name varChar(50) NOT NULL,
    l_name varChar(50) NOT NULL,
    address varChar(150) ,
    email varChar(90) UNIQUE NOT NULL,
    hashed_password varChar(255) NOT NULL, 
	CONSTRAINT c_user_type CHECK (user_type IN ('I','S'))
);