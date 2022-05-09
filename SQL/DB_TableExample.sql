-- using MS SQL Server
DROP TABLE IF EXISTS EVENTS

CREATE TABLE EVENTS(
EventId INT PRIMARY KEY NOT NULL,
EventName VARCHAR(50),
Date DATETIME,
State VARCHAR(50),
City VARCHAR(80),
Address VARCHAR(200),
IsValid BIT
);

INSERT INTO EVENTS (EventId, EventName, Date, State, City, Address, IsValid)
VALUES (0001, 'test event', '20220615', 'State', 'City', 'Test Address', 1);


SELECT * FROM EVENTS;
