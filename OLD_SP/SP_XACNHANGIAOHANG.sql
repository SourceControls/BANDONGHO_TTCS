USE [BANDONGHO_TTCS]
GO
/****** Object:  StoredProcedure [dbo].[SP_XACNHANGIAOHANG]    Script Date: 08-Jun-22 12:20:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[SP_XACNHANGIAOHANG]
@MAPHIEUDAT INT, @MANV NCHAR(10)
AS
UPDATE PHIEUDAT
SET TRANGTHAI=N'Hoàn tất', MANV=@MANV, NGAYGIAO=GETDATE()
WHERE MAPHIEUDAT=@MAPHIEUDAT