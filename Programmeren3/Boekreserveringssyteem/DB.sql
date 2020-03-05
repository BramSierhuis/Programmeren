CREATE Database Boekreserveringsysteem;

USE Boekreserveringsysteem;

GO
/****** Object:  Table [dbo].[Books]    Script Date: 02/03/2020 10:10:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Author] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customers]    Script Date: 02/03/2020 10:10:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NULL,
	[LastName] [nvarchar](100) NULL,
	[EmailAddress] [nvarchar](100) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reservations]    Script Date: 02/03/2020 10:10:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[BookId] [int] NOT NULL,
 CONSTRAINT [PK_Reservations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Reservations_Books] FOREIGN KEY([BookId])
REFERENCES [dbo].[Books] ([Id])
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_Reservations_Books]
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Reservations_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_Reservations_Customers]
GO

GO
SET IDENTITY_INSERT [dbo].[Reservations] ON 

INSERT [dbo].[Reservations] ([Id], [CustomerId], [BookId]) VALUES (1, 1, 1)
INSERT [dbo].[Reservations] ([Id], [CustomerId], [BookId]) VALUES (2, 1, 4)
INSERT [dbo].[Reservations] ([Id], [CustomerId], [BookId]) VALUES (3, 2, 2)
INSERT [dbo].[Reservations] ([Id], [CustomerId], [BookId]) VALUES (4, 2, 3)
INSERT [dbo].[Reservations] ([Id], [CustomerId], [BookId]) VALUES (5, 2, 5)
INSERT [dbo].[Reservations] ([Id], [CustomerId], [BookId]) VALUES (6, 2, 6)
INSERT [dbo].[Reservations] ([Id], [CustomerId], [BookId]) VALUES (7, 2, 7)
INSERT [dbo].[Reservations] ([Id], [CustomerId], [BookId]) VALUES (8, 2, 8)
INSERT [dbo].[Reservations] ([Id], [CustomerId], [BookId]) VALUES (9, 73, 3)
SET IDENTITY_INSERT [dbo].[Reservations] OFF

GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (1, N'The Da Vinci Code', N'Dan Brown')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (2, N'Harry Potter and the Philosopher''s Stone', N'J.K. Rowling')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (3, N'Harry Potter and the Chamber of Secrets', N'J.K. Rowling')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (4, N'Angels and Demons', N'Dan Brown')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (5, N'Harry Potter and the Order of the Phoenix', N'J.K. Rowling')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (6, N'Harry Potter and the Half-blood Prince:Children''s Edition', N'J.K. Rowling')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (7, N'Harry Potter and the Deathly Hallows', N'J.K. Rowling')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (8, N'Harry Potter and the Prisoner of Azkaban', N'J.K. Rowling')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (9, N'Twilight', N'Stephenie Meyer')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (10, N'Harry Potter and the Goblet of Fire', N'J.K. Rowling')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (11, N'Deception Point', N'Dan Brown')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (12, N'New Moon', N'Stephenie Meyer')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (13, N'The Lovely Bones', N'Alice Sebold')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (14, N'Digital Fortress', N'Dan Brown')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (15, N'The Curious Incident of the Dog in the Night-time', N'Mark Haddon')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (16, N'Eclipse', N'Stephenie Meyer')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (17, N'The Girl with the Dragon Tattoo', N'Stieg Larsson')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (18, N'The Kite Runner', N'Khaled Hosseini')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (19, N'The Time Traveler''s Wife', N'Audrey Niffenegger')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (20, N'The World According to Clarkson', N'Jeremy Clarkson')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (21, N'Atonement', N'Ian McEwan')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (22, N'The Lost Symbol', N'Dan Brown')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (23, N'A Short History of Nearly Everything', N'Bryson, Bill')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (24, N'Breaking Dawn', N'Stephenie Meyer')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (25, N'Harry Potter and the Goblet of Fire', N'J.K. Rowling')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (26, N'Harry Potter and the Deathly Hallows', N'J.K. Rowling')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (27, N'The Girl Who Played With Fire', N'Stieg Larsson')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (28, N'A Child Called It', N'Dave Pelzer')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (29, N'The No.1 Ladies'' Detective Agency', N'Alexander McCall Smith')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (30, N'You are What You Eat', N'Gillian McKeith')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (31, N'Man and Boy', N'Tony Parsons')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (32, N'Birdsong', N'Sebastian Faulks')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (33, N'Labyrinth', N'Kate Mosse')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (34, N'The Island', N'Victoria Hislop')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (35, N'Life of Pi', N'Yann Martel')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (36, N'The Dr. Atkins'' New Diet Revolution', N'Robert C. Atkins')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (37, N'The Tales of Beedle the Bard', N'J. K. Rowling')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (38, N'Captain Corelli''s Mandolin', N'Louis De Bernieres')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (39, N'Delia''s How to Cook', N'Delia Smith')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (40, N'The Gruffalo', N'Julia Donaldson')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (41, N'The Eats, Shoots and Leaves', N'Lynne Truss')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (42, N'Northern Lights', N'Philip Pullman')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (43, N'The Interpretation of Murder', N'Jed Rubenfeld')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (44, N'The Girl Who Kicked the Hornets'' Nest', N'Stieg Larsson')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (45, N'Bridget Jones: The Edge of Reason', N'Helen Fielding')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (46, N'A Short History of Tractors in Ukrainian', N'Marina Lewycka')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (47, N'The Alchemist', N'Paulo Coelho')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (48, N'Notes from a Small Island', N'Bill Bryson')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (49, N'The Boy in the Striped Pyjamas', N'John Boyne')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (50, N'Stupid White Men:...and Other', N'Michael Moore')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (51, N'Jamie''s 30-minute Meals', N'Jamie Oliver')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (52, N'The Broker', N'John Grisham')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (53, N'Bridget Jones''s Diary:A Novel', N'Helen Fielding')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (54, N'The Very Hungry Caterpillar', N'Eric Carle')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (55, N'A Thousand Splendid Suns', N'Khaled Hosseini')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (56, N'The Sound of Laughter', N'Peter Kay')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (57, N'Jamie''s Italy', N'Jamie Oliver')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (58, N'Small Island', N'Andrea Levy')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (59, N'The Memory Keeper''s Daughter', N'Kim Edwards')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (60, N'Billy Connolly', N'Pamela Stephenson')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (61, N'The House at Riverton', N'Kate Morton')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (62, N'Harry Potter and the Order of the Phoenix', N'J. K. Rowling')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (63, N'Nigella Express', N'Lawson, Nigella')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (64, N'Memoirs of a Geisha', N'Arthur Golden')
INSERT [dbo].[Books] ([Id], [Title], [Author]) VALUES (65, N'Delia''s How to Cook', N'Delia Smith')
SET IDENTITY_INSERT [dbo].[Books] OFF

GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (1, N'Christopher', N'Brown', N'Christopher.Brown@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (2, N'Clarke', N'Villarreal', N'Clarke.Villarreal@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (3, N'Davis', N'Dorsey', N'Davis.Dorsey@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (4, N'Bruno', N'Benson', N'Bruno.Benson@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (5, N'Adrian', N'Dickson', N'Adrian.Dickson@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (6, N'Kareem', N'Reynolds', N'Kareem.Reynolds@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (7, N'Randall', N'Hanson', N'Randall.Hanson@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (8, N'Roth', N'Rowland', N'Roth.Rowland@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (9, N'Felix', N'Lamb', N'Felix.Lamb@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (10, N'Kevin', N'Bridges', N'Kevin.Bridges@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (11, N'Donovan', N'Carey', N'Donovan.Carey@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (12, N'Lucius', N'Monroe', N'Lucius.Monroe@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (13, N'Abraham', N'Savage', N'Abraham.Savage@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (14, N'Leonard', N'Wise', N'Leonard.Wise@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (15, N'Arthur', N'Vance', N'Arthur.Vance@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (16, N'Travis', N'Welch', N'Travis.Welch@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (17, N'Walker', N'Hoffman', N'Walker.Hoffman@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (18, N'Merrill', N'Sampson', N'Merrill.Sampson@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (19, N'Cruz', N'Hammond', N'Cruz.Hammond@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (20, N'Dexter', N'Chavez', N'Dexter.Chavez@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (21, N'Justin', N'Chapman', N'Justin.Chapman@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (22, N'Tanner', N'Ingram', N'Tanner.Ingram@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (23, N'Nigel', N'Lee', N'Nigel.Lee@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (24, N'Nash', N'Parrish', N'Nash.Parrish@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (25, N'Ronan', N'Benjamin', N'Ronan.Benjamin@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (26, N'Stuart', N'Fischer', N'Stuart.Fischer@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (27, N'Josiah', N'Puckett', N'Josiah.Puckett@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (28, N'Damon', N'Mcpherson', N'Damon.Mcpherson@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (29, N'Uriel', N'Maxwell', N'Uriel.Maxwell@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (30, N'Jared', N'Kline', N'Jared.Kline@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (31, N'Valentine', N'Randolph', N'Valentine.Randolph@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (32, N'Brett', N'Pitts', N'Brett.Pitts@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (33, N'Harrison', N'Cooper', N'Harrison.Cooper@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (34, N'Scott', N'Goodman', N'Scott.Goodman@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (35, N'Curran', N'Head', N'Curran.Head@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (36, N'Fuller', N'Russo', N'Fuller.Russo@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (37, N'Tanek', N'Clark', N'Tanek.Clark@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (38, N'Axel', N'Snyder', N'Axel.Snyder@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (39, N'Galvin', N'Morin', N'Galvin.Morin@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (40, N'Beck', N'Wright', N'Beck.Wright@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (41, N'Allistair', N'Russell', N'Allistair.Russell@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (42, N'Barrett', N'Wagner', N'Barrett.Wagner@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (43, N'Lewis', N'Anderson', N'Lewis.Anderson@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (44, N'Erich', N'Hopkins', N'Erich.Hopkins@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (45, N'Jarrod', N'Lambert', N'Jarrod.Lambert@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (46, N'Clayton', N'Osborne', N'Clayton.Osborne@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (47, N'Arsenio', N'May', N'Arsenio.May@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (48, N'Lewis', N'Browning', N'Lewis.Browning@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (49, N'Gary', N'Carson', N'Gary.Carson@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (50, N'Graiden', N'Witt', N'Graiden.Witt@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (51, N'Carl', N'Heath', N'Carl.Heath@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (52, N'Lyle', N'Bates', N'Lyle.Bates@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (53, N'Gannon', N'Gillespie', N'Gannon.Gillespie@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (54, N'Ezekiel', N'Ellison', N'Ezekiel.Ellison@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (55, N'Lawrence', N'Pearson', N'Lawrence.Pearson@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (56, N'Jakeem', N'Eaton', N'Jakeem.Eaton@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (57, N'Fletcher', N'Blankenship', N'Fletcher.Blankenship@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (58, N'Ross', N'Battle', N'Ross.Battle@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (59, N'Austin', N'Sheppard', N'Austin.Sheppard@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (60, N'Barrett', N'Mccullough', N'Barrett.Mccullough@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (61, N'Denton', N'Foster', N'Denton.Foster@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (62, N'Axel', N'Haynes', N'Axel.Haynes@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (63, N'Reed', N'Rodgers', N'Reed.Rodgers@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (64, N'Tate', N'Gaines', N'Tate.Gaines@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (65, N'Declan', N'Clements', N'Declan.Clements@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (66, N'Nash', N'Crane', N'Nash.Crane@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (67, N'Branden', N'Turner', N'Branden.Turner@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (68, N'Joshua', N'Rios', N'Joshua.Rios@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (69, N'Clayton', N'Stewart', N'Clayton.Stewart@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (70, N'Calvin', N'Bishop', N'Calvin.Bishop@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (71, N'Oliver', N'Koch', N'Oliver.Koch@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (72, N'Griffith', N'Guerra', N'Griffith.Guerra@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (73, N'Otto', N'Fischer', N'Otto.Fischer@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (74, N'Herrod', N'Frederick', N'Herrod.Frederick@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (75, N'Finn', N'Yates', N'Finn.Yates@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (76, N'Benjamin', N'Cummings', N'Benjamin.Cummings@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (77, N'Cairo', N'Burns', N'Cairo.Burns@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (78, N'Wang', N'Suarez', N'Wang.Suarez@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (79, N'Colin', N'Hicks', N'Colin.Hicks@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (80, N'Robert', N'Dawson', N'Robert.Dawson@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (81, N'Castor', N'Hood', N'Castor.Hood@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (82, N'Justin', N'Stout', N'Justin.Stout@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (83, N'Omar', N'Jones', N'Omar.Jones@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (84, N'Curran', N'Cote', N'Curran.Cote@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (85, N'Octavius', N'Sanders', N'Octavius.Sanders@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (86, N'Jacob', N'Schneider', N'Jacob.Schneider@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (87, N'Cullen', N'Fitzpatrick', N'Cullen.Fitzpatrick@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (88, N'Beau', N'Dalton', N'Beau.Dalton@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (89, N'Coby', N'Cameron', N'Coby.Cameron@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (90, N'Neville', N'Suarez', N'Neville.Suarez@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (91, N'Slade', N'Salas', N'Slade.Salas@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (92, N'Marshall', N'Shannon', N'Marshall.Shannon@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (93, N'Uriel', N'Wolfe', N'Uriel.Wolfe@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (94, N'Fuller', N'Glover', N'Fuller.Glover@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (95, N'Thomas', N'Webb', N'Thomas.Webb@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (96, N'Raphael', N'Holland', N'Raphael.Holland@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (97, N'Joshua', N'Oneil', N'Joshua.Oneil@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (98, N'Edward', N'Schneider', N'Edward.Schneider@hotmail.com')
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (99, N'Flynn', N'Cervantes', N'Flynn.Cervantes@hotmail.com')
GO
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [EmailAddress]) VALUES (100, N'Cruz', N'Torres', N'Cruz.Torres@hotmail.com')
SET IDENTITY_INSERT [dbo].[Customers] OFF

GO
SET IDENTITY_INSERT [dbo].[Reservations] ON 

INSERT [dbo].[Reservations] ([Id], [CustomerId], [BookId]) VALUES (1, 1, 1)
INSERT [dbo].[Reservations] ([Id], [CustomerId], [BookId]) VALUES (2, 1, 4)
INSERT [dbo].[Reservations] ([Id], [CustomerId], [BookId]) VALUES (3, 2, 2)
INSERT [dbo].[Reservations] ([Id], [CustomerId], [BookId]) VALUES (4, 2, 3)
INSERT [dbo].[Reservations] ([Id], [CustomerId], [BookId]) VALUES (5, 2, 5)
INSERT [dbo].[Reservations] ([Id], [CustomerId], [BookId]) VALUES (6, 2, 6)
INSERT [dbo].[Reservations] ([Id], [CustomerId], [BookId]) VALUES (7, 2, 7)
INSERT [dbo].[Reservations] ([Id], [CustomerId], [BookId]) VALUES (8, 2, 8)
INSERT [dbo].[Reservations] ([Id], [CustomerId], [BookId]) VALUES (9, 73, 3)
SET IDENTITY_INSERT [dbo].[Reservations] OFF