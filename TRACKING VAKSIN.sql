--	DATABASE TRACKING VAKSIN	--
-- SQL Server 2014 
CREATE DATABASE TRACKING_VAKSIN_15;

USE TRACKING_VAKSIN_15;

CREATE TABLE Users(
    id int PRIMARY KEY IDENTITY(1,1),
    username VARCHAR(32) PRIMARY KEY,
    password VARCHAR(32),
    role VARCHAR(16)
);

CREATE TABLE Residents(
    NIK VARCHAR(16) PRIMARY KEY,
    name VARCHAR(32),
    age INT,
    address VARCHAR(64),
    gender VARCHAR(1),
    user_id int,
    FOREIGN KEY (user_id) REFERENCES Users(id)
);

CREATE TABLE Vaccine(
    id int PRIMARY KEY IDENTITY(1,1),
    code VARCHAR(16),
    registered_number VARCHAR(16) NULL,
    registered_date DATE NULL,
    created_at DATE,
    status INT,
);


-- Insert dummy data
INSERT INTO Users (username, password, role) VALUES ('produsen', 'produsen', 'produsen');
-- INSERT INTO Users (username, password, role) VALUES ('distributor', 'distributor', 'distributor');