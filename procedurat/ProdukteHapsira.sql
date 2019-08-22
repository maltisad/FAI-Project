
CREATE Procedure [dbo].[ProdukteHapsiraDeleteRow]
@PdID int
AS
BEGIN
DELETE ProdukteHapsira WHERE [PdID] = @PdID
END
GO


USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[ProdukteHapsiraInsertRow]    Script Date: 28.05.2019 23:59:12 ******/
SET ANSI_NULLS L
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[ProdukteHapsiraInsertRow]
@HapsiraID int,
@ProduktiID int,
@DataPH date
AS
BEGIN
    INSERT INTO ProdukteHapsira
        ([HapsiraID], [ProduktiID],  [DataPH])
    VALUES
        (@HapsiraID, @ProduktiID, @DataPH )
END
GO

USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[ProdukteHapsiraSelectAll]    Script Date: 28.05.2019 23:59:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[ProdukteHapsiraSelectAll]
AS
BEGIN
SELECT * FROM ProdukteHapsira
END
GO

USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[ProdukteHapsiraSelectRow]    Script Date: 29.05.2019 00:00:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[ProdukteHapsiraSelectRow]
@PdID int
AS
BEGIN
SELECT * FROM ProdukteHapsira p
WHERE [PdID]=@PdID
END
GO

USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[ProdukteHapsiraUpdateRow]    Script Date: 29.05.2019 00:00:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[ProdukteHapsiraUpdateRow]
@PdID int,
@HapsiraID int,
@ProduktiID int,
@DataPH date

AS
BEGIN
UPDATE ProdukteHapsira SET 
[HapsiraID] = @HapsiraID,
[ProduktiID] = @ProduktiID,
[DataPH] = @DataPH
WHERE [PdID] = @PdID
END
GO


CREATE Procedure [dbo].[ProdukteHapsira1InsertRow]
@HapsiraID varchar(50),
@ProduktiID varchar(50),
@DataPH date
AS
BEGIN
    INSERT INTO ProdukteHapsira
        ([HapsiraID], [ProduktiID],  [DataPH])
    VALUES
        (@HapsiraID, @ProduktiID, @DataPH )
END
GO

