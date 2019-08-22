USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[VendoriDeleteRow]    Script Date: 28.05.2019 23:49:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[VendoriDeleteRow]
@VendoriID int
AS
BEGIN
DELETE Vendori WHERE [VendoriID] = @VendoriID
END
GO


USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[VendoriInsertRow]    Script Date: 28.05.2019 23:59:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[VendoriInsertRow]
@Emri varchar(50),
@Lokacioni varchar(250),
@NrKontaktues int,
@BankAccount int
AS
BEGIN
    INSERT INTO Vendori
        ([Emri], [Lokacioni],  [NrKontaktues], [BankAccount])
    VALUES
        (@Emri, @Lokacioni, @NrKontaktues, @BankAccount)
END
GO

USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[VendoriSelectAll]    Script Date: 28.05.2019 23:59:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[VendoriSelectAll]
AS
BEGIN
SELECT * FROM Vendori
END
GO

USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[VendoriSelectRow]    Script Date: 29.05.2019 00:00:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[VendoriSelectRow]
@VendoriID int
AS
BEGIN
SELECT * FROM Vendori p
WHERE [VendoriID]=@VendoriID
END
GO

USE [FAI]
GO

/****** Object:  StoredProcedure [dbo].[VendoriUpdateRow]    Script Date: 29.05.2019 00:00:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[VendoriUpdateRow]
@VendoriID int,
@Emri varchar(50),
@Lokacioni varchar(250),
@NrKontaktues int,
@BankAccount int
AS
BEGIN
UPDATE Vendori SET 
[Emri] = @Emri,
[Lokacioni] = @Lokacioni,
[NrKontaktues] = @NrKontaktues,

[BankAccount] = @BankAccount
WHERE [VendoriID] = @VendoriID
END
GO

