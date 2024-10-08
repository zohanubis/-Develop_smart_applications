USE [QLSINHVIEN]
GO
/****** Object:  Table [dbo].[Diem]    Script Date: 08/10/2024 12:36:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Diem](
	[MaSinhVien] [varchar](50) NOT NULL,
	[MaMonHoc] [varchar](50) NOT NULL,
	[Diem] [float] NULL,
 CONSTRAINT [PK_Diem] PRIMARY KEY CLUSTERED 
(
	[MaSinhVien] ASC,
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 08/10/2024 12:36:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [varchar](50) NOT NULL,
	[TenKhoa] [nvarchar](100) NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 08/10/2024 12:36:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [varchar](50) NOT NULL,
	[TenLop] [nvarchar](100) NULL,
	[MaKhoa] [varchar](50) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 08/10/2024 12:36:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMonHoc] [varchar](50) NOT NULL,
	[TenMonHoc] [nvarchar](100) NULL,
 CONSTRAINT [PK_MonhHoc] PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 08/10/2024 12:36:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSinhVien] [varchar](50) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[NgaySinh] [datetime] NULL,
	[MaLop] [varchar](50) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'CNSH', N'Sinh hoc')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'CNTP', N'Cong nghe thuc pham')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'CNTT', N'Cong nghe thong tin')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'HH', N'Hoa Hoc')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'12DHHH1', N'12DHHH1', N'HH')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'12DHHH2', N'12DHHH2', N'HH')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'12DHTH1', N'12DHTH1', N'CNTT')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'12DHTH2', N'12DHTH2', N'CNTT')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'12DHTP1', N'12DHTP1', N'CNTP')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'12DHTP2', N'12DHTP2', N'CNTP')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'AI', N'AI')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'HDT', N'HDT')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'KT', N'KT')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'PTPM', N'PTPM')
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_MonHoc] FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MonHoc] ([MaMonHoc])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_MonHoc]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_SinhVien] FOREIGN KEY([MaSinhVien])
REFERENCES [dbo].[SinhVien] ([MaSinhVien])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_SinhVien]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_Khoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_Khoa]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Lop]
GO
