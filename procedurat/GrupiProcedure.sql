USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[GrupiDeleteRow]    Script Date: 28.05.2019 23:49:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[GrupiDeleteRow]
@GrupiID int
AS
BEGIN
DELETE Grupi WHERE [GrupiID] = @GrupiID
END
GO


USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[GrupiInsertRow]    Script Date: 28.05.2019 23:59:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[GrupiInsertRow]
@Grupi varchar(50),
@KategoriaID int
AS
BEGIN
    INSERT INTO Grupi
        ([Grupi], [KategoriaID])
    VALUES
        (@Grupi,  @KategoriaID)
END
GO

USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[GrupiSelectAll]    Script Date: 28.05.2019 23:59:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[GrupiSelectAll]
AS
BEGIN
SELECT * FROM Grupi
END
GO

USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[GrupiSelectRow]    Script Date: 29.05.2019 00:00:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[GrupiSelectRow]
@GrupiID int
AS
BEGIN
SELECT * FROM Grupi p
WHERE [GrupiID]=@GrupiID
END
GO

USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[GrupiUpdateRow]    Script Date: 29.05.2019 00:00:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[GrupiUpdateRow]
@GrupiID int,
@Grupi varchar(50),
@KategoriaID int
AS
BEGIN
UPDATE Grupi SET 
[Grupi] = @Grupi,
[KategoriaID] = @KategoriaID
WHERE [GrupiID] = @GrupiID
END
GO

