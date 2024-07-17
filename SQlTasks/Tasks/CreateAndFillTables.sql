CREATE TABLE Countries (
    ID INT PRIMARY KEY,
    Name NVARCHAR(50)
);

INSERT INTO Countries (ID, Name)
VALUES 
(1, 'Russia'),
(2, 'Japan'),
(3, 'Korea');


CREATE TABLE Brands (
    ID INT PRIMARY KEY,
    Name NVARCHAR(50),
    CountryID INT,
    FOREIGN KEY (CountryID) REFERENCES Countries(ID)
);

INSERT INTO Brands (ID, Name, CountryID)
VALUES 
(1, 'LADA', 1),
(2, 'Toyota', 2),
(3, 'Nissan', 2),
(4, 'Mitsubishi', 2),
(5, 'Hyundai', 3),
(6, 'KIA', 3);


CREATE TABLE Cars (
    ID INT PRIMARY KEY,
    Name NVARCHAR(50),
    BrandID INT,
    Pow INT,
    Long INT,
    Price INT,
    BaseID INT NULL,
    FOREIGN KEY (BrandID) REFERENCES Brands(ID)
);

INSERT INTO Cars (ID, Name, BrandID, Pow, Long, Price, BaseID)
VALUES 
(1, 'Rio', 6, 100, 4400, 734, 4),
(2, 'Ceed', 6, 128, 4340, 1039, NULL),
(3, 'Sorento', 6, 175, 4670, 1544, 2),
(4, 'Solaris', 5, 99, 4430, 746, NULL),
(5, 'Elantra', 5, 128, 4580, 1059, 10),
(6, 'Tuscon', 5, 185, 4620, 1499, NULL),
(7, 'Granta', 1, 87, 4260, 404, NULL),
(8, 'Vesta', 1, 106, 4410, 567, 4),
(9, 'Largus', 1, 87, 4470, 558, NULL),
(10, 'Corolla', 2, 122, 4300, 1173, NULL),
(11, 'Camry', 2, 249, 4500, 1573, 10),
(12, 'Hillux', 2, 177, 4420, 2306, NULL),
(13, 'Land Cruiser 200', 2, 309, 5200, 4875, NULL),
(14, 'Outlander', 4, 146, 4800, 1449, NULL),
(15, 'L200', 4, 154, 5300, 1869, NULL),
(16, 'Pajero', 4, 200, 4900, 2719, 14),
(17, 'Qashqai', 3, 115, 4460, 1120, NULL),
(18, 'X-trail', 3, 144, 4380, 1370, 17),
(19, 'Murano', 3, 249, 4690, 2099, 17);