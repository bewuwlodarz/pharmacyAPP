CREATE DATABASE Pharmacy;
CREATE TABLE Medicines (
    MedicineID int IDENTITY(1,1) PRIMARY KEY,
    NameMedicine nvarchar(50) NOT NULL,
	Manufacturer nvarchar(50) NOT NULL,
	Price decimal(10,2) NOT NULL CHECK (Price >= 0),
	Amount int NOT NULL CHECK (Amount >= 0),
	WithPrescription Bit not null
	)
	CREATE TABLE Prescriptions (
    PrescriptionID int IDENTITY(1,1) PRIMARY KEY,
    CustomerName nvarchar(50) NOT NULL,
	PESEL nvarchar(11) NOT NULL,
	PrescriptionNumber nvarchar(50) not null
	)
	CREATE TABLE Orders(
	ID int IDENTITY(1,1) PRIMARY KEY,
	MedicineID int not null,
	PrescriptionID int not null,
	DateOrder DateTime2 NOT NULL CHECK (DateOrder <= GETDATE())
	)


	ALTER TABLE Orders ADD CONSTRAINT FK_Orders_Medicines FOREIGN KEY (MedicineID)
REFERENCES Medicines (MedicineID);
	ALTER TABLE Orders ADD CONSTRAINT FK_Orders_Prescriptions FOREIGN KEY (PrescriptionID)
REFERENCES Prescriptions (PrescriptionID);

