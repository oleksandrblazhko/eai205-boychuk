DROP TABLE sleep_info CASCADE;
DROP TABLE userr CASCADE;
DROP TABLE libraryy CASCADE;
DROP TABLE book CASCADE;



CREATE TABLE userr (
  	user_id INT PRIMARY KEY CHECK(user_id>0),
  	nickname VARCHAR(16) NOT NULL, 
  	email VARCHAR(32) CHECK(email = '^[a-zA-Z0-9.!#$%&''*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$')
);


CREATE TABLE sleep_info (
  	info_id INT PRIMARY KEY CHECK(info_id>0),
  	minutes INT NOT NULL CHECK(minutes BETWEEN 0 AND 900),
  	sleep_interval INTERVAL NOT NULL,
  	sleep_date DATE NOT NULL CHECK(sleep_date<CURRENT_DATE+1),
  	user_id_fk INT REFERENCES userr (user_id) CHECK(user_id_fk>0)
);

CREATE TABLE libraryy (
  	library_id INT PRIMARY KEY CHECK(library_id>0),
  	name VARCHAR(32) NOT NULL, 
	books INT NOT NULL CHECK(books>=0),
	user_id_fk INT REFERENCES userr (user_id) CHECK(user_id_fk>0)
);

CREATE TABLE book (
  	book_id INT PRIMARY KEY CHECK(book_id>0),
  	name VARCHAR(64) NOT NULL,
  	author VARCHAR(64) NOT NULL,
  	yearof_publictn INT NOT NULL CHECK(yearof_publictn>1900 AND yearof_publictn<=date_part('year', CURRENT_DATE)),
  	transl_author VARCHAR(64),
	pages INT NOT NULL CHECK(pages>0),
	library_id_fk INT REFERENCES libraryy (library_id) CHECK(library_id_fk>0)
);