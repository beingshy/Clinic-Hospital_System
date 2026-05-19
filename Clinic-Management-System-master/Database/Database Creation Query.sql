CREATE DATABASE ClinicManagement;
GO

USE ClinicManagement;
GO

CREATE TABLE Countries (
    CountryID TINYINT PRIMARY KEY IDENTITY(1,1),
    CountryName NVARCHAR(56) NOT NULL
);

INSERT INTO Countries (CountryName) VALUES
('Afghanistan'),
('Albania'),
('Algeria'),
('Andorra'),
('Angola'),
('Antigua and Barbuda'),
('Argentina'),
('Armenia'),
('Australia'),
('Austria'),
('Azerbaijan'),
('Bahamas'),
('Bahrain'),
('Bangladesh'),
('Barbados'),
('Belarus'),
('Belgium'),
('Belize'),
('Benin'),
('Bhutan'),
('Bolivia'),
('Bosnia and Herzegovina'),
('Botswana'),
('Brazil'),
('Brunei'),
('Bulgaria'),
('Burkina Faso'),
('Burundi'),
('Cabo Verde'),
('Cambodia'),
('Cameroon'),
('Canada'),
('Central African Republic'),
('Chad'),
('Chile'),
('China'),
('Colombia'),
('Comoros'),
('Congo'),
('Costa Rica'),
('Croatia'),
('Cuba'),
('Cyprus'),
('Czech Republic'),
('Democratic Republic of the Congo'),
('Denmark'),
('Djibouti'),
('Dominica'),
('Dominican Republic'),
('Ecuador'),
('Egypt'),
('El Salvador'),
('Equatorial Guinea'),
('Eritrea'),
('Estonia'),
('Eswatini'),
('Ethiopia'),
('Fiji'),
('Finland'),
('France'),
('Gabon'),
('Gambia'),
('Georgia'),
('Germany'),
('Ghana'),
('Greece'),
('Grenada'),
('Guatemala'),
('Guinea'),
('Guinea-Bissau'),
('Guyana'),
('Haiti'),
('Honduras'),
('Hungary'),
('Iceland'),
('India'),
('Indonesia'),
('Iran'),
('Iraq'),
('Ireland'),
('Italy'),
('Jamaica'),
('Japan'),
('Jordan'),
('Kazakhstan'),
('Kenya'),
('Kiribati'),
('Korea, North'),
('Korea, South'),
('Kuwait'),
('Kyrgyzstan'),
('Laos'),
('Latvia'),
('Lebanon'),
('Lesotho'),
('Liberia'),
('Libya'),
('Liechtenstein'),
('Lithuania'),
('Luxembourg'),
('Madagascar'),
('Malawi'),
('Malaysia'),
('Maldives'),
('Mali'),
('Malta'),
('Marshall Islands'),
('Mauritania'),
('Mauritius'),
('Mexico'),
('Micronesia'),
('Moldova'),
('Monaco'),
('Mongolia'),
('Montenegro'),
('Morocco'),
('Mozambique'),
('Myanmar'),
('Namibia'),
('Nauru'),
('Nepal'),
('Netherlands'),
('New Zealand'),
('Nicaragua'),
('Niger'),
('Nigeria'),
('North Macedonia'),
('Norway'),
('Oman'),
('Pakistan'),
('Palau'),
('Palestine'),
('Panama'),
('Papua New Guinea'),
('Paraguay'),
('Peru'),
('Philippines'),
('Poland'),
('Portugal'),
('Qatar'),
('Romania'),
('Russia'),
('Rwanda'),
('Saint Kitts and Nevis'),
('Saint Lucia'),
('Saint Vincent and the Grenadines'),
('Samoa'),
('San Marino'),
('Sao Tome and Principe'),
('Saudi Arabia'),
('Senegal'),
('Serbia'),
('Seychelles'),
('Sierra Leone'),
('Singapore'),
('Slovakia'),
('Slovenia'),
('Solomon Islands'),
('Somalia'),
('South Africa'),
('South Africa'),
('Spain'),
('Sri Lanka'),
('Sudan'),
('Suriname'),
('Sweden'),
('Switzerland'),
('Syria'),
('Taiwan'),
('Tajikistan'),
('Tanzania'),
('Thailand'),
('Togo'),
('Tonga'),
('Trinidad and Tobago'),
('Tunisia'),
('Turkey'),
('Turkmenistan'),
('Tuvalu'),
('Uganda'),
('Ukraine'),
('United Arab Emirates'),
('United Kingdom'),
('United States'),
('Uruguay'),
('Uzbekistan'),
('Vanuatu'),
('Vatican City'),
('Venezuela'),
('Vietnam'),
('Yemen'),
('Zambia'),
('Zimbabwe');


CREATE TABLE Departments(
    DepartmentID TINYINT PRIMARY KEY IDENTITY(1,1),
	DepartmentName NVARCHAR(200) NOT NULL UNIQUE,
	DepartmentDescription NVARCHAR(100) NULL,
	DepartmentLocation NVARCHAR(100) NULL
);

CREATE TABLE People (
    PersonID INT PRIMARY KEY IDENTITY(1,1),
	FirstName NVARCHAR(30) CHECK(LEN(FirstName) >= 3 AND FirstName NOT LIKE '%[0-9]%') NOT NULL,
	SecondName NVARCHAR(30) CHECK(LEN(SecondName) >= 3 AND SecondName NOT LIKE '%[0-9]%') NOT NULL,
	ThirdName NVARCHAR(30) CHECK(ThirdName NOT LIKE '%[0-9]%') NULL,
	LastName NVARCHAR(30) CHECK(LEN(LastName) >= 3 AND LastName NOT LIKE '%[0-9]%') NOT NULL,
	NationalID NVARCHAR(30) CHECK(LEN(NationalID) = 10) UNIQUE NOT NULL, -- Should start with 110
	BirthDate DATE CHECK(BirthDate > '1900-01-01') NOT NULL, -- from 12 years to 90 years
	Gender BIT NOT NULL, -- mix 
	Address NVARCHAR(100) NULL, -- random real-like addresses in riyadh saudi arabia
	Phone VARCHAR(10) CHECK(LEN(Phone) = 10 AND Phone NOT LIKE '%[^0-9]%') NOT NULL, -- should start with 05...
	Email VARCHAR(80) CHECK (Email LIKE '%_@__%.__%') NOT NULL,
	CountryID TINYINT FOREIGN KEY REFERENCES Countries(CountryID) NOT NULL, -- always should be 150
	CreatedByUserID SMALLINT NOT NULL, -- always 1
	CreatedAt DATETIME NOT NULL, -- always GETDATE()
	UpdatedByUserID SMALLINT NULL,
	UpdatedAt DATETIME NULL
);
GO
INSERT INTO People (
    FirstName, 
    SecondName, 
    ThirdName, 
    LastName, 
    NationalID, 
    BirthDate, 
    Gender, 
    Address, 
    Phone, 
    Email, 
    CountryID, 
    CreatedByUserID,
	CreatedAt
) VALUES (
    'System',
    'Administrator',
    NULL,
    'User',
    '0000000000',
    GETDATE(),
    0,
    NULL,
    '0000000000',
    'admin@admin.sa',
    150,
    1,
	GETDATE()
);
GO
CREATE TABLE Users (
    UserID SMALLINT PRIMARY KEY IDENTITY(1,1),
	PersonID INT NOT NULL,
	Username VARCHAR(20) CHECK (Username NOT LIKE '%[^a-zA-Z0-9]%') NOT NULL UNIQUE,
	Password VARCHAR(64) NOT NULL,
	Role TINYINT CHECK(Role IN (1,2,3)) NOT NULL, -- (1 = Admin, 2 = Doctor, 3 = Receptionist )
	IsActive BIT NOT NULL,
	LastLoginAt DATETIME NULL, 
	CreatedByUserID SMALLINT NOT NULL,
	CreatedAt DATETIME NOT NULL,
	UpdatedByUserID SMALLINT NULL,
	UpdatedAt DATETIME NULL
);
GO
INSERT INTO Users (
    PersonID,
	Username,
    Password, 
    Role, 
    IsActive, 
    CreatedByUserID,
	CreatedAt
) VALUES (
	1,
    'admin',
    '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4',
    1,
    1,
    1,
	GETDATE()
);
GO

ALTER TABLE People
ADD CONSTRAINT FK_People_CreatedByUserID 
FOREIGN KEY (CreatedByUserID) REFERENCES Users(UserID);

ALTER TABLE People
ADD CONSTRAINT FK_People_UpdatedByUserID
FOREIGN KEY (UpdatedByUserID) REFERENCES Users(UserID);

ALTER TABLE Users
ADD CONSTRAINT FK_Users_CreatedByUserID 
FOREIGN KEY (CreatedByUserID) REFERENCES Users(UserID);

ALTER TABLE Users
ADD CONSTRAINT FK_Users_UpdatedByUserID
FOREIGN KEY (UpdatedByUserID) REFERENCES Users(UserID);

ALTER TABLE Users
ADD CONSTRAINT FK_Users_PersonID
FOREIGN KEY (PersonID) REFERENCES People(PersonID);

CREATE TABLE LoginHistory (
    LoginHistoryID INT PRIMARY KEY IDENTITY(1,1),
	UserID SMALLINT FOREIGN KEY REFERENCES Users(UserID) NOT NULL,
	LoginTime DATETIME NOT NULL, 
	LogoutTime DATETIME NULL
);

CREATE TABLE Patients (
    PatientID INT PRIMARY KEY IDENTITY(1,1),
	PersonID INT FOREIGN KEY REFERENCES People(PersonID) UNIQUE NOT NULL,
	BloodType VARCHAR(4) CHECK(BloodType IN ('A+', 'A-', 'B+', 'B-', 'AB+', 'AB-', 'O+', 'O-')) NULL,
	Allergies VARCHAR(240) NULL,
	MedicalHistory VARCHAR(240) NULL,
	EmergencyContactName NVARCHAR(90) CHECK(EmergencyContactName NOT LIKE '%[0-9]%') NULL,
	EmergencyContactPhone NVARCHAR(10) CHECK(LEN(EmergencyContactPhone) = 10 AND EmergencyContactPhone NOT LIKE '%[^0-9]%') NULL,
	CreatedByUserID SMALLINT FOREIGN KEY REFERENCES Users(UserID) NOT NULL,
	CreatedAt DATETIME NOT NULL,
	UpdatedByUserID SMALLINT FOREIGN KEY REFERENCES Users(UserID) NULL,
	UpdatedAt DATETIME NULL
);

CREATE TABLE Doctors ( 
	DoctorID SMALLINT PRIMARY KEY IDENTITY(1,1),
	PersonID INT FOREIGN KEY REFERENCES People(PersonID) UNIQUE NOT NULL,
	DepartmentID TINYINT FOREIGN KEY REFERENCES Departments(DepartmentID) NOT NULL,
	LicenseNumber VARCHAR(10) CHECK (LEN(LicenseNumber) = 10 AND LicenseNumber NOT LIKE '%[^0-9]%') UNIQUE NOT NULL,
	Specialization NVARCHAR(80) NOT NULL,
	YearsOfExperience TINYINT NOT NULL,
	HireDate DATE NOT NULL,
	EndDate DATE NULL,
	DoctorStatus TINYINT CHECK(DoctorStatus BETWEEN 1 AND 5) NOT NULL, --(1 = Active, 2 = On Leave, 3 = Resigned, 4 = Retired, 5 = Terminated)
	ConsultationFee DECIMAL(8,2),
	DoctorUserID SMALLINT FOREIGN KEY REFERENCES Users(UserID) UNIQUE NOT NULL,
	CreatedByUserID SMALLINT FOREIGN KEY REFERENCES Users(UserID) NOT NULL,
	CreatedAt DATETIME NOT NULL,
	UpdatedByUserID SMALLINT FOREIGN KEY REFERENCES Users(UserID) NULL,
	UpdatedAt DATETIME NULL
);



CREATE TABLE Receptionists(
	ReceptionistID SMALLINT PRIMARY KEY IDENTITY(1,1),
	PersonID INT FOREIGN KEY REFERENCES People(PersonID) UNIQUE NOT NULL,
	HireDate DATE NOT NULL,
	EndDate DATE NULL,
	ReceptionistStatus TINYINT CHECK(ReceptionistStatus IN (1,2,3,4)) NOT NULL, --(1 = Active, 2 = On Leave, 3 = Resigned, 4 = Terminated)
	ReceptionistUserID SMALLINT FOREIGN KEY REFERENCES Users(UserID) UNIQUE NOT NULL,
	CreatedByUserID SMALLINT FOREIGN KEY REFERENCES Users(UserID) NOT NULL,
	CreatedAt DATETIME NOT NULL,
	UpdatedByUserID SMALLINT FOREIGN KEY REFERENCES Users(UserID) NULL,
	UpdatedAt DATETIME NULL
);


CREATE TABLE Payments (
	PaymentID INT PRIMARY KEY IDENTITY(1,1),
	Amount DECIMAL(8,2) NOT NULL,
	PaymentMethod TINYINT NOT NULL, -- (1 = Cash, 2 = Debit Card, 3 = Bank Transfer, 4 = Mobile Payment)
	PaymentDate DATETIME NOT NULL,
	CreatedByUserID SMALLINT FOREIGN KEY REFERENCES Users(UserID) NOT NULL,
	CreatedAt DATETIME DEFAULT GETDATE() NOT NULL
);

CREATE TABLE Appointments (
	AppointmentID INT PRIMARY KEY IDENTITY(1,1),
	PatientID INT FOREIGN KEY REFERENCES Patients(PatientID) NOT NULL,
	DoctorID SMALLINT FOREIGN KEY REFERENCES Doctors(DoctorID) NOT NULL,
	AppointmentDate DATETIME NOT NULL,
	AppointmentStatus TINYINT CHECK(AppointmentStatus IN (1,2,3,4)) NOT NULL, --(1 = Scheduled, 2 = Completed, 3 = Cancelled, 4 = No-Show)
	IsPaid BIT NOT NULL,
	PaymentID INT FOREIGN KEY REFERENCES Payments(PaymentID) NULL,
	CreatedByUserID SMALLINT FOREIGN KEY REFERENCES Users(UserID) NOT NULL,
	CreatedAt DATETIME  NOT NULL,
	UpdatedByUserID SMALLINT FOREIGN KEY REFERENCES Users(UserID) NULL,
	UpdatedAt DATETIME NULL
);

CREATE TABLE MedicalRecords(
	MedicalRecordID INT PRIMARY KEY IDENTITY(1,1),
	AppointmentID INT NOT NULL  FOREIGN KEY REFERENCES Appointments(AppointmentID),
	Diagnosis NVARCHAR(600) NOT NULL,
	Prescription NVARCHAR(600) NULL,
	Notes NVARCHAR(600) NULL,
	CreatedByUserID SMALLINT FOREIGN KEY REFERENCES Users(UserID) NOT NULL,
	CreatedAt DATETIME NOT NULL
);


CREATE INDEX IX_Payments_PaymentDate
ON Payments(PaymentDate);

CREATE INDEX IX_Appointments_PaymentID
ON Appointments(PaymentID);

CREATE INDEX IX_People_CreatedAt
ON People(CreatedAt);

CREATE INDEX IX_People_FirstName
ON People(FirstName);

CREATE INDEX IX_Patients_CreatedAt
ON Patients(CreatedAt);

CREATE INDEX IX_Appointments_CreatedAt
ON Appointments(CreatedAt);

CREATE INDEX IX_Patients_PersonID
ON Patients(PersonID);

CREATE INDEX IX_Doctors_DoctorStatus_Equal_One_Filtered
ON Doctors(DoctorStatus)
WHERE DoctorStatus = 1;