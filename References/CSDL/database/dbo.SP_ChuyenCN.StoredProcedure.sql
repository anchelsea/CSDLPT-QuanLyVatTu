USE [QLVT]
GO
/****** Object:  StoredProcedure [dbo].[SP_ChuyenCN]    Script Date: 12/23/2018 5:05:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- -1: Thất Bại								-2: Cho biết >= 1 Nhân viên trùng
--	0: Thành công khi tạo Mã NV mới			
CREATE PROCEDURE [dbo].[SP_ChuyenCN]
@MANV INT, @NEWID INT
AS
BEGIN
--Vì name của bảng tạm SQL sẽ định danh lại tên bảng tạm(tên user đặt + physical address)
--nên nếu dùng OBJECT_ID sẽ không tìm được nên ở đây ta dùng LIKE và %(bỏ qua hậu tố physical address)
IF EXISTS(SELECT *FROM tempdb.sys.tables		
			WHERE name LIKE '#NhanVienTemp%') DROP TABLE #NhanVienTemp

--Giải quyết vấn đề Nhân viên chuyển đi xong rồi lại chuyển về thì phải ghi đè lên lại chứ không tạo mới MANV
SELECT HO, TEN, NGAYSINH 
INTO #NhanVienTemp	--Bảng tạm chứa 3 trường ở Server hiện tại để dò với các record Server khác
FROM dbo.NhanVien
WHERE MANV = @MANV

IF EXISTS(
	SELECT NV1.*
	FROM LINK.QLVT.dbo.NhanVien AS NV1
	INNER JOIN #NhanVienTemp AS NV2 
	ON NV1.HO = NV2.HO 
	AND NV2.TEN = NV1.TEN 
	AND NV2.NGAYSINH = NV1.NGAYSINH
	WHERE NV1.TrangThaiXoa = 1
)
BEGIN
	RETURN -2
END
ELSE
BEGIN
	DECLARE @RET INT
	EXEC @RET= SP_NewChuyenCN @MANV, @NEWID
	IF (@RET = 0)   -- Thành công
	BEGIN
		EXEC @RET = SP_DeleteLogin @MANV
		IF(@RET = 1) RETURN -3	--Xóa Login không thành công
		IF(@RET = 2) RETURN -4	--Xóa User không thành công
		RETURN 0	--Thành công
	END
	 
     RETURN 0
	IF (@RET = -1)  -- Thất bại
     RETURN -1
END

END
GO
