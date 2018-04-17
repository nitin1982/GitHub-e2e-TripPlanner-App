USE master
IF EXISTS(select * from sys.databases where name='TripPlannerDB')
begin
	DROP DATABASE TripPlannerDB
	print 'TripPlannerDB dropped..'
end

Create Database TripPlannerDB
Go
print 'TripPlannerDB created..'
-----
Use TripPlannerDB
Go
----




Create Table ReferenceCategory
(
	ReferenceCategoryID int primary key identity(1,1),
	RefCatName varchar(50),
	RefCatDesc varchar(150) null,
	RefCatCode varchar(15),
	IsActive bit,
	CONSTRAINT UC_RefCatCode UNIQUE (RefCatCode)
)
print 'ReferenceCategory table created..'

Create Table Reference
(
	ReferenceID int primary key identity(1,1),
	ReferenceCategoryID int foreign key references ReferenceCategory(ReferenceCategoryID),
	RefName varchar(50),
	RefDesc varchar(150) null,
	RefCode varchar(15),
	IsActive bit,
	CONSTRAINT UC_RefCode UNIQUE (RefCode)
)

print 'Reference table created..'

Create Table TripGroup
(
	TripGroupID int primary key identity(1,1),
	GroupTitle varchar(50),
	GroupDetail varchar(1000) null
)

print 'TripGroup table created..'

Create Table Trip
(
	TripID int primary key identity(1,1),
	Title varchar(50),
	Detail varchar(1000) null,
	Place varchar(30),
	StartDate datetime null,
	EndDate datetime null,	
	TripTypeID int foreign key references Reference(ReferenceID) null,
	TripGroupID int foreign key references TripGroup(TripGroupID) null
)

print 'Trip table created..'

Create Table Stay
(
	StayID int primary key identity(1,1),
	HotelName varchar(50),
	Street1 varchar(50) null,
	Street2 varchar(50) null,
	City varchar(15) null,
	State varchar(10) null,
	Zip varchar(5) null,
	ContactNo1 varchar(10) null,
	ContactNo2 varchar(10) null,
	Email varchar(150) null,
	ContactPersonFirstName varchar(20) null,
	ContactPersonMiddleName varchar(20) null,
	ContactPersonLastName varchar(20) null,
	Website varchar(80) null,
	TripID int foreign key references Trip(TripID)
)

print 'Stay table created..'

Create Table WebLink
(
	WebLinkID int primary key identity(1,1),
	WebLinkName varchar(150),
	WebURL varchar(150),
	WebLinkTypeID int foreign key references Reference(ReferenceID),
	TripID int foreign key references Trip(TripID)
)

print 'WebLink table created..'


Create Table Document
(
	DocumentID int primary key identity(1,1),
	DocName varchar(50),
	DocDesc varchar(500) NULL,
	DocUrl varchar(500),
	DocTypeID int foreign key references Reference(ReferenceID),
	TripID int foreign key references Trip(TripID)
)

print 'Document table created..'


Create Table Picture
(
	PictureID int primary key identity(1,1),
	PicName varchar(50),
	PicDesc varchar(500) NULL,
	PicUrl varchar(500),
	TripID int foreign key references Trip(TripID)
)

print 'Picture table created..'

Create Table TripImportantDate
(
	TripImportantDateID int primary key identity(1,1),
	TripID int foreign key references Trip(TripID),
	ImpDate Date,
	Detail Varchar(500) null,
	SetScreenRemider bit
)

print 'TripImportantDate table created..'

insert ReferenceCategory
select 'WebLink Type', 'Web Link Type', 'WEBLNKTYP',1
union
select 'Document Type', 'Document Type', 'DOCTYP',1
union
select 'Trip Type', 'Trip Type', 'TRIPTYP',1

declare @WebLinkTypeCatId int
declare @docTypeCatId int
declare @trpTypeCatId int

select @WebLinkTypeCatId = ReferenceCategoryID from ReferenceCategory where RefCatCode = 'WEBLNKTYP'
select @docTypeCatId = ReferenceCategoryID from ReferenceCategory where RefCatCode = 'DOCTYP'
select @trpTypeCatId = ReferenceCategoryID from ReferenceCategory where RefCatCode = 'TRIPTYP'

insert Reference
select @WebLinkTypeCatId, 'Hotel Web site', 'Hotel Website', 'HTLWBSTE',1
union
select @WebLinkTypeCatId, 'Travel Guide', 'Website for Travel Guide', 'TRVLGDWBSTE',1
union
select @WebLinkTypeCatId, 'Map', 'Google/Bing Map', 'GGLMAPLNK',1
union
select @WebLinkTypeCatId, 'Food', 'Restaurants Link', 'FOODLNK',1
union
select @WebLinkTypeCatId, 'Place To Visit', 'Place to visit', 'PLCTOVISITLNK',1


insert Reference
select @docTypeCatId, 'Hotel Booking Ticket', 'Hotel Booking Tickets', 'HTLTCKTS',1
union
select @docTypeCatId, 'Entertainment Tickets', 'Entertainment Tickets', 'DOCENTRTNMNT',1
union
select @docTypeCatId, 'Directions', 'Directions Details', 'DOCDIRCTN',1
union
select @docTypeCatId, 'Important Info', 'Important Info', 'DOCINFO',1
union
select @docTypeCatId, 'Other', 'Other', 'DOCOTHR',1

insert Reference
select @trpTypeCatId, 'Business Trip', 'Hotel Booking Tickets', 'TRPTYPBIZ',1
union
select @trpTypeCatId, 'Long Trip', 'Long Trip', 'TRPTYPLNGTRP',1
union
select @trpTypeCatId, 'Day Trip', 'One day trip', 'TRPTYPDAYTRP',1
union
select @trpTypeCatId, 'Picnic', 'Picnic', 'TRPTYPPICNCTRP',1

SELECT t1.*, t2.RefCatName from Reference t1 join ReferenceCategory t2
on t1.ReferenceCategoryID = t2.ReferenceCategoryID

--use master
--drop database tripplannerdb