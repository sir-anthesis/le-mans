CREATE DATABASE db_retrorace;

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
