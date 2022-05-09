-- using MS SQL Server
DROP TABLE IF EXISTS EVENTS

CREATE TABLE EVENTS(
eventId INT PRIMARY KEY NOT NULL,
eventName VARCHAR(50),
eventDate DATETIME,
eventAddress VARCHAR(200),
isValid BIT
);

INSERT INTO EVENTS (eventId, eventName, eventDate, eventAddress, isValid)
VALUES (0001, 'test event', '20220615', 'Test Address', 1);


SELECT * FROM EVENTS;