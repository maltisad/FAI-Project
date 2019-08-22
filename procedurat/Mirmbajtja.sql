
CREATE Procedure [dbo].[MirembajtjaDeleteRow]
@MirembajtjaID int
AS
BEGIN
DELETE Mirembajtja WHERE [MirembajtjaID] = @MirembajtjaID
END
GO


USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[MirembajtjaInsertRow]    Script Date: 28.05.2019 23:59:12 ******/
SET ANSI_NULLS L
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[MirembajtjaInsertRow]
@PunetoriID int,
@ProduktiID int,
@Pershkrimi varchar(500),
@DataMirmbajtjes date
AS
BEGIN
    INSERT INTO Mirembajtja
        ([PunetoriID], [ProduktiID], [Pershkrimi], [DataMirmbajtjes])
    VALUES
        (@PunetoriID, @ProduktiID,@Pershkrimi, @DataMirmbajtjes )
END
GO

USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[MirembajtjaSelectAll]    Script Date: 28.05.2019 23:59:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[MirembajtjaSelectAll]
AS
BEGIN
SELECT * FROM Mirembajtja
END
GO

USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[MirembajtjaSelectRow]    Script Date: 29.05.2019 00:00:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[MirembajtjaSelectRow]
@MirembajtjaID int
AS
BEGIN
SELECT * FROM Mirembajtja p
WHERE [MirembajtjaID]=@MirembajtjaID
END
GO

USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[MirembajtjaUpdateRow]    Script Date: 29.05.2019 00:00:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[MirembajtjaUpdateRow]
@MirembajtjaID int,
@PunetoriID int,
@ProduktiID int,
@Pershkrimi varchar(500),
@DataMirmbajtjes date

AS
BEGIN
UPDATE Mirembajtja SET 
[PunetoriID] = @PunetoriID,
[ProduktiID] = @ProduktiID,
[Pershkrimi] = @Pershkrimi,
[DataMirmbajtjes] = @DataMirmbajtjes
WHERE [MirembajtjaID] = @MirembajtjaID
END
GO


CREATE Procedure [dbo].[Mirembajtja1InsertRow]
@PunetoriID varchar(50),
@ProduktiID varchar(50),
@Pershkrimi varchar(500),
@DataMirmbajtjes date
AS
BEGIN
    INSERT INTO Mirembajtja
        ([PunetoriID], [ProduktiID], [Pershkrimi], [DataMirmbajtjes])
    VALUES
        (@PunetoriID, @ProduktiID,@Pershkrimi, @DataMirmbajtjes )
END
GO

