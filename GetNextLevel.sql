USE [Harvest2]
GO
/****** Object:  StoredProcedure [dbo].[GetNextLevel]    Script Date: 04/18/2017 14:24:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[GetNextLevel]
	@No        nvarchar(20),
	@SalesNo   nvarchar(20),
	@Grade     int,
	@PartCount numeric(11,2)
AS

BEGIN
	DECLARE @TmpGrade      int;
	DECLARE @TmpPartCount  numeric(11,2);

	DECLARE @NextLevel     nvarchar(20);
	DECLARE @Number        numeric(11,2);
	DECLARE @Level         int;

	DECLARE @NextLevelName nvarchar(50);
	DECLARE @SheetName     nvarchar(6);
	DECLARE @TypeName      nvarchar(6);
	DECLARE @ImportantName nvarchar(6);
	DECLARE @OwnerName     nvarchar(20);
	DECLARE @ValidDate     datetime;
	DECLARE @Remark        nvarchar(60);

	--开游标寻找下一级
	DECLARE cRow CURSOR LOCAL FOR
		SELECT ChildNo,Number,Groups,Remark FROM Assemble WHERE PartNo=@No;

	--每迭代一次层级+1
	SELECT @TmpGrade = @Grade + 1;
	SELECT @TmpPartCount = @PartCount;
	--IF @TmpGrade = 1
	--	SELECT @PartCount = 1

	OPEN cRow
	FETCH NEXT FROM cRow INTO @NextLevel,@Number,@Level,@Remark
	WHILE @@FETCH_STATUS = 0
	BEGIN
		--组合件继续寻找下一级
		IF @NextLevel LIKE 'AYT%'
		BEGIN
			SELECT @NextLevelName=PartName,@SheetName=SheetName,@TypeName=TypeName,@ImportantName=ImportantName,@OwnerName=CnName,@ValidDate=ValidDate FROM Part A,Sheet S,Type T,Important I,Sysuser O
            WHERE PartNo=@NextLevel AND A.SheetNo=S.SheetNo AND A.TypeNo=T.TypeNo AND A.ImportantNo=I.ImportantNo AND A.UserNo=O.UserNo;

			SELECT @TmpPartCount = @PartCount*@Number
			--插入大表
			INSERT INTO TempTable
            (No,AssembleNo,NextLevel,NextLevelName,SheetName,Number,TypeName,Level,ImportantName,OwnerName,ValidDate,Remark,PartCount,SalesNo)
            VALUES
            (@TmpGrade,@No,@NextLevel,@NextLevelName,@SheetName,@Number,@TypeName,@Level,@ImportantName,@OwnerName,@ValidDate,@Remark,@TmpPartCount,@SalesNo);

			--迭代计算
			EXEC GetNextLevel @NextLevel,@SalesNo,@TmpGrade,@TmpPartCount

		END
		ELSE
      --单件写入
		BEGIN
			SELECT @NextLevelName=PartName,@SheetName=SheetName,@TypeName=TypeName,@ImportantName=ImportantName,@OwnerName=CnName,@ValidDate=ValidDate FROM Part A,Sheet S,Type T,Important I,Sysuser O
            WHERE PartNo=@NextLevel AND A.SheetNo=S.SheetNo AND A.TypeNo=T.TypeNo AND A.ImportantNo=I.ImportantNo AND A.UserNo=O.UserNo;


			SELECT @TmpPartCount = @PartCount*@Number

			INSERT INTO TempTable
            (No,AssembleNo,NextLevel,NextLevelName,SheetName,Number,TypeName,Level,ImportantName,OwnerName,ValidDate,Remark,PartCount,SalesNo)
             VALUES
            (@TmpGrade,@No,@NextLevel,@NextLevelName,@SheetName,@Number,@TypeName,@Level,@ImportantName,@OwnerName,@ValidDate,@Remark,@TmpPartCount,@SalesNo);
		END
		FETCH NEXT FROM cRow INTO @NextLevel,@Number,@Level,@Remark
	END

	CLOSE cRow
	DEALLOCATE cRow
END
