CREATE TABLE BankAccount (
	AccID Int PRIMARY KEY NOT NULL,
	email varchar(150) UNIQUE NOT NULL,
	password varchar(30) NOT NULL,
	name varchar(150) NOT NULL,
	CheckingBal decimal(18,2),
	SavingBal decimal(18,2),
	MMABal decimal(18,2),
	CDsBal decimal(18,2),
	MuFundBal decimal(18,2)
)

CREATE TABLE TransactionHistory (
	AccID Int NOT NULL,
	TransID Int NOT NULL,
	TransMemo varchar(100) NOT NULL,
	Balance decimal(18,2) NOT NULL
)

INSERT INTO BankAccount (AccID, email, password, name, CheckingBal, SavingBal, MMABal, CDsBal, MuFundBal)
VALUES 
(1230, 'ajax92@gmail.com', 'leonRell_82', 'Alexa Jaxel', 123.34, 19432.82, 100832.82, NULL, NULL),
(1231, 'jhimtron73@gmail.com', 'TyronLee_01', 'James Himtron', 563.82, 30812.89, 100832.82, NULL, 284913.92),
(1232, 'jaclane46@gmail.com', 'GoodNight_92', 'Jack Lane', 83.92, 7382.03, NULL, NULL, NULL),
(1233, 'jimharton47@gmail.com', 'Leona_833@Dash', 'Jim Harton', 1084.92, 25442.93, NUll, 842341.83, NULL),
(1234, 'geraldharnold@gmail.com', 'Gerald_83', 'Gerald Harnold', 2039.84, 59832.72, NULL, NULL, NULL)

INSERT INTO TransactionHistory (AccID, TransID, TransMemo, Balance) 
VALUES
(1233, 328923, 'Belk', 32.94),
(1234, 328924, 'Starbucks', 10.98),
(1232, 328925, '7-Eleven', 40.64),
(1230, 328926, 'QuikTrips', 3.45),
(1231, 328927, 'Walmart', 106.83),
(1233, 328928, 'Macy', 192.83),
(1233, 328929, 'Transfer', 500.00),
(1234, 328930, 'Transfer', 1000.00),
(1230, 328931, 'Target', 23.82),
(1231, 328932, 'Whole Mart', 34.76),
(1232, 328933, 'PayCheck', 4367.00),
(1230, 328934, 'PayCheck', 3500.00),
(1231, 328935, 'PayCheck', 2670.00),
(1234, 328936, 'PayCheck', 5000.00),
(1233, 328937, 'American Eagle', 234.65),
(1231, 328938, 'Transfer', 750.00),
(1232, 328939, 'Transfer', 250.00),
(1232, 328940, 'Michael', 32.29),
(1233, 328941, 'McDonald', 13.56),
(1234, 328942, 'Bojanges', 7.68),
(1230, 328943, 'ChickFila', 9.56),
(1231, 328944, 'Walmart', 45.86),
(1233, 328945, 'Amazon', 76.94),
(1234, 328946, 'CyberPowerPC', 985.83),
(1230, 328947, 'Walmart', 76.83),
(1232, 328948, '7-Eleven', 34.67)