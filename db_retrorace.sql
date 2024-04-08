CREATE DATABASE db_retrorace;

-- TABLES
CREATE TABLE tb_account (
    id_account INT IDENTITY(1,1) PRIMARY KEY,
    email VARCHAR(15),
    username VARCHAR(15),
    name VARCHAR(15),
    password VARCHAR(15),
    car_active VARCHAR(5),
	coins INT
);


CREATE TABLE tb_carlist (
	id_car VARCHAR (5) PRIMARY KEY,
	car_name VARCHAR (30) UNIQUE,
	car_right VARCHAR (10),
	car_left VARCHAR (10),
	car_pixel VARCHAR (10),
	speed INT,
	price INT,
	status VARCHAR (10)
);

INSERT INTO tb_carlist(id_car, car_name, car_right, car_left, car_pixel, speed, price)
VALUES 
('CR1', 'Audi A4 Tango', 'cr1.png', 'cl1.png', 'cp1.png', 17, 50),
('CR2', 'McLaren MCL35', 'cr2.png', 'cl2.png', 'cp2.png', 20, 150),
('CR3', 'Lamborghini Huracan', 'cr3.png', 'cl3.png', 'cp3.png', 22, 275),
('CR4', 'Aston Martin Valhalla', 'cr4.png', 'cl4.png', 'cp4.png', 25, 400),
('CR5', 'W MOTORS Fenryr', 'cr5.png', 'cl5.png', 'cp5.png', 27, 500);

CREATE TABLE tb_carowned (
    id_account INT,
    id_car VARCHAR(5),
    car_name VARCHAR(30),
    FOREIGN KEY (id_account) REFERENCES tb_account(id_account),
    FOREIGN KEY (id_car) REFERENCES tb_carlist(id_car)
);

CREATE TABLE tb_history (
	id_history INT IDENTITY(1,1) PRIMARY KEY,
	id_account INT,
	id_car VARCHAR(5),
	acc_name VARCHAR(15),
	car_name VARCHAR(50),
	score INT,
	time DATETIME
	FOREIGN KEY (id_account) REFERENCES tb_account(id_account),
    FOREIGN KEY (id_car) REFERENCES tb_carlist(id_car)
);

CREATE TABLE tb_leaderboard (
	id_account INT,
	acc_name VARCHAR(15),
	car_name VARCHAR(50),
	score INT,
	FOREIGN KEY (id_account) REFERENCES tb_account(id_account),
);


-- TRUGGERS
CREATE TRIGGER trg_newacc
ON tb_account
AFTER INSERT
AS
BEGIN
    INSERT INTO tb_carowned (id_account, id_car, car_name)
    SELECT id_account, 'CR1', 'Audi A4 Tango'
    FROM inserted;
END;

CREATE TRIGGER trg_updleaderboard
ON tb_history
AFTER INSERT
AS
BEGIN
    DECLARE @existing_score INT;
    DECLARE @existing_car_name VARCHAR(50);

    -- Get the existing score and car_name for the id_account in tb_leaderboard
    SELECT @existing_score = score, @existing_car_name = car_name
    FROM tb_leaderboard
    WHERE id_account = (SELECT id_account FROM inserted);

    -- Check if the id_account already exists in tb_leaderboard
    IF EXISTS (SELECT 1 FROM tb_leaderboard WHERE id_account = (SELECT id_account FROM inserted)) 
    BEGIN
        -- Update the row if the new score is higher
        IF (SELECT score FROM inserted) > @existing_score
        BEGIN
            UPDATE tb_leaderboard
            SET score = (SELECT score FROM inserted),
                car_name = (SELECT car_name FROM inserted)
            WHERE id_account = (SELECT id_account FROM inserted);
        END
    END
    ELSE
    BEGIN
        -- Insert if the id_account doesn't exist in tb_leaderboard
        INSERT INTO tb_leaderboard (id_account, acc_name, car_name, score)
        SELECT id_account, acc_name, car_name, score
        FROM inserted;
    END
END;

