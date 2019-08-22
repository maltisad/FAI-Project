
CREATE Procedure [dbo].[PunetoriProduktiDeleteRow]
@PPID int
AS
BEGIN
DELETE PunetoriProdukti WHERE [PPID] = @PPID
END
GO


USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[PunetoriProduktiInsertRow]    Script Date: 28.05.2019 23:59:12 ******/
SET ANSI_NULLS L
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[PunetoriProduktiInsertRow]
@PunetoriID int,
@ProduktiID int,
@DataPP date
AS
BEGIN
    INSERT INTO PunetoriProdukti
        ([PunetoriID], [ProduktiID],  [DataPP])
    VALUES
        (@PunetoriID, @ProduktiID, @DataPP )
END
GO

USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[PunetoriProduktiSelectAll]    Script Date: 28.05.2019 23:59:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[PunetoriProduktiSelectAll]
AS
BEGIN
SELECT * FROM PunetoriProdukti
END
GO

USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[PunetoriProduktiSelectRow]    Script Date: 29.05.2019 00:00:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[PunetoriProduktiSelectRow]
@PPID int
AS
BEGIN
SELECT * FROM PunetoriProdukti p
WHERE [PPID]=@PPID
END
GO

USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[PunetoriProduktiUpdateRow]    Script Date: 29.05.2019 00:00:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[PunetoriProduktiUpdateRow]
@PPID int,
@PunetoriID int,
@ProduktiID int,
@DataPP date

AS
BEGIN
UPDATE PunetoriProdukti SET 
[PunetoriID] = @PunetoriID,
[ProduktiID] = @ProduktiID,
[DataPP] = @DataPP
WHERE [PPID] = @PPID
END
GO


CREATE Procedure [dbo].[PunetoriProdukti1InsertRow]
@PunetoriID varchar(50),
@ProduktiID varchar(50),
@DataPP date
AS
BEGIN
    INSERT INTO PunetoriProdukti
        ([PunetoriID], [ProduktiID],  [DataPP])
    VALUES
        (@PunetoriID, @ProduktiID, @DataPP )
END
GO

