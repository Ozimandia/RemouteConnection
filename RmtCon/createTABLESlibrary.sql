USE LibraryDB;

CREATE  TABLE [�����](
[���� �����] INT PRIMARY KEY,
[�����] NCHAR(20) NOT NULL,
[��������] TEXT NOT NULL,
[��� �������] NCHAR(4) NOT NULL,
[���������� �����������] INT NOT NULL
);

CREATE TABLE [��������](
[������������ �����] INT PRIMARY KEY,
[�������] NCHAR(20) NOT NULL,
[���] NCHAR(20) NOT NULL,
[��������] NCHAR(20) NOT NULL,
[�����] TEXT NOT NULL
);

CREATE TABLE [�������� �����](
[ID] INT PRIMARY KEY,
[���� �����] INT NOT NULL,
[������������ �����] INT NOT NULL,
[���� ������] DATE NOT NULL,
[���� �����������] DATE NOT NULL,
[���� ������������ �����������] DATE NOT NULL
);

