IF NOT EXISTS(SELECT TOP 1 1 FROM sys.columns WHERE object_id = OBJECT_ID('HairShop') AND [name] = N'HairCutPrice')
BEGIN
	ALTER TABLE HairShop ADD HairCutPrice money
END
GO
IF NOT EXISTS(SELECT TOP 1 1 FROM sys.columns WHERE object_id = OBJECT_ID('HairShop') AND [name] = N'HairCutDiscount')
BEGIN
	ALTER TABLE HairShop ADD HairCutDiscount money
END
GO
IF NOT EXISTS(SELECT TOP 1 1 FROM sys.columns WHERE object_id = OBJECT_ID('HairShop') AND [name] = N'HairMarcelPrice')
BEGIN
	ALTER TABLE HairShop ADD HairMarcelPrice money
END
GO
IF NOT EXISTS(SELECT TOP 1 1 FROM sys.columns WHERE object_id = OBJECT_ID('HairShop') AND [name] = N'HairMarcelDiscount')
BEGIN
	ALTER TABLE HairShop ADD HairMarcelDiscount money
END
GO
IF NOT EXISTS(SELECT TOP 1 1 FROM sys.columns WHERE object_id = OBJECT_ID('HairShop') AND [name] = N'HairDyePrice')
BEGIN
	ALTER TABLE HairShop ADD HairDyePrice money
END
GO
IF NOT EXISTS(SELECT TOP 1 1 FROM sys.columns WHERE object_id = OBJECT_ID('HairShop') AND [name] = N'HairDyeDiscount')
BEGIN
	ALTER TABLE HairShop ADD HairDyeDiscount money
END
GO
IF NOT EXISTS(SELECT TOP 1 1 FROM sys.columns WHERE object_id = OBJECT_ID('HairShop') AND [name] = N'HairShapePrice')
BEGIN
	ALTER TABLE HairShop ADD HairShapePrice money
END
GO
IF NOT EXISTS(SELECT TOP 1 1 FROM sys.columns WHERE object_id = OBJECT_ID('HairShop') AND [name] = N'HairShapeDiscount')
BEGIN
	ALTER TABLE HairShop ADD HairShapeDiscount money
END
GO
IF NOT EXISTS(SELECT TOP 1 1 FROM sys.columns WHERE object_id = OBJECT_ID('HairShop') AND [name] = N'HairConservationPrice')
BEGIN
	ALTER TABLE HairShop ADD HairConservationPrice money
END
GO
IF NOT EXISTS(SELECT TOP 1 1 FROM sys.columns WHERE object_id = OBJECT_ID('HairShop') AND [name] = N'HairConservationDiscount')
BEGIN
	ALTER TABLE HairShop ADD HairConservationDiscount money
END
GO
IF NOT EXISTS(SELECT TOP 1 1 FROM sys.columns WHERE object_id = OBJECT_ID('HairShop') AND [name] = N'LocationMapURL')
BEGIN
	ALTER TABLE HairShop ADD LocationMapURL varchar(1024)
END
GO
IF NOT EXISTS(SELECT TOP 1 1 FROM sys.columns WHERE object_id = OBJECT_ID('HairShop') AND [name] = N'IsServeMarcel')
BEGIN
	ALTER TABLE HairShop ADD IsServeMarcel bit
END
GO
IF NOT EXISTS(SELECT TOP 1 1 FROM sys.columns WHERE object_id = OBJECT_ID('HairShop') AND [name] = N'IsServeDye')
BEGIN
	ALTER TABLE HairShop ADD IsServeDye bit
END
GO
IF NOT EXISTS(SELECT TOP 1 1 FROM sys.columns WHERE object_id = OBJECT_ID('HairShop') AND [name] = N'IsServeHairCut')
BEGIN
	ALTER TABLE HairShop ADD IsServeHairCut bit
END
GO
IF NOT EXISTS(SELECT TOP 1 1 FROM sys.columns WHERE object_id = OBJECT_ID('HairShop') AND [name] = N'Square')
BEGIN
	ALTER TABLE HairShop ADD [Square] varchar(64)
END
GO
IF NOT EXISTS(SELECT TOP 1 1 FROM sys.columns WHERE object_id = OBJECT_ID('HairEngineer') AND [name] = N'HairEngineerConstellation')
BEGIN
	ALTER TABLE HairEngineer ADD HairEngineerConstellation varchar(64)
END
GO