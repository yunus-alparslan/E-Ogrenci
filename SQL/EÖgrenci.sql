USE [EÖgrenci]
GO
/****** Object:  Table [dbo].[Table_Ders]    Script Date: 7.06.2023 19:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Ders](
	[DERSİD] [tinyint] IDENTITY(1,1) NOT NULL,
	[DERSAD] [varchar](20) NULL,
 CONSTRAINT [PK_Table_Ders] PRIMARY KEY CLUSTERED 
(
	[DERSİD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_Kulüp]    Script Date: 7.06.2023 19:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Kulüp](
	[KULUPİD] [tinyint] IDENTITY(1,1) NOT NULL,
	[KULUPAD] [varchar](30) NULL,
 CONSTRAINT [PK_Table_Külüp] PRIMARY KEY CLUSTERED 
(
	[KULUPİD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_Notlar]    Script Date: 7.06.2023 19:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Notlar](
	[NOTID] [int] IDENTITY(1,1) NOT NULL,
	[DERSİD] [tinyint] NULL,
	[OGRİD] [int] NULL,
	[SINAV1] [tinyint] NULL,
	[SINAV2] [tinyint] NULL,
	[SINAV3] [tinyint] NULL,
	[PROJE] [tinyint] NULL,
	[ORTALAMA] [decimal](5, 2) NULL,
	[DURUM] [varchar](5) NULL,
 CONSTRAINT [PK_Table_Notlar] PRIMARY KEY CLUSTERED 
(
	[NOTID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_Öğrenci]    Script Date: 7.06.2023 19:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Öğrenci](
	[OGRİD] [int] IDENTITY(1,1) NOT NULL,
	[OGRİSİM] [varchar](20) NULL,
	[OGRSOYAD] [varchar](20) NULL,
	[OGRKULUP] [tinyint] NULL,
	[OGRCINSIYET] [varchar](5) NULL,
 CONSTRAINT [PK_Table_Öğrenci] PRIMARY KEY CLUSTERED 
(
	[OGRİD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_Öğretmen]    Script Date: 7.06.2023 19:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Öğretmen](
	[OGRTID] [tinyint] IDENTITY(1,1) NOT NULL,
	[OGRTBRANS] [tinyint] NULL,
	[OGRTAD] [varchar](20) NULL,
	[OGRTSOYAD] [varchar](20) NULL,
 CONSTRAINT [PK_Table_Öğretmen] PRIMARY KEY CLUSTERED 
(
	[OGRTID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Table_Ders] ON 

INSERT [dbo].[Table_Ders] ([DERSİD], [DERSAD]) VALUES (1, N'Matematik')
INSERT [dbo].[Table_Ders] ([DERSİD], [DERSAD]) VALUES (5, N'EE')
SET IDENTITY_INSERT [dbo].[Table_Ders] OFF
GO
SET IDENTITY_INSERT [dbo].[Table_Kulüp] ON 

INSERT [dbo].[Table_Kulüp] ([KULUPİD], [KULUPAD]) VALUES (1, N'MATEMATİK')
INSERT [dbo].[Table_Kulüp] ([KULUPİD], [KULUPAD]) VALUES (7, N'KÜTÜPHANE')
INSERT [dbo].[Table_Kulüp] ([KULUPİD], [KULUPAD]) VALUES (8, N'SPOR')
SET IDENTITY_INSERT [dbo].[Table_Kulüp] OFF
GO
SET IDENTITY_INSERT [dbo].[Table_Notlar] ON 

INSERT [dbo].[Table_Notlar] ([NOTID], [DERSİD], [OGRİD], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (1, 1, 1, 3, 22, 22, 22, NULL, N'Geçti')
INSERT [dbo].[Table_Notlar] ([NOTID], [DERSİD], [OGRİD], [SINAV1], [SINAV2], [SINAV3], [PROJE], [ORTALAMA], [DURUM]) VALUES (6, 5, 8, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Table_Notlar] OFF
GO
SET IDENTITY_INSERT [dbo].[Table_Öğrenci] ON 

INSERT [dbo].[Table_Öğrenci] ([OGRİD], [OGRİSİM], [OGRSOYAD], [OGRKULUP], [OGRCINSIYET]) VALUES (1, N'Mert', N'Salih', 1, N'Erkek')
INSERT [dbo].[Table_Öğrenci] ([OGRİD], [OGRİSİM], [OGRSOYAD], [OGRKULUP], [OGRCINSIYET]) VALUES (8, N'FSDF', N'SF', 7, N'Erkek')
INSERT [dbo].[Table_Öğrenci] ([OGRİD], [OGRİSİM], [OGRSOYAD], [OGRKULUP], [OGRCINSIYET]) VALUES (9, N'ALİ', N'SF', 1, N'')
SET IDENTITY_INSERT [dbo].[Table_Öğrenci] OFF
GO
ALTER TABLE [dbo].[Table_Notlar]  WITH CHECK ADD  CONSTRAINT [FK_Table_Notlar_Table_Ders] FOREIGN KEY([DERSİD])
REFERENCES [dbo].[Table_Ders] ([DERSİD])
GO
ALTER TABLE [dbo].[Table_Notlar] CHECK CONSTRAINT [FK_Table_Notlar_Table_Ders]
GO
ALTER TABLE [dbo].[Table_Notlar]  WITH CHECK ADD  CONSTRAINT [FK_Table_Notlar_Table_Öğrenci] FOREIGN KEY([OGRİD])
REFERENCES [dbo].[Table_Öğrenci] ([OGRİD])
GO
ALTER TABLE [dbo].[Table_Notlar] CHECK CONSTRAINT [FK_Table_Notlar_Table_Öğrenci]
GO
ALTER TABLE [dbo].[Table_Öğrenci]  WITH CHECK ADD  CONSTRAINT [FK_Table_Öğrenci_Table_Kulüp] FOREIGN KEY([OGRKULUP])
REFERENCES [dbo].[Table_Kulüp] ([KULUPİD])
GO
ALTER TABLE [dbo].[Table_Öğrenci] CHECK CONSTRAINT [FK_Table_Öğrenci_Table_Kulüp]
GO
ALTER TABLE [dbo].[Table_Öğretmen]  WITH CHECK ADD  CONSTRAINT [FK_Table_Öğretmen_Table_Ders] FOREIGN KEY([OGRTBRANS])
REFERENCES [dbo].[Table_Ders] ([DERSİD])
GO
ALTER TABLE [dbo].[Table_Öğretmen] CHECK CONSTRAINT [FK_Table_Öğretmen_Table_Ders]
GO
