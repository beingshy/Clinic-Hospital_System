CREATE PROCEDURE GetUserByID
    @UserID INT
AS
BEGIN
    SELECT 
        PersonID,
        Username,
        Password,
        Role,
        IsActive,
        LastLoginAt,
        CreatedByUserID,
        CreatedAt,
        UpdatedByUserID,
        UpdatedAt
    FROM 
        Users
    WHERE 
        UserID = @UserID;
END;
GO
CREATE PROCEDURE GetUserByPersonID
    @PersonID INT
AS
BEGIN
    SELECT 
        UserID,
        Username,
        Password,
        Role,
        IsActive,
        LastLoginAt,
        CreatedByUserID,
        CreatedAt,
        UpdatedByUserID,
        UpdatedAt
    FROM 
        Users
    WHERE 
        PersonID = @PersonID;
END;
GO
CREATE PROCEDURE GetUserByUsername
    @Username NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        UserID,
		PersonID,
		Password,
		Role,
		IsActive, 
		LastLoginAt, 
        CreatedByUserID, 
		CreatedAt, 
		UpdatedByUserID, 
		UpdatedAt
    FROM Users
    WHERE Username = @Username;
END;
GO
-----------------------------
CREATE PROCEDURE GetUserByUsernameAndPassword
    @Username NVARCHAR(20),
    @Password NVARCHAR(64)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        UserID, 
        PersonID, 
        Role, 
        IsActive, 
        LastLoginAt, 
        CreatedByUserID, 
        CreatedAt, 
        UpdatedByUserID, 
        UpdatedAt
    FROM Users
    WHERE Username = @Username 
    AND Password = @Password;
END;
GO
-----------------------------
CREATE PROCEDURE AddNewUser
    @PersonID INT,
    @Username NVARCHAR(20),
    @Password NVARCHAR(64),
    @Role TINYINT,
    @IsActive BIT,
    @LastLoginAt DATETIME NULL,
    @CreatedByUserID SMALLINT,
    @CreatedAt DATETIME,
    @UpdatedByUserID SMALLINT NULL,
    @UpdatedAt DATETIME NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Users (
        PersonID, 
        Username, 
        Password, 
        Role, 
        IsActive, 
        LastLoginAt, 
        CreatedByUserID, 
        CreatedAt, 
        UpdatedByUserID, 
        UpdatedAt
    )
    VALUES (
        @PersonID, 
        @Username, 
        @Password, 
        @Role, 
        @IsActive, 
        @LastLoginAt, 
        @CreatedByUserID, 
        @CreatedAt, 
        @UpdatedByUserID, 
        @UpdatedAt
    );

    SELECT SCOPE_IDENTITY();
END;
GO
-----------------------------
CREATE PROCEDURE GetUsernameByID
    @UserID SMALLINT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Username 
    FROM Users 
    WHERE UserID = @UserID;
END;
GO
-----------------------------
CREATE PROCEDURE UpdateUser
    @UserID SMALLINT,
    @PersonID INT,
    @Username NVARCHAR(20),
    @Password NVARCHAR(64),
    @Role TINYINT,
    @IsActive BIT,
    @LastLoginAt DATETIME NULL,
    @CreatedByUserID SMALLINT,
    @CreatedAt DATETIME,
    @UpdatedByUserID SMALLINT NULL,
    @UpdatedAt DATETIME NULL
AS
BEGIN

    UPDATE Users
    SET 
        PersonID = @PersonID, 
        Username = @Username, 
        Password = @Password, 
        Role = @Role, 
        IsActive = @IsActive, 
        LastLoginAt = @LastLoginAt, 
        CreatedByUserID = @CreatedByUserID, 
        CreatedAt = @CreatedAt, 
        UpdatedByUserID = @UpdatedByUserID, 
        UpdatedAt = @UpdatedAt
    WHERE UserID = @UserID;
END;
GO


-----------------------------
CREATE PROCEDURE ActivateUser
    @UserID SMALLINT
AS
BEGIN

    UPDATE Users 
    SET IsActive = 1
    WHERE UserID = @UserID;

    RETURN @@ROWCOUNT;
END;
GO

-----------------------------
CREATE PROCEDURE ChangeRole
    @UserID SMALLINT,
    @Role TINYINT
AS
BEGIN
    UPDATE Users 
    SET Role = @Role
    WHERE UserID = @UserID;

    RETURN @@ROWCOUNT;
END;
GO
-----------------------------
CREATE PROCEDURE DeactivateUser
    @UserID SMALLINT
AS
BEGIN

    UPDATE Users 
    SET IsActive = 0
    WHERE UserID = @UserID;

    RETURN @@ROWCOUNT;
END;
GO

-----------------------------

CREATE PROCEDURE DoesUserExistByUserID
    @UserID SMALLINT
AS
BEGIN
    SET NOCOUNT ON;

SELECT Found = 1 FROM Users WHERE UserID = @UserID

END;
GO

-----------------------------

CREATE PROCEDURE DoesUserExistByUsername
    @Username VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

SELECT Found = 1 FROM Users WHERE Username = @Username

END;
GO
-----------------------------
CREATE PROCEDURE GetAllUsers
AS
BEGIN
    SET NOCOUNT ON;

    SELECT UserID, 
           PersonID, 
           Username, 
           CASE IsActive
               WHEN 1 THEN 'Yes'
               WHEN 0 THEN 'No'
           END AS IsActive, 
           CASE Role 
               WHEN 1 THEN 'Admin'
               WHEN 2 THEN 'Doctor'
               WHEN 3 THEN 'Receptionist'
           END AS Role,
           ISNULL(CAST(LastLoginAt AS VARCHAR(20)), 'Never Logged In') AS LastLoginAt
    FROM Users;
END;
GO

-----------------------------
-- Get Receptionist by ID
CREATE PROCEDURE GetReceptionistByID
    @ReceptionistID SMALLINT
AS
BEGIN
    SELECT * FROM Receptionists WHERE ReceptionistID = @ReceptionistID;
END;
GO
GO

-- Add New Receptionist
CREATE PROCEDURE AddNewReceptionist
    @PersonID INT,
    @HireDate DATETIME,
    @EndDate DATETIME NULL,
    @ReceptionistStatus TINYINT,
    @ReceptionistUserID SMALLINT,
    @CreatedByUserID SMALLINT,
    @CreatedAt DATETIME,
    @UpdatedByUserID SMALLINT NULL,
    @UpdatedAt DATETIME NULL
AS
BEGIN
    INSERT INTO Receptionists (PersonID, HireDate, EndDate, ReceptionistStatus, ReceptionistUserID, CreatedByUserID, CreatedAt, UpdatedByUserID, UpdatedAt)
    VALUES (@PersonID, @HireDate, @EndDate, @ReceptionistStatus, @ReceptionistUserID, @CreatedByUserID, @CreatedAt, @UpdatedByUserID, @UpdatedAt);
    
    SELECT SCOPE_IDENTITY();
END;
GO
GO

-- Update Receptionist
CREATE PROCEDURE UpdateReceptionist
    @ReceptionistID SMALLINT,
    @PersonID INT,
    @HireDate DATETIME,
    @EndDate DATETIME NULL,
    @ReceptionistStatus TINYINT,
    @ReceptionistUserID SMALLINT,
    @CreatedByUserID SMALLINT,
    @CreatedAt DATETIME,
    @UpdatedByUserID SMALLINT NULL,
    @UpdatedAt DATETIME NULL
AS
BEGIN
    UPDATE Receptionists  
    SET 
        PersonID = @PersonID, 
        HireDate = @HireDate, 
        EndDate = @EndDate, 
        ReceptionistStatus = @ReceptionistStatus, 
        ReceptionistUserID = @ReceptionistUserID, 
        CreatedByUserID = @CreatedByUserID, 
        CreatedAt = @CreatedAt, 
        UpdatedByUserID = @UpdatedByUserID, 
        UpdatedAt = @UpdatedAt
    WHERE ReceptionistID = @ReceptionistID;
END;
GO
GO

-- Delete Receptionist
CREATE PROCEDURE DeleteReceptionist
    @ReceptionistID SMALLINT
AS
BEGIN
    DELETE FROM Receptionists WHERE ReceptionistID = @ReceptionistID;
END;
GO
GO

-- Check if Receptionist Exists
CREATE PROCEDURE DoesReceptionistExist
    @ReceptionistID SMALLINT
AS
BEGIN
    SELECT 1 AS Found FROM Receptionists WHERE ReceptionistID = @ReceptionistID;
END;
GO
GO

-- Get Person ID by Receptionist ID
CREATE PROCEDURE GetReceptionistPersonID
    @ReceptionistID SMALLINT
AS
BEGIN
    SELECT PersonID FROM Receptionists WHERE ReceptionistID = @ReceptionistID;
END;
GO
GO

-- Check if Receptionist Exists by Person ID
CREATE PROCEDURE DoesReceptionistExistByPersonID
    @PersonID INT
AS
BEGIN
    SELECT 1 AS Found FROM Receptionists WHERE PersonID = @PersonID;
END;
GO
GO

-- Check if Username is Used by Another Receptionist
CREATE PROCEDURE DoesUsernameUsedByAnotherReceptionist
    @ReceptionistID SMALLINT NULL,
    @Username NVARCHAR(100)
AS
BEGIN
    IF @ReceptionistID IS NULL
    BEGIN
        SELECT 1 AS Found 
        FROM Receptionists 
        INNER JOIN Users ON Users.UserID = Receptionists.ReceptionistUserID
        WHERE Username = @Username;
    END
    ELSE 
    BEGIN
        SELECT 1 AS Found 
        FROM Receptionists 
        INNER JOIN Users ON Users.UserID = Receptionists.ReceptionistUserID
        WHERE ReceptionistID <> @ReceptionistID AND Username = @Username;
    END
END;
GO

-- Get All Receptionists
CREATE PROCEDURE GetAllReceptionists
AS
BEGIN
    SELECT 
        ReceptionistID, 
        People.Firstname + ' ' + People.Lastname AS Fullname,
        HireDate, 
        CASE 
            WHEN EndDate IS NULL THEN 'Ongoing'
            ELSE CAST(EndDate AS VARCHAR)
        END AS EndDate, 
        CASE 
            WHEN ReceptionistStatus = 1 THEN 'Active'
            WHEN ReceptionistStatus = 2 THEN 'On Leave'
            WHEN ReceptionistStatus = 3 THEN 'Resigned'
            WHEN ReceptionistStatus = 4 THEN 'Terminated'
            ELSE 'Not Known'
        END AS Status, 
        Users.Username AS ReceptionistUser
    FROM Receptionists
    INNER JOIN People ON People.PersonID = Receptionists.PersonID
    INNER JOIN Users ON Users.UserID = Receptionists.ReceptionistUserID;
END;
GO
GO

-----------------------------
-- Stored Procedure to Get Person by ID
CREATE PROCEDURE GetPersonByID
    @PersonID INT
AS
BEGIN
    SELECT * FROM People WHERE PersonID = @PersonID;
END
GO

-- Stored Procedure to Add New Person
CREATE PROCEDURE AddNewPerson
    @FirstName NVARCHAR(30),
    @SecondName NVARCHAR(30),
    @ThirdName NVARCHAR(30),
    @LastName NVARCHAR(30),
    @NationalID NVARCHAR(30),
    @BirthDate DATE,
    @Gender BIT,
    @Address NVARCHAR(100),
    @Phone NVARCHAR(10),
    @Email NVARCHAR(30),
    @CountryID TINYINT,
    @CreatedByUserID SMALLINT,
    @CreatedAt DATETIME,
    @UpdatedByUserID SMALLINT NULL,
    @UpdatedAt DATETIME NULL
AS
BEGIN
    INSERT INTO People (FirstName, SecondName, ThirdName, LastName, NationalID, BirthDate, Gender, Address, Phone, Email, CountryID, CreatedByUserID, CreatedAt, UpdatedByUserID, UpdatedAt)
    VALUES (@FirstName, @SecondName, @ThirdName, @LastName, @NationalID, @BirthDate, @Gender, @Address, @Phone, @Email, @CountryID, @CreatedByUserID, @CreatedAt, @UpdatedByUserID, @UpdatedAt);
    
    SELECT SCOPE_IDENTITY();
END
GO

-- Stored Procedure to Update Person
CREATE PROCEDURE UpdatePerson
    @PersonID INT,
    @FirstName NVARCHAR(30),
    @SecondName NVARCHAR(30),
    @ThirdName NVARCHAR(30),
    @LastName NVARCHAR(30),
    @NationalID NVARCHAR(30),
    @BirthDate DATE,
    @Gender BIT,
    @Address NVARCHAR(100),
    @Phone NVARCHAR(10),
    @Email NVARCHAR(30),
    @CountryID TINYINT,
    @CreatedByUserID SMALLINT,
    @CreatedAt DATETIME,
    @UpdatedByUserID SMALLINT NULL,
    @UpdatedAt DATETIME NULL
AS
BEGIN
    UPDATE People  
    SET FirstName = @FirstName, 
        SecondName = @SecondName, 
        ThirdName = @ThirdName, 
        LastName = @LastName, 
        NationalID = @NationalID, 
        BirthDate = @BirthDate, 
        Gender = @Gender, 
        Address = @Address, 
        Phone = @Phone, 
        Email = @Email, 
        CountryID = @CountryID, 
        CreatedByUserID = @CreatedByUserID, 
        CreatedAt = @CreatedAt, 
        UpdatedByUserID = @UpdatedByUserID, 
        UpdatedAt = @UpdatedAt
    WHERE PersonID = @PersonID;
END
GO

-- Stored Procedure to Delete Person
CREATE PROCEDURE DeletePerson
    @PersonID INT
AS
BEGIN
    DELETE FROM People WHERE PersonID = @PersonID;
END
GO

-- Stored Procedure to Check if Person Exists
CREATE PROCEDURE DoesPersonExist
    @PersonID INT
AS
BEGIN
    SELECT 1 AS Found FROM People WHERE PersonID = @PersonID;
END
GO

-- Stored Procedure to Check if Person Has a User
CREATE PROCEDURE DoesPersonHasUser
    @PersonID INT
AS
BEGIN
    SELECT 1 AS Found FROM Users WHERE PersonID = @PersonID;
END
GO

-- Stored Procedure to Get All People
CREATE PROCEDURE GetAllPeople
@PageNumber INT,
@Records INT OUTPUT,
@PageSize INT
AS
BEGIN
    SELECT People.PersonID, 
           People.FirstName + ' ' + People.SecondName + ' ' + 
           CASE WHEN People.ThirdName IS NULL THEN '' ELSE People.ThirdName + ' ' END + People.LastName AS FullName, 
           People.NationalID, 
           People.BirthDate, 
           CASE WHEN People.Gender = 0 THEN 'Male' ELSE 'Female' END AS Gender,
           People.Phone, 
           People.Email, 
           Countries.CountryName, 
           Users.Username AS CreatedBy
    FROM People 
    INNER JOIN Countries ON People.CountryID = Countries.CountryID
    INNER JOIN Users ON People.CreatedByUserID = Users.UserID
    ORDER BY People.CreatedAt DESC

	OFFSET (@PageNumber - 1) * @PageSize ROWS
	FETCH NEXT @PageSize ROWS ONLY
	SELECT @Records = COUNT(*) FROM People 
END
GO

-----------------------------
-- Stored Procedure to Get Patient by ID
CREATE PROCEDURE GetPatientByID
    @PatientID INT
AS
BEGIN
    SELECT * FROM Patients WHERE PatientID = @PatientID;
END
GO

-- Stored Procedure to Add New Patient
CREATE PROCEDURE AddNewPatient
    @PersonID INT,
    @BloodType NVARCHAR(4),
    @Allergies NVARCHAR(240),
    @MedicalHistory NVARCHAR(240),
    @EmergencyContactName NVARCHAR(90),
    @EmergencyContactPhone NVARCHAR(10),
    @CreatedByUserID SMALLINT,
    @CreatedAt DATETIME,
    @UpdatedByUserID SMALLINT NULL,
    @UpdatedAt DATETIME NULL
AS
BEGIN
    INSERT INTO Patients (PersonID, BloodType, Allergies, MedicalHistory, EmergencyContactName, EmergencyContactPhone, CreatedByUserID, CreatedAt, UpdatedByUserID, UpdatedAt)
    VALUES (@PersonID, @BloodType, @Allergies, @MedicalHistory, @EmergencyContactName, @EmergencyContactPhone, @CreatedByUserID, @CreatedAt, @UpdatedByUserID, @UpdatedAt);
    
    SELECT SCOPE_IDENTITY();
END
GO

-- Stored Procedure to Update Patient
CREATE PROCEDURE UpdatePatient
    @PatientID INT,
    @PersonID INT,
    @BloodType NVARCHAR(4),
    @Allergies NVARCHAR(240),
    @MedicalHistory NVARCHAR(240),
    @EmergencyContactName NVARCHAR(90),
    @EmergencyContactPhone NVARCHAR(10),
    @CreatedByUserID SMALLINT,
    @CreatedAt DATETIME,
    @UpdatedByUserID SMALLINT NULL,
    @UpdatedAt DATETIME NULL
AS
BEGIN
    UPDATE Patients
    SET PersonID = @PersonID,
        BloodType = @BloodType,
        Allergies = @Allergies,
        MedicalHistory = @MedicalHistory,
        EmergencyContactName = @EmergencyContactName,
        EmergencyContactPhone = @EmergencyContactPhone,
        CreatedByUserID = @CreatedByUserID,
        CreatedAt = @CreatedAt,
        UpdatedByUserID = @UpdatedByUserID,
        UpdatedAt = @UpdatedAt
    WHERE PatientID = @PatientID;
END
GO

-- Stored Procedure to Delete Patient
CREATE PROCEDURE DeletePatient
    @PatientID INT
AS
BEGIN
    DELETE FROM Patients WHERE PatientID = @PatientID;
END
GO

-- Stored Procedure to Check if Patient Exists
CREATE PROCEDURE DoesPatientExist
    @PatientID INT
AS
BEGIN
    SELECT Found = 1 FROM Patients WHERE PatientID = @PatientID;
END
GO

-- Stored Procedure to Check if Patient Exists by PersonID
CREATE PROCEDURE DoesPatientExistByPersonID
    @PersonID INT
AS
BEGIN
    SELECT Found = 1 FROM Patients WHERE PersonID = @PersonID;
END
GO

-- Stored Procedure to Get All Patients
CREATE PROCEDURE GetAllPatients
@PageNumber INT,
@Records INT OUTPUT,
@PageSize INT
AS
BEGIN
    SELECT PatientID, Patients.PersonID, 
        CONCAT(People.FirstName, ' ', People.SecondName, ' ', People.LastName) AS FullName,
        People.NationalID, 
        BloodType, 
        CASE WHEN Allergies IS NULL THEN 'No Known Allergies' ELSE Allergies END AS Allergies,
        CASE WHEN MedicalHistory IS NULL THEN 'No Known Medical History' ELSE MedicalHistory END AS MedicalHistory,
        CASE WHEN EmergencyContactName IS NULL THEN 'Not Available' ELSE EmergencyContactName END AS EmergencyContactName,
        CASE WHEN EmergencyContactPhone IS NULL THEN 'Not Available' ELSE EmergencyContactPhone END AS EmergencyContactPhone
    FROM Patients
    INNER JOIN People ON People.PersonID = Patients.PersonID
    ORDER BY Patients.CreatedAt DESC

	OFFSET (@PageNumber - 1) * @PageSize ROWS
	FETCH NEXT @PageSize ROWS ONLY
	SELECT @Records = COUNT(*) FROM Patients 

END
GO
-----------------------------
CREATE PROCEDURE GetDoctorByID
    @DoctorID SMALLINT
AS
BEGIN
    SELECT * FROM Doctors WHERE DoctorID = @DoctorID;
END;
GO

 CREATE PROCEDURE [dbo].[GetDoctorPersonID]
    @PersonID INT
AS
BEGIN
    SELECT * FROM Doctors WHERE PersonID = @PersonID;
END;
GO

GO

CREATE PROCEDURE AddNewDoctor
    @PersonID INT,
    @DepartmentID TINYINT,
    @LicenseNumber VARCHAR(10),
    @Specialization VARCHAR(80),
    @YearsOfExperience TINYINT,
    @HireDate DATETIME,
    @EndDate DATETIME NULL,
    @DoctorStatus TINYINT,
    @ConsultationFee DECIMAL(8,2) NULL,
    @DoctorUserID SMALLINT,
    @CreatedByUserID SMALLINT,
    @CreatedAt DATETIME,
    @UpdatedByUserID SMALLINT NULL,
    @UpdatedAt DATETIME NULL
AS
BEGIN
    INSERT INTO Doctors (PersonID, DepartmentID, LicenseNumber, Specialization, YearsOfExperience, HireDate, EndDate, DoctorStatus, ConsultationFee, DoctorUserID, CreatedByUserID, CreatedAt, UpdatedByUserID, UpdatedAt)
    VALUES (@PersonID, @DepartmentID, @LicenseNumber, @Specialization, @YearsOfExperience, @HireDate, @EndDate, @DoctorStatus, @ConsultationFee, @DoctorUserID, @CreatedByUserID, @CreatedAt, @UpdatedByUserID, @UpdatedAt);
    
    SELECT SCOPE_IDENTITY();
END;
GO

GO

CREATE PROCEDURE UpdateDoctor
    @DoctorID SMALLINT,
    @PersonID INT,
    @DepartmentID TINYINT,
    @LicenseNumber VARCHAR(10),
    @Specialization VARCHAR(80),
    @YearsOfExperience TINYINT,
    @HireDate DATETIME,
    @EndDate DATETIME NULL,
    @DoctorStatus TINYINT,
    @ConsultationFee DECIMAL(8,2) NULL,
    @DoctorUserID SMALLINT,
    @CreatedByUserID SMALLINT,
    @CreatedAt DATETIME,
    @UpdatedByUserID SMALLINT NULL,
    @UpdatedAt DATETIME NULL
AS
BEGIN
    UPDATE Doctors  
    SET PersonID = @PersonID, 
        DepartmentID = @DepartmentID, 
        LicenseNumber = @LicenseNumber, 
        Specialization = @Specialization, 
        YearsOfExperience = @YearsOfExperience, 
        HireDate = @HireDate, 
        EndDate = @EndDate, 
        DoctorStatus = @DoctorStatus, 
        ConsultationFee = @ConsultationFee, 
        DoctorUserID = @DoctorUserID, 
        CreatedByUserID = @CreatedByUserID, 
        CreatedAt = @CreatedAt, 
        UpdatedByUserID = @UpdatedByUserID, 
        UpdatedAt = @UpdatedAt
    WHERE DoctorID = @DoctorID;
END;
GO

GO

CREATE PROCEDURE DeleteDoctor
    @DoctorID SMALLINT
AS
BEGIN
    DELETE FROM Doctors WHERE DoctorID = @DoctorID;
END;
GO

GO

CREATE PROCEDURE DoesDoctorExistByDoctorID
    @DoctorID SMALLINT
AS
BEGIN
    SELECT Found = 1 FROM Doctors WHERE DoctorID = @DoctorID;
END;
GO

GO

CREATE PROCEDURE DoesDoctorExistByPersonID
    @PersonID INT
AS
BEGIN
    SELECT Found = 1 FROM Doctors WHERE PersonID = @PersonID;
END;
GO

GO

CREATE PROCEDURE IsDoctorAvailable
    @DoctorID SMALLINT,
    @AppointmentDate DATETIME
AS
BEGIN
    SELECT Found = 1 
    FROM Appointments
    WHERE DoctorID = @DoctorID 
    AND DATEADD(SECOND, -DATEPART(SECOND, AppointmentDate), AppointmentDate) = DATEADD(SECOND, -DATEPART(SECOND, @AppointmentDate), @AppointmentDate);
END;
GO

GO

CREATE PROCEDURE GetPersonID
    @DoctorID SMALLINT
AS
BEGIN
    SELECT PersonID FROM Doctors WHERE DoctorID = @DoctorID;
END;
GO

GO

CREATE PROCEDURE DoesUsernameUsedByAnotherDoctor
    @DoctorID SMALLINT,
    @Username VARCHAR(20)
AS
BEGIN
    DECLARE @TempDoctorID INT;
    SET @TempDoctorID = @DoctorID;
    
    IF (@TempDoctorID IS NULL)
    BEGIN
        SELECT Found = 1 FROM Doctors 
        INNER JOIN Users ON Users.UserID = Doctors.DoctorUserID
        WHERE Username = @Username;
    END
    ELSE 
    BEGIN
        SELECT Found = 1 
        FROM Doctors 
        INNER JOIN Users ON Users.UserID = Doctors.DoctorUserID
        WHERE DoctorID <> @TempDoctorID AND Username = @Username;
    END
END;
GO

CREATE PROCEDURE GetAllDoctors
AS
BEGIN
    SELECT DoctorID, CONCAT(People.FirstName, ' ', People.LastName) AS FullName,
           Departments.DepartmentName, LicenseNumber, Specialization,
           YearsOfExperience, HireDate, 
           CASE 
               WHEN EndDate IS NULL THEN 'Ongoing'
               ELSE CAST(EndDate AS VARCHAR)
           END AS EndDate,
           CASE
               WHEN DoctorStatus = 1 THEN 'Active'
               WHEN DoctorStatus = 2 THEN 'On Leave'
               WHEN DoctorStatus = 3 THEN 'Resigned'
               WHEN DoctorStatus = 4 THEN 'Retired'
               WHEN DoctorStatus = 5 THEN 'Terminated'
           END AS Status,
		    CAST(ConsultationFee AS VARCHAR(20)) + ' SAR' AS ConsultationFees
    FROM Doctors
    INNER JOIN People ON People.PersonID = Doctors.PersonID
    INNER JOIN Departments ON Departments.DepartmentID = Doctors.DepartmentID;
END;
GO

-----------------------------
CREATE PROCEDURE GetDepartmentByID
    @DepartmentID TINYINT
AS
BEGIN
    SELECT * FROM Departments WHERE DepartmentID = @DepartmentID;
END;
GO
GO
CREATE PROCEDURE GetDepartmentByDepartmentName
    @DepartmentName NVARCHAR(200)
AS
BEGIN
    SELECT * FROM Departments WHERE DepartmentName = @DepartmentName;
END;
GO
GO
CREATE PROCEDURE AddNewDepartment
    @DepartmentName NVARCHAR(200),
    @DepartmentDescription NVARCHAR(100),
    @DepartmentLocation NVARCHAR(100)
AS
BEGIN
    INSERT INTO Departments (DepartmentName, DepartmentDescription, DepartmentLocation)
    VALUES (@DepartmentName, @DepartmentDescription, @DepartmentLocation);
    SELECT SCOPE_IDENTITY();
END;
GO
GO
CREATE PROCEDURE UpdateDepartment
    @DepartmentID TINYINT,
    @DepartmentName NVARCHAR(200),
    @DepartmentDescription NVARCHAR(100),
    @DepartmentLocation NVARCHAR(100)
AS
BEGIN
    UPDATE Departments  
    SET 
        DepartmentName = @DepartmentName, 
        DepartmentDescription = @DepartmentDescription, 
        DepartmentLocation = @DepartmentLocation
    WHERE DepartmentID = @DepartmentID;
END;
GO
GO
CREATE PROCEDURE DeleteDepartment
    @DepartmentID TINYINT
AS
BEGIN
    DELETE FROM Departments WHERE DepartmentID = @DepartmentID;
END;
GO
GO
CREATE PROCEDURE DoesDepartmentExist
    @DepartmentID TINYINT
AS
BEGIN
    SELECT Found = 1 FROM Departments WHERE DepartmentID = @DepartmentID;
END;
GO
GO
CREATE PROCEDURE TotalDoctorsByDepartmentID
    @DepartmentID TINYINT
AS
BEGIN
    SELECT CAST(COUNT(*)  AS SMALLINT) AS TotalDoctors FROM Doctors WHERE DepartmentID = @DepartmentID;
END;
GO
GO
CREATE PROCEDURE TotalVisitsByDepartmentID
    @DepartmentID TINYINT
AS
BEGIN
    SELECT COUNT(*) AS TotalVisits FROM Appointments 
    INNER JOIN Doctors ON Appointments.DoctorID = Doctors.DoctorID
    WHERE AppointmentStatus = 2 AND Doctors.DepartmentID = @DepartmentID;
END;
GO
GO
CREATE PROCEDURE TotalRevenueByDepartmentID
    @DepartmentID TINYINT
AS
BEGIN
    SELECT ISNULL(SUM(Payments.Amount),0) AS TotalRevenue FROM Appointments
    INNER JOIN Payments ON Payments.PaymentID = Appointments.PaymentID
    INNER JOIN Doctors ON Appointments.DoctorID = Doctors.DoctorID
    WHERE Doctors.DepartmentID = @DepartmentID;
END;
GO
GO
CREATE PROCEDURE GetAllDepartments
AS
BEGIN
    SELECT * FROM Departments;
END;
GO
GO

-------------------------------

-- GetCountryByID
CREATE PROCEDURE GetCountryByID
    @CountryID TINYINT
AS
BEGIN
    SELECT * FROM Countries WHERE CountryID = @CountryID;
END;
GO
GO

-- GetCountryByName
CREATE PROCEDURE GetCountryByName
    @CountryName NVARCHAR(56)
AS
BEGIN
    SELECT * FROM Countries WHERE CountryName = @CountryName;
END;
GO
GO

-- AddNewCountry
CREATE PROCEDURE AddNewCountry
    @CountryName NVARCHAR(56)
AS
BEGIN
    INSERT INTO Countries (CountryName)
    VALUES (@CountryName);
    
    SELECT SCOPE_IDENTITY();
END;
GO
GO

-- UpdateCountry
CREATE PROCEDURE UpdateCountry
    @CountryID TINYINT,
    @CountryName NVARCHAR(56)
AS
BEGIN
    UPDATE Countries  
    SET CountryName = @CountryName
    WHERE CountryID = @CountryID;
END;
GO
GO

-- DeleteCountry
CREATE PROCEDURE DeleteCountry
    @CountryID TINYINT
AS
BEGIN
    DELETE FROM Countries WHERE CountryID = @CountryID;
END;
GO
GO

-- DoesCountryExist
CREATE PROCEDURE DoesCountryExist
    @CountryID TINYINT
AS
BEGIN
    SELECT Found = 1 FROM Countries WHERE CountryID = @CountryID;
END;
GO
GO

-- GetAllCountries
CREATE PROCEDURE GetAllCountries
AS
BEGIN
    SELECT * FROM Countries;
END;
GO
GO
-----------------------------
-- GetAppointmentByID
CREATE PROCEDURE GetAppointmentByID
    @AppointmentID INT
AS
BEGIN
    SELECT * FROM Appointments WHERE AppointmentID = @AppointmentID;
END;
GO
GO

-- AddNewAppointment
CREATE PROCEDURE AddNewAppointment
    @PatientID INT,
    @DoctorID SMALLINT,
    @AppointmentDate DATETIME,
    @AppointmentStatus TINYINT,
    @IsPaid BIT,
    @PaymentID INT NULL,
    @CreatedByUserID SMALLINT,
    @CreatedAt DATETIME,
    @UpdatedByUserID SMALLINT NULL,
    @UpdatedAt DATETIME NULL
AS
BEGIN
    INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate, AppointmentStatus, IsPaid, PaymentID, CreatedByUserID, CreatedAt, UpdatedByUserID, UpdatedAt)
    VALUES (@PatientID, @DoctorID, @AppointmentDate, @AppointmentStatus, @IsPaid, @PaymentID, @CreatedByUserID, @CreatedAt, @UpdatedByUserID, @UpdatedAt);
    
    SELECT SCOPE_IDENTITY();
END;
GO
GO

-- UpdateAppointment
CREATE PROCEDURE UpdateAppointment
    @AppointmentID INT,
    @PatientID INT,
    @DoctorID SMALLINT,
    @AppointmentDate DATETIME,
    @AppointmentStatus TINYINT,
    @IsPaid BIT,
    @PaymentID INT NULL,
    @CreatedByUserID SMALLINT,
    @CreatedAt DATETIME,
    @UpdatedByUserID SMALLINT NULL,
    @UpdatedAt DATETIME NULL
AS
BEGIN
    UPDATE Appointments  
    SET 
        PatientID = @PatientID, 
        DoctorID = @DoctorID, 
        AppointmentDate = @AppointmentDate, 
        AppointmentStatus = @AppointmentStatus, 
        IsPaid = @IsPaid, 
        PaymentID = @PaymentID, 
        CreatedByUserID = @CreatedByUserID, 
        CreatedAt = @CreatedAt, 
        UpdatedByUserID = @UpdatedByUserID, 
        UpdatedAt = @UpdatedAt
    WHERE AppointmentID = @AppointmentID;
END;
GO
GO

-- DeleteAppointment
CREATE PROCEDURE DeleteAppointment
    @AppointmentID INT
AS
BEGIN
    DELETE FROM Appointments WHERE AppointmentID = @AppointmentID;
END;
GO
GO

-- DoesAppointmentExist
CREATE PROCEDURE DoesAppointmentExist
    @AppointmentID INT
AS
BEGIN
    SELECT Found = 1 FROM Appointments WHERE AppointmentID = @AppointmentID;
END;
GO
GO

-- GetAllAppointments
CREATE PROCEDURE GetAllAppointments
@PageNumber INT,
@Records INT OUTPUT,
@PageSize INT
AS
BEGIN
    SELECT AppointmentID, Appointments.PatientID,
           CONCAT(People.FirstName, ' ', People.LastName) AS PatientName,
           DoctorID, CONVERT(VARCHAR(20), AppointmentDate) AS AppointmentDate, 
           CASE 
               WHEN AppointmentStatus = 1 THEN 'Scheduled'
               WHEN AppointmentStatus = 2 THEN 'Completed'
               WHEN AppointmentStatus = 3 THEN 'Cancelled'
               WHEN AppointmentStatus = 4 THEN 'No-Show'
           END AS Status,
           CASE 
               WHEN IsPaid = 1 THEN 'Yes'
               WHEN IsPaid = 0 THEN 'No'
           END AS IsPaid,
           CASE 
               WHEN PaymentID IS NULL THEN 'N/A'
               ELSE CAST(PaymentID AS VARCHAR)
           END AS PaymentID
    FROM Appointments
    INNER JOIN Patients ON Patients.PatientID = Appointments.PatientID
    INNER JOIN People ON People.PersonID = Patients.PersonID
	ORDER BY Appointments.CreatedAt DESC
	OFFSET (@PageNumber - 1) * @PageSize ROWS
	FETCH NEXT @PageSize ROWS ONLY
	SELECT @Records = COUNT(*) FROM Appointments 
END;
GO

-- HasMedicalRecord
CREATE PROCEDURE HasMedicalRecord
    @AppointmentID INT
AS
BEGIN
    SELECT Found = 1 FROM MedicalRecords WHERE AppointmentID = @AppointmentID;
END;
GO
GO

-- GetMedicalRecordID
CREATE PROCEDURE GetMedicalRecordID
    @AppointmentID INT
AS
BEGIN
    SELECT MedicalRecordID FROM MedicalRecords WHERE AppointmentID = @AppointmentID;
END;
GO
GO
----------------------------------


-- GetLoginHistoryByID
CREATE PROCEDURE GetLoginHistoryByID
    @LoginHistoryID INT
AS
BEGIN
    SELECT * FROM LoginHistory WHERE LoginHistoryID = @LoginHistoryID;
END;
GO
GO
-- AddNewLoginHistory
CREATE PROCEDURE AddNewLoginHistory
    @UserID SMALLINT,
    @LoginTime DATETIME,
    @LogoutTime DATETIME NULL
AS
BEGIN
    INSERT INTO LoginHistory (UserID, LoginTime, LogoutTime)
    VALUES (@UserID, @LoginTime, @LogoutTime);
    
    SELECT SCOPE_IDENTITY();
END;
GO
GO
-- UpdateLoginHistory
CREATE PROCEDURE UpdateLoginHistory
    @LoginHistoryID INT,
    @UserID SMALLINT,
    @LoginTime DATETIME,
    @LogoutTime DATETIME NULL
AS
BEGIN
    UPDATE LoginHistory  
    SET 
        UserID = @UserID, 
        LoginTime = @LoginTime, 
        LogoutTime = @LogoutTime
    WHERE LoginHistoryID = @LoginHistoryID;
END;
GO
GO
-- DeleteLoginHistory
CREATE PROCEDURE DeleteLoginHistory
    @LoginHistoryID INT
AS
BEGIN
    DELETE FROM LoginHistory WHERE LoginHistoryID = @LoginHistoryID;
END;
GO
GO
-- DoesLoginHistoryExist
CREATE PROCEDURE DoesLoginHistoryExist
    @LoginHistoryID INT
AS
BEGIN
    SELECT Found = 1 FROM LoginHistory WHERE LoginHistoryID = @LoginHistoryID;
END;
GO
GO
-- GetUserLoginHistory
CREATE PROCEDURE GetUserLoginHistory
    @UserID SMALLINT
AS
BEGIN
    SELECT * FROM LoginHistory WHERE UserID = @UserID ORDER BY LoginTime DESC;
END;
GO
GO
-- GetAllLoginHistory
CREATE PROCEDURE GetAllLoginHistory
AS
BEGIN
    SELECT * FROM LoginHistory;
END;
GO

-- Get Payment By ID
CREATE PROCEDURE GetPaymentByID
    @PaymentID INT
AS
BEGIN
    SELECT * FROM Payments WHERE PaymentID = @PaymentID;
END
GO

-- Add New Payment
CREATE PROCEDURE AddNewPayment
    @Amount DECIMAL(18,2),
    @PaymentMethod TINYINT,
    @PaymentDate DATETIME,
    @CreatedByUserID SMALLINT,
    @CreatedAt DATETIME
AS
BEGIN
    INSERT INTO Payments (Amount, PaymentMethod, PaymentDate, CreatedByUserID, CreatedAt)
    VALUES (@Amount, @PaymentMethod, @PaymentDate, @CreatedByUserID, @CreatedAt);

    SELECT SCOPE_IDENTITY();
END
GO

-- Check if Payment Exists
CREATE PROCEDURE DoesPaymentExist
    @PaymentID INT
AS
BEGIN
    SELECT Found = 1 FROM Payments WHERE PaymentID = @PaymentID;
END
GO

-- Get All Payments
CREATE PROCEDURE GetAllPayments
@PageNumber INT,
@Records INT OUTPUT,
@PageSize INT
AS
BEGIN
 SELECT 
        p.PaymentID, 
        pa.PatientID,
        pe.FirstName + ' ' + pe.LastName AS FullName,
        CAST(p.Amount AS VARCHAR(20)) + ' SAR' AS Amount,
        CASE p.PaymentMethod
            WHEN 1 THEN 'Cash'
            WHEN 2 THEN 'Debit Card'
            WHEN 3 THEN 'Bank Transfer'
            WHEN 4 THEN 'Mobile Payment'
            ELSE 'Cash'
        END AS PaymentMethod,
        CONVERT(VARCHAR(20), p.PaymentDate) AS PaymentDate,
        u.Username
    FROM Payments p
    INNER JOIN Users u ON p.CreatedByUserID = u.UserID
    INNER JOIN Appointments a ON a.PaymentID = p.PaymentID
    INNER JOIN Patients pa ON a.PatientID = pa.PatientID
    INNER JOIN People pe ON pa.PersonID = pe.PersonID
    ORDER BY p.PaymentDate DESC
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY;
    
    SELECT @Records = COUNT(*) FROM Payments;

END
GO

CREATE PROCEDURE GetTotalPaymentsAmount
AS
BEGIN
	SELECT SUM(Amount) AS TotalPaymentsAmount FROM Payments;
END
GO


CREATE PROCEDURE GetAverageAmountPerPayment
AS
BEGIN
SELECT AVG(Amount) AS AverageAmountPerPayment FROM Payments;
END
GO

CREATE PROCEDURE GetTotalPayments
AS
BEGIN
SELECT Count(*) AS TotalPayments FROM Payments;
END
GO

CREATE PROCEDURE GetMostUsedPaymentMethod
AS
BEGIN
SELECT TOP 1 
CASE 
	WHEN PaymentMethod = 1 THEN 'Cash'
	WHEN PaymentMethod = 2 THEN 'Debit Card'
	WHEN PaymentMethod = 3 THEN 'Bank Transfer'
	WHEN PaymentMethod = 4 THEN 'Mobile Payment'
	END AS MostUsedPaymentMethod FROM Payments
GROUP BY PaymentMethod 
ORDER BY COUNT(*) DESC
END
GO


CREATE PROCEDURE GetPatientMedicalRecords
    @PatientID INT
AS
BEGIN
SELECT MedicalRecordID, MedicalRecords.AppointmentID ,Diagnosis,
Prescription ,Notes, Users.Username, MedicalRecords.CreatedAt
FROM MedicalRecords
INNER JOIN Appointments ON Appointments.AppointmentID = MedicalRecords.AppointmentID
INNER JOIN Users ON Users.UserID = MedicalRecords.CreatedByUserID
WHERE Appointments.PatientID = @PatientID
ORDER BY MedicalRecordID DESC
END
GO

CREATE PROCEDURE GetTodayAppointmentsCount
AS
BEGIN
	DECLARE @TodayStart DATETIME = CAST(GETDATE() AS DATE);
	DECLARE @TodayEnd DATETIME = DATEADD(DAY,1,@TodayStart);

    SELECT COUNT(*) AS TodayAppointmentsCount
    FROM Appointments 
	WHERE AppointmentDate >= @TodayStart AND AppointmentDate < @TodayEnd
END
GO

CREATE PROCEDURE GetWeeklyAppointmentsCount
AS
BEGIN
	DECLARE @StartOfWeek DATE;
	DECLARE @EndOfWeek DATE;

	SET @StartOfWeek = DATEADD(DAY, -DATEPART(WEEKDAY,GETDATE()) + 1 ,GETDATE());
	SET @EndOfWeek = DATEADD(DAY, 7, @StartOfWeek);

	SELECT COUNT(*) AS WeeklyAppointmentsCount
    FROM Appointments
    WHERE AppointmentDate >= @StartOfWeek AND AppointmentDate < @EndOfWeek;
END
GO

CREATE PROCEDURE GetCreatedAppointmentsThisWeekCount
AS
BEGIN
	DECLARE @StartOfWeek DATE;
	DECLARE @EndOfWeek DATE;

	SET @StartOfWeek = DATEADD(DAY, -DATEPART(WEEKDAY,GETDATE()) + 1 ,GETDATE());
	SET @EndOfWeek = DATEADD(DAY, 7, @StartOfWeek);

 SELECT COUNT(*) AS CreatedAppointmentsThisWeekCount
    FROM Appointments 
	WHERE CreatedAt >= @StartOfWeek AND CreatedAt < @EndOfWeek
END
GO



CREATE PROCEDURE GetTotalPatients 
AS
BEGIN
SELECT COUNT(*) AS TotalPatients FROM Patients;
END
GO

CREATE PROCEDURE GetNewPatientsThisWeek 
AS
BEGIN
	DECLARE @StartOfWeek DATE;
	DECLARE @EndOfWeek DATE;

	SET @StartOfWeek = DATEADD(DAY, -DATEPART(WEEKDAY,GETDATE()) + 1 ,GETDATE());
	SET @EndOfWeek = DATEADD(DAY, 7, @StartOfWeek);

	SELECT COUNT(*) AS NewPatientsThisWeek FROM Patients
	WHERE CreatedAt >= @StartOfWeek AND CreatedAt < @EndOfWeek;
END
GO

CREATE PROCEDURE GetAveragePatientAge
AS
BEGIN
WITH PatientsAge AS (
SELECT DATEDIFF(Year, People.BirthDate, GETDATE()) AS Age
FROM Patients
INNER JOIN People ON People.PersonID = Patients.PersonID)
SELECT AVG(Age) AS AveragePatientAge FROM PatientsAge
END
GO


CREATE PROCEDURE GetTotalAvailableDoctors
AS
BEGIN
SELECT COUNT(*) AS TotalAvailableDoctors FROM Doctors
WHERE DoctorStatus = 1
END
GO

CREATE PROCEDURE GetAverageConsultationFee
AS
BEGIN
SELECT AVG(ConsultationFee) AS AverageConsultationFee FROM Doctors
WHERE DoctorStatus = 1
END
GO


CREATE PROCEDURE GetTotalDepartments
AS
BEGIN
SELECT COUNT(*) AS TotalDepartments FROM Departments
END
GO





CREATE PROCEDURE [dbo].[GetPersonWithPersonID]
@PersonID INT
AS
BEGIN
    SELECT People.PersonID, 
           People.FirstName + ' ' + People.SecondName + ' ' + 
           CASE WHEN People.ThirdName IS NULL THEN '' ELSE People.ThirdName + ' ' END + People.LastName AS FullName, 
           People.NationalID, 
           People.BirthDate, 
           CASE WHEN People.Gender = 0 THEN 'Male' ELSE 'Female' END AS Gender,
           People.Phone, 
           People.Email, 
           Countries.CountryName, 
           Users.Username AS CreatedBy
    FROM People
    INNER JOIN Countries ON People.CountryID = Countries.CountryID
    INNER JOIN Users ON People.CreatedByUserID = Users.UserID
	WHERE People.PersonID = @PersonID
    ORDER BY People.CreatedAt DESC
END
GO

-- Get Person As DataTable By Name
CREATE PROCEDURE [dbo].[GetPeopleWithName]
@PageNumber INT,
@Records INT OUTPUT,
@PageSize INT,
@Name VARCHAR(60)
AS
BEGIN
SELECT People.PersonID, 
           People.FirstName + ' ' + People.SecondName + ' ' + 
           CASE WHEN People.ThirdName IS NULL THEN '' ELSE People.ThirdName + ' ' END + People.LastName AS FullName, 
           People.NationalID, 
           People.BirthDate, 
           CASE WHEN People.Gender = 0 THEN 'Male' ELSE 'Female' END AS Gender,
           People.Phone, 
           People.Email, 
           Countries.CountryName, 
           Users.Username AS CreatedBy
    FROM People
    INNER JOIN Countries ON People.CountryID = Countries.CountryID
    INNER JOIN Users ON People.CreatedByUserID = Users.UserID

	WHERE People.FirstName + ' ' + People.SecondName + ' ' + 
	CASE 
		WHEN People.ThirdName IS NULL THEN '' 
		ELSE People.ThirdName + ' ' 
	END + People.LastName 
	LIKE @Name + '%'
	ORDER BY PersonID
	OFFSET (@PageNumber - 1) * @PageSize ROWS
	FETCH NEXT @PageSize ROWS ONLY

	SELECT @Records = Count(*) FROM People
	WHERE People.FirstName + ' ' + People.SecondName + ' ' + 
	CASE 
		WHEN People.ThirdName IS NULL THEN '' 
		ELSE People.ThirdName + ' ' 
	END + People.LastName 
	LIKE @Name + '%'
END
GO

-- Get Person As DataTable By NationalID
CREATE PROCEDURE [dbo].[GetPersonWithNationalID]
@NationalID VARCHAR(10)
AS
BEGIN
    SELECT People.PersonID, 
           People.FirstName + ' ' + People.SecondName + ' ' + 
           CASE WHEN People.ThirdName IS NULL THEN '' ELSE People.ThirdName + ' ' END + People.LastName AS FullName, 
           People.NationalID, 
           People.BirthDate, 
           CASE WHEN People.Gender = 0 THEN 'Male' ELSE 'Female' END AS Gender,
           People.Phone, 
           People.Email, 
           Countries.CountryName, 
           Users.Username AS CreatedBy
    FROM People
    INNER JOIN Countries ON People.CountryID = Countries.CountryID
    INNER JOIN Users ON People.CreatedByUserID = Users.UserID
	WHERE People.NationalID = @NationalID
    ORDER BY People.CreatedAt DESC
END
GO



CREATE PROCEDURE [dbo].[GetPatientWithPatientID]
@PatientID INT
AS
BEGIN
    SELECT PatientID, Patients.PersonID, 
        CONCAT(People.FirstName, ' ', People.SecondName, ' ', People.LastName) AS FullName,
        People.NationalID, 
        BloodType, 
        CASE WHEN Allergies IS NULL THEN 'No Known Allergies' ELSE Allergies END AS Allergies,
        CASE WHEN MedicalHistory IS NULL THEN 'No Known Medical History' ELSE MedicalHistory END AS MedicalHistory,
        CASE WHEN EmergencyContactName IS NULL THEN 'Not Available' ELSE EmergencyContactName END AS EmergencyContactName,
        CASE WHEN EmergencyContactPhone IS NULL THEN 'Not Available' ELSE EmergencyContactPhone END AS EmergencyContactPhone
    FROM Patients
    INNER JOIN People ON People.PersonID = Patients.PersonID
	WHERE Patients.PatientID = @PatientID
    ORDER BY Patients.CreatedAt DESC
END
GO

CREATE PROCEDURE [dbo].[GetPatientWithPersonID]
@PersonID INT
AS
BEGIN
    SELECT PatientID, Patients.PersonID, 
        CONCAT(People.FirstName, ' ', People.SecondName, ' ', People.LastName) AS FullName,
        People.NationalID, 
        BloodType, 
        CASE WHEN Allergies IS NULL THEN 'No Known Allergies' ELSE Allergies END AS Allergies,
        CASE WHEN MedicalHistory IS NULL THEN 'No Known Medical History' ELSE MedicalHistory END AS MedicalHistory,
        CASE WHEN EmergencyContactName IS NULL THEN 'Not Available' ELSE EmergencyContactName END AS EmergencyContactName,
        CASE WHEN EmergencyContactPhone IS NULL THEN 'Not Available' ELSE EmergencyContactPhone END AS EmergencyContactPhone
    FROM Patients
    INNER JOIN People ON People.PersonID = Patients.PersonID
	WHERE Patients.PersonID = @PersonID
    ORDER BY Patients.CreatedAt DESC
END
GO

CREATE PROCEDURE [dbo].[GetPatientWithName]
@PageNumber INT,
@Records INT OUTPUT,
@PageSize INT,
@Name VARCHAR(120)
AS
BEGIN
    SELECT PatientID, Patients.PersonID, 
        CONCAT(People.FirstName, ' ', People.SecondName, ' ', People.LastName) AS FullName,
        People.NationalID, 
        BloodType, 
        CASE WHEN Allergies IS NULL THEN 'No Known Allergies' ELSE Allergies END AS Allergies,
        CASE WHEN MedicalHistory IS NULL THEN 'No Known Medical History' ELSE MedicalHistory END AS MedicalHistory,
        CASE WHEN EmergencyContactName IS NULL THEN 'Not Available' ELSE EmergencyContactName END AS EmergencyContactName,
        CASE WHEN EmergencyContactPhone IS NULL THEN 'Not Available' ELSE EmergencyContactPhone END AS EmergencyContactPhone
    FROM Patients
    INNER JOIN People ON People.PersonID = Patients.PersonID
	WHERE CONCAT(People.FirstName, ' ', People.SecondName, ' ', People.LastName) LIKE @Name + '%'
    ORDER BY Patients.CreatedAt DESC

	OFFSET (@PageNumber - 1) * @PageSize ROWS
	FETCH NEXT @PageSize ROWS ONLY

	SELECT @Records = Count(*) FROM Patients 
	INNER JOIN People ON People.PersonID = Patients.PersonID
	WHERE CONCAT(People.FirstName, ' ', People.SecondName, ' ', People.LastName) LIKE @Name + '%'
END
GO

CREATE PROCEDURE [dbo].[GetPatientWithNationalID]
@NationalID VARCHAR(10)
AS
BEGIN
    SELECT PatientID, Patients.PersonID, 
        CONCAT(People.FirstName, ' ', People.SecondName, ' ', People.LastName) AS FullName,
        People.NationalID, 
        BloodType, 
        CASE WHEN Allergies IS NULL THEN 'No Known Allergies' ELSE Allergies END AS Allergies,
        CASE WHEN MedicalHistory IS NULL THEN 'No Known Medical History' ELSE MedicalHistory END AS MedicalHistory,
        CASE WHEN EmergencyContactName IS NULL THEN 'Not Available' ELSE EmergencyContactName END AS EmergencyContactName,
        CASE WHEN EmergencyContactPhone IS NULL THEN 'Not Available' ELSE EmergencyContactPhone END AS EmergencyContactPhone
    FROM Patients
    INNER JOIN People ON People.PersonID = Patients.PersonID
	WHERE People.NationalID = @NationalID
    ORDER BY Patients.CreatedAt DESC
END
GO



CREATE PROCEDURE [dbo].[GetAppointmentWithPatientName]
@PageNumber INT,
@Records INT OUTPUT,
@PageSize INT,
@Name VARCHAR(120)
AS
BEGIN
        SELECT AppointmentID, Appointments.PatientID,
           CONCAT(People.FirstName, ' ', People.LastName) AS PatientName,
           DoctorID, CONVERT(VARCHAR(20), AppointmentDate) AS AppointmentDate, 
           CASE 
               WHEN AppointmentStatus = 1 THEN 'Scheduled'
               WHEN AppointmentStatus = 2 THEN 'Completed'
               WHEN AppointmentStatus = 3 THEN 'Cancelled'
               WHEN AppointmentStatus = 4 THEN 'No-Show'
           END AS Status,
           CASE 
               WHEN IsPaid = 1 THEN 'Yes'
               WHEN IsPaid = 0 THEN 'No'
           END AS IsPaid,
           CASE 
               WHEN PaymentID IS NULL THEN 'N/A'
               ELSE CAST(PaymentID AS VARCHAR)
           END AS PaymentID
    FROM Appointments
    INNER JOIN Patients ON Patients.PatientID = Appointments.PatientID
    INNER JOIN People ON People.PersonID = Patients.PersonID
	WHERE  CONCAT(People.FirstName, ' ', People.LastName) LIKE @Name + '%'
	ORDER BY Appointments.CreatedAt DESC

	OFFSET (@PageNumber - 1) * @PageSize ROWS
	FETCH NEXT @PageSize ROWS ONLY

	SELECT @Records = COUNT(*) FROM Appointments 
	INNER JOIN Patients ON Patients.PatientID = Appointments.PatientID
    INNER JOIN People ON People.PersonID = Patients.PersonID
	WHERE  CONCAT(People.FirstName, ' ', People.LastName) LIKE @Name + '%'

END
GO

CREATE PROCEDURE [dbo].[GetAppointmentWithAppointmentID]
@AppointmentID INT
AS
BEGIN
        SELECT AppointmentID, Appointments.PatientID,
           CONCAT(People.FirstName, ' ', People.LastName) AS PatientName,
           DoctorID, CONVERT(VARCHAR(20), AppointmentDate) AS AppointmentDate, 
           CASE 
               WHEN AppointmentStatus = 1 THEN 'Scheduled'
               WHEN AppointmentStatus = 2 THEN 'Completed'
               WHEN AppointmentStatus = 3 THEN 'Cancelled'
               WHEN AppointmentStatus = 4 THEN 'No-Show'
           END AS Status,
           CASE 
               WHEN IsPaid = 1 THEN 'Yes'
               WHEN IsPaid = 0 THEN 'No'
           END AS IsPaid,
           CASE 
               WHEN PaymentID IS NULL THEN 'N/A'
               ELSE CAST(PaymentID AS VARCHAR)
           END AS PaymentID
    FROM Appointments
    INNER JOIN Patients ON Patients.PatientID = Appointments.PatientID
    INNER JOIN People ON People.PersonID = Patients.PersonID
	WHERE Appointments.AppointmentID = @AppointmentID
	ORDER BY Appointments.CreatedAt DESC
END
GO


CREATE PROCEDURE [dbo].[GetAppointmentsWithPatientID]
@PageNumber INT,
@Records INT OUTPUT,
@PageSize INT,
@PatientID INT
AS
BEGIN
        SELECT AppointmentID, Appointments.PatientID,
           CONCAT(People.FirstName, ' ', People.LastName) AS PatientName,
           DoctorID, CONVERT(VARCHAR(20), AppointmentDate) AS AppointmentDate, 
           CASE 
               WHEN AppointmentStatus = 1 THEN 'Scheduled'
               WHEN AppointmentStatus = 2 THEN 'Completed'
               WHEN AppointmentStatus = 3 THEN 'Cancelled'
               WHEN AppointmentStatus = 4 THEN 'No-Show'
           END AS Status,
           CASE 
               WHEN IsPaid = 1 THEN 'Yes'
               WHEN IsPaid = 0 THEN 'No'
           END AS IsPaid,
           CASE 
               WHEN PaymentID IS NULL THEN 'N/A'
               ELSE CAST(PaymentID AS VARCHAR)
           END AS PaymentID
    FROM Appointments
    INNER JOIN Patients ON Patients.PatientID = Appointments.PatientID
    INNER JOIN People ON People.PersonID = Patients.PersonID
	WHERE Appointments.PatientID = @PatientID
	ORDER BY Appointments.CreatedAt DESC

	OFFSET (@PageNumber - 1) * @PageSize ROWS
	FETCH NEXT @PageSize ROWS ONLY

	SELECT @Records = Count(*) FROM Appointments
	WHERE PatientID = @PatientID
END
GO

CREATE PROCEDURE [dbo].[GetAppointmentsWithDoctorID]
@PageNumber INT,
@Records INT OUTPUT,
@PageSize INT,
@DoctorID INT
AS
BEGIN
        SELECT AppointmentID, Appointments.PatientID,
           CONCAT(People.FirstName, ' ', People.LastName) AS PatientName,
           DoctorID, CONVERT(VARCHAR(20), AppointmentDate) AS AppointmentDate, 
           CASE 
               WHEN AppointmentStatus = 1 THEN 'Scheduled'
               WHEN AppointmentStatus = 2 THEN 'Completed'
               WHEN AppointmentStatus = 3 THEN 'Cancelled'
               WHEN AppointmentStatus = 4 THEN 'No-Show'
           END AS Status,
           CASE 
               WHEN IsPaid = 1 THEN 'Yes'
               WHEN IsPaid = 0 THEN 'No'
           END AS IsPaid,
           CASE 
               WHEN PaymentID IS NULL THEN 'N/A'
               ELSE CAST(PaymentID AS VARCHAR)
           END AS PaymentID
    FROM Appointments
    INNER JOIN Patients ON Patients.PatientID = Appointments.PatientID
    INNER JOIN People ON People.PersonID = Patients.PersonID
	WHERE Appointments.DoctorID = @DoctorID
	ORDER BY Appointments.CreatedAt DESC

	OFFSET (@PageNumber - 1) * @PageSize ROWS
	FETCH NEXT @PageSize ROWS ONLY

	SELECT @Records = Count(*) FROM Appointments
	WHERE DoctorID = @DoctorID
END
GO



CREATE PROCEDURE dbo.GetMedicalRecordByID
    @MedicalRecordID INT
AS
BEGIN
	SELECT * FROM MedicalRecords WHERE MedicalRecordID = @MedicalRecordID;
END
GO


CREATE PROCEDURE dbo.AddNewMedicalRecord
    @Diagnosis NVARCHAR(600),
    @Prescription NVARCHAR(600),
    @Notes NVARCHAR(600),
    @AppointmentID INT,
    @CreatedByUserID SMALLINT,
    @CreatedAt DATETIME
AS
BEGIN
	INSERT INTO MedicalRecords (Diagnosis, Prescription, Notes, AppointmentID, CreatedByUserID, CreatedAt)
	VALUES (@Diagnosis, @Prescription, @Notes, @AppointmentID, @CreatedByUserID, @CreatedAt)
	SELECT SCOPE_IDENTITY();
END
GO


CREATE PROCEDURE UpdateMedicalRecord
    @MedicalRecordID INT,
    @Diagnosis NVARCHAR(600),
    @Prescription NVARCHAR(600),
    @Notes NVARCHAR(600),
    @AppointmentID INT,
    @CreatedByUserID SMALLINT,
    @CreatedAt DATETIME
AS
BEGIN

    UPDATE MedicalRecords  
    SET 
        Diagnosis = @Diagnosis, 
        Prescription = @Prescription, 
        Notes = @Notes, 
        CreatedByUserID = @CreatedByUserID, 
        CreatedAt = @CreatedAt
    WHERE MedicalRecordID = @MedicalRecordID;
END;
GO

CREATE PROCEDURE DeleteMedicalRecord
    @MedicalRecordID INT
AS
BEGIN

    DELETE FROM MedicalRecords 
    WHERE MedicalRecordID = @MedicalRecordID;
END;
GO

CREATE PROCEDURE DoesMedicalRecordExist
    @MedicalRecordID INT
AS
BEGIN

    SELECT Found = 1 FROM MedicalRecords WHERE MedicalRecordID = @MedicalRecordID;
END;
GO