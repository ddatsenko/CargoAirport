﻿DROP TABLE Terminal;

CREATE TABLE Terminal (
   ID INTEGER NOT NULL PRIMARY KEY,
   Destination VARCHAR (3) NOT NULL,
   Mass INTEGER NOT NULL,
   Volume INTEGER NOT NULL,
   Type VARCHAR (50) NOT NULL,
   Sender VARCHAR (50) NOT NULL,
   Recipient VARCHAR (50) NOT NULL
);