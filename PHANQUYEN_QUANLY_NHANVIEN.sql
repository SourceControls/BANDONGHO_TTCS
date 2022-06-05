﻿USE BANDONGHO_TTCS

create proc [dbo].[SP_XOA_TAI_KHOAN]
@MANV VARCHAR(10)
AS
BEGIN
	EXEC('DROP LOGIN '+ @MANV)
	EXEC('DROP SCHEMA ' + @MANV)
	EXEC('DROP USER ' + @MANV)
END

GO

CREATE PROC [dbo].[SP_LAY_HO_TEN_VA_GROUP]
@MANV NCHAR(10)
AS
SELECT dbo.F_GET_GROUP_FROM_LOGIN_NAME(@MANV) AS 'GROUP',HOTEN = (SELECT HOTEN = HO+ ' ' +TEN FROM NHANVIEN WHERE MANV =@MANV)
GO



CREATE PROC [dbo].[SP_KHOA_HOAC_MO_KHOA_TAI_KHOAN]
@MANV varchar(10)
AS
BEGIN
IF NOT EXISTS (SELECT * FROM SYS.syslogins WHERE loginname = @MANV)
  begin
	raiserror(N'Nhân viên không có tài khoản',16,1)
	return
  end

else
 begin
 	IF((SELECT is_disabled FROM SYS.sql_logins WHERE name = @MANV) = 'FALSE')
	BEGIN
	EXEC('ALTER LOGIN '+ @MANV + ' DISABLE')
	select 1 --KHÓA TÀI KHOẢN
	return
	END
	IF((SELECT is_disabled FROM SYS.sql_logins WHERE name = @MANV) = 'TRUE')
	BEGIN
	EXEC('ALTER LOGIN '+ @MANV + ' ENABLE')
	select 2 --MỞ KHÓA TÀI KHOẢN
	return
	END
 end
END
GO

CREATE PROC [dbo].[SP_CAP_TAI_KHOAN]
@MANV varchar(10)
AS
BEGIN
IF EXISTS (SELECT * FROM SYS.syslogins WHERE loginname = @MANV)
  begin
	raiserror(N'Nhân viên đã có tài khoản',16,1)
	return
  end
else
 begin
    exec sp_addlogin @loginame =@manv,@passwd = @manv,@defdb = 'BANDONGHO_TTCS' --login,pass,db_name
	if exists(select loginname from sys.syslogins where loginname = @MANV)
	begin
	exec('alter server role securityadmin add member '+ @manv )
	exec ('create user ' + @manv)
	exec ('alter role NHANVIEN add member ' + @manv) 
	end
 end
END
GO
CREATE PROC [dbo].[SP_CAP_HOAC_THU_HOI_QUYEN_QUAN_LY] 
@MANV NCHAR(10)
AS
BEGIN
IF NOT EXISTS(SELECT loginname from SYS.SYSLOGINS where loginname = @MANV)
	BEGIN
	RAISERROR(N'NHÂN VIÊN CHƯA CÓ TÀI KHOẢN', 16,1)
	RETURN
	END
IF((SELECT is_disabled FROM SYS.sql_logins WHERE name = @MANV) = 'TRUE')
	BEGIN
	RAISERROR(N'TÀI KHOẢN CỦA NHÂN VIÊN ĐANG BỊ KHÓA', 16,1)
	RETURN
	END

IF((SELECT DBO.F_GET_GROUP_FROM_LOGIN_NAME(@MANV)) = 'NHANVIEN')
	BEGIN
	
	EXEC ('ALTER ROLE NHANVIEN DROP MEMBER ' + @MANV)
	EXEC ('ALTER ROLE QUANLY ADD MEMBER ' + @MANV)
	EXEC ('ALTER SERVER ROLE SECURITYADMIN ADD MEMBER ' + @MANV)
	select 1 --CẤP QUYỀN QUẢN LÝ
	return
	END
IF((SELECT DBO.F_GET_GROUP_FROM_LOGIN_NAME(@MANV)) = 'QUANLY')
	BEGIN
	
	EXEC ('ALTER ROLE QUANLY DROP MEMBER ' + @MANV)
	EXEC ('ALTER ROLE NHANVIEN ADD MEMBER ' + @MANV)
	EXEC ('ALTER SERVER ROLE SECURITYADMIN DROP MEMBER ' + @MANV)
	select 2 --THU HỒI QUYỀN QUẢN LÝ
	return
	END
select -1
END
GO

CREATE ROLE QUANLY
ALTER ROLE DB_OWNER ADD MEMBER QUANLY
CREATE ROLE NHANVIEN
ALTER ROLE DB_DATAREADER ADD MEMBER NHANVIEN
ALTER ROLE DB_DATAWRITER ADD MEMBER NHANVIEN
--
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [GIOITINH], [NGAYSINH], [DIACHI], [SDT], [EMAIL]) VALUES (N'TTCSNV01  ', N'NGUYỄN VĂN QUẢN', N'LÝ', 0, CAST(N'1990-01-01' AS Date), N'Tp.Thủ Đức', N'0973343544', N'quanly01@gmai.com')
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [GIOITINH], [NGAYSINH], [DIACHI], [SDT], [EMAIL]) VALUES (N'TTCSNV02  ', N'PHẠM THỊ', N'NHÂN VIÊN', 1, CAST(N'2001-01-01' AS Date), N'Tp.Thủ Đức', N'0973343999', N'nhanvien02@gmai.com')
EXEC SP_CAP_TAI_KHOAN 'TTCSNV01'
EXEC SP_CAP_TAI_KHOAN 'TTCSNV02'
EXEC SP_CAP_HOAC_THU_HOI_QUYEN_QUAN_LY 'TTCSNV01'
--
GO