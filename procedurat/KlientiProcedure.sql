USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[KlientiDeleteRow]    Script Date: 28.05.2019 23:49:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[KlientiDeleteRow]
@KlientiID int
AS
BEGIN
DELETE Klienti WHERE [KlientiID] = @KlientiID
END
GO


USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[KlientiInsertRow]    Script Date: 28.05.2019 23:59:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[KlientiInsertRow]
@Emri varchar(50),
@Mbiemri varchar(250),
@NumriTelefonit int,
@Email varchar(20)
AS
BEGIN
    INSERT INTO Klienti
        ([Emri], [Mbiemri],  [NumriTelefonit], [Email])
    VALUES
        (@Emri, @Mbiemri, @NumriTelefonit, @Email)
END
GO

USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[KlientiSelectAll]    Script Date: 28.05.2019 23:59:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[KlientiSelectAll]
AS
BEGIN
SELECT * FROM Klienti
END
GO

USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[KlientiSelectRow]    Script Date: 29.05.2019 00:00:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[KlientiSelectRow]
@KlientiID int
AS
BEGIN
SELECT * FROM Klienti p
WHERE [KlientiID]=@KlientiID
END
GO

USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[KlientiUpdateRow]    Script Date: 29.05.2019 00:00:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[KlientiUpdateRow]
@KlientiID int,
@Emri varchar(50),
@Mbiemri varchar(250),
@NumriTelefonit int,
@Email varchar(20)
AS
BEGIN
UPDATE Klienti SET 
[Emri] = @Emri,
[Mbiemri] = @Mbiemri,
[NumriTelefonit] = @NumriTelefonit,

[Email] = @Email
WHERE [KlientiID] = @KlientiID
END
GO

