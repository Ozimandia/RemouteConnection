USE LibraryDB;

CREATE  TABLE [Книги](
[Шифр книги] INT PRIMARY KEY,
[Автор] NCHAR(20) NOT NULL,
[Название] TEXT NOT NULL,
[Год издания] NCHAR(4) NOT NULL,
[Количество экземпляров] INT NOT NULL
);

CREATE TABLE [Читатели](
[Читательский билет] INT PRIMARY KEY,
[Фамилия] NCHAR(20) NOT NULL,
[Имя] NCHAR(20) NOT NULL,
[Отчество] NCHAR(20) NOT NULL,
[Адрес] TEXT NOT NULL
);

CREATE TABLE [Выданные книги](
[ID] INT PRIMARY KEY,
[Шифр книги] INT NOT NULL,
[Читательский билет] INT NOT NULL,
[Дата выдачи] DATE NOT NULL,
[Дата возвращения] DATE NOT NULL,
[Дата фактического возвращения] DATE NOT NULL
);

