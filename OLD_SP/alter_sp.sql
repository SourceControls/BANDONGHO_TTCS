USE [BANDONGHO_TTCS]
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_ct_pd]    Script Date: 6/6/2022 4:18:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER proc [dbo].[sp_lay_ct_pd] @MAPD nchar(10)
as
select TENDONGHO, SOLUONG, DONGIA, THANHTIEN=SOLUONG*DONGIA,HINHANH
from (
	select MAPHIEUDAT
	from PHIEUDAT
	where MAPHIEUDAT=@MAPD AND TRANGTHAI <> N'Ðã huỷ'
) PD inner join CT_PD on PD.MAPHIEUDAT = CT_PD.MAPHIEUDAT
	inner join (select MADONGHO, TENDONGHO,HINHANH from DONGHO) DH on DH.MADONGHO = CT_PD.MADONGHO