USE [QLVT]
GO
/****** Object:  Table [dbo].[DatHang]    Script Date: 12/23/2018 5:05:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatHang](
	[MasoDDH] [nchar](8) NOT NULL CONSTRAINT [DF_DatHang_MasoDDH]  DEFAULT (getdate()),
	[NGAY] [date] NOT NULL CONSTRAINT [DF_DatHang_NGAY]  DEFAULT (getdate()),
	[NhaCC] [nvarchar](100) NOT NULL,
	[MANV] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_A030B5CC112449C6B4A91DD9AC4691A2]  DEFAULT (newsequentialid()),
	[MAKHO] [nchar](4) NULL,
 CONSTRAINT [PK_DatHang] PRIMARY KEY CLUSTERED 
(
	[MasoDDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[DatHang]  WITH CHECK ADD  CONSTRAINT [FK_DatHang_Kho] FOREIGN KEY([MAKHO])
REFERENCES [dbo].[Kho] ([MAKHO])
GO
ALTER TABLE [dbo].[DatHang] CHECK CONSTRAINT [FK_DatHang_Kho]
GO
ALTER TABLE [dbo].[DatHang]  WITH NOCHECK ADD  CONSTRAINT [FK_DatHang_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[DatHang] CHECK CONSTRAINT [FK_DatHang_NhanVien]
GO
