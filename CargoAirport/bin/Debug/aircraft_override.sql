DROP TABLE Aircraft;

CREATE TABLE Aircraft (
   ID INTEGER NOT NULL PRIMARY KEY,
   Model TEXT NOT NULL,
   MassAllowed INTEGER NOT NULL,
   VolumeAllowed INTEGER NOT NULL,
   Availability BOOL NOT NULL,
   DepartureTime TEXT,
   ArrivalTime TEXT,
   ReturnTime TEXT
);