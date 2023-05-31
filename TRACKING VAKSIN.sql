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
    status INT,
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

CREATE TABLE VaccineUsage(
    id int PRIMARY KEY IDENTITY(1,1),
    vaccine_id int,
    resident_id VARCHAR(16),
    used_at DATE,
    FOREIGN KEY (vaccine_id) REFERENCES Vaccine(id),
    FOREIGN KEY (resident_id) REFERENCES Residents(NIK)
);


-- Insert dummy data
INSERT INTO Users (username, password, role) VALUES ('produsen', 'produsen', 'produsen');
INSERT INTO Users (username, password, role) VALUES ('bpom', 'bpom', 'bpom');
INSERT INTO Users (username, password, role) VALUES ('rumahsakit', 'rumahsakit', 'rumahsakit');
INSERT INTO Users (username, password, role) VALUES ('pemerintah', 'pemerintah', 'pemerintah');

-- Insert dummy data
INSERT INTO Vaccine (code, registered_number, registered_date, created_at, status)
VALUES
    ('VAC001', NULL, NULL, '2023-05-01', 1),
    ('VAC002', NULL, NULL, '2023-05-02', 1),
    ('VAC003', NULL, NULL, '2023-05-03', 1),
    ('VAC004', NULL, NULL, '2023-05-04', 1),
    ('VAC005', NULL, NULL, '2023-05-05', 1),
    ('VAC006', NULL, NULL, '2023-05-06', 1),
    ('VAC007', NULL, NULL, '2023-05-07', 1),
    ('VAC008', NULL, NULL, '2023-05-08', 1),
    ('VAC009', NULL, NULL, '2023-05-09', 1),
    ('VAC010', NULL, NULL, '2023-05-10', 1),
    ('VAC011', NULL, NULL, '2023-05-11', 1),
    ('VAC012', NULL, NULL, '2023-05-12', 1),
    ('VAC013', NULL, NULL, '2023-05-13', 1),
    ('VAC014', NULL, NULL, '2023-05-14', 1),
    ('VAC015', NULL, NULL, '2023-05-15', 1),
    ('VAC016', NULL, NULL, '2023-05-16', 1),
    ('VAC017', NULL, NULL, '2023-05-17', 1),
    ('VAC018', NULL, NULL, '2023-05-18', 1),
    ('VAC019', NULL, NULL, '2023-05-19', 1),
    ('VAC020', NULL, NULL, '2023-05-20', 1);