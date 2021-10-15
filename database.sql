CREATE DATABASE books; 
USE books;
SET GLOBAL max_allowed_packet = 16777216;
CREATE TABLE books_managment (
id int auto_increment primary key,
book_name VARCHAR(50),
book_author VARCHAR(50),
genre varchar(50)
);

CREATE TABLE pdf_library (
id int auto_increment primary key,
content MEDIUMBLOB,
file_name VARCHAR(255)
);
DELIMITER //
CREATE PROCEDURE sp_library_Insert (
IN p_content MEDIUMBLOB,
IN p_file_name varchar(50),
OUT p_id INT
)
BEGIN
INSERT INTO pdf_library(id, content, file_name) VALUES (p_id, p_content, p_file_name);
SET p_id = LAST_INSERT_ID();
END // 
DELIMITER //
CREATE PROCEDURE sp_books_Insert (
IN p_book_name varchar(50),
IN p_book_author varchar(50),
IN p_genre varchar(50),
OUT p_id INT
)
BEGIN
INSERT INTO books_managment(id, book_name, book_author, genre) VALUES (p_id, p_book_name, p_book_author, p_genre);
SET p_id = LAST_INSERT_ID();
END // 

CREATE PROCEDURE sp_books_Update (
IN p_book_name varchar(50),
IN p_book_author varchar(50),
IN p_genre varchar(50),
IN p_id INT
)
BEGIN 
Update books_managment
SET 
book_name=p_book_name , book_author=p_book_author , genre=p_genre
WHERE id=p_id;
END //


