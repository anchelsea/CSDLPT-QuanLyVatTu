USE [QLVT]
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateVatTu]    Script Date: 12/23/2018 5:05:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpdateVatTu]
@MAVT NCHAR(4), 
@SOLUONG INT , 
@State NVARCHAR(10)
AS
BEGIN
	BEGIN TRY
		IF(@State = 'INCREASE')
		BEGIN
			UPDATE dbo.Vattu SET SOLUONGTON += @SOLUONG
			WHERE MAVT = @MAVT
			RETURN 1	--Thành công
		END
		ELSE IF(@State = 'DECREASE')
		BEGIN
			UPDATE dbo.Vattu SET SOLUONGTON -= @SOLUONG
			WHERE MAVT = @MAVT
			RETURN 1	--Thành công
		END
		END TRY
	BEGIN CATCH
		RETURN 0	--Thất bại
	END CATCH
END
GO
