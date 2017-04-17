USE [Harvest2]
GO
/****** Object:  StoredProcedure [dbo].[GetNextLevelVirtual]    Script Date: 04/17/2017 22:24:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROC [dbo].[GetNextLevelVirtual]
	@No nvarchar(20),
	@Grade int,
    @PartCount int
AS

BEGIN
  DECLARE @TmpGrade int = 1;
  DECLARE @TmpPartCount int = 1;


  DECLARE @NextLevel nvarchar(20);
  DECLARE @Number int;
  DECLARE @Level int;
  
  DECLARE @NextLevelName nvarchar(50);
  DECLARE @SheetName     nvarchar(20);
  DECLARE @TypeName      nvarchar(20);
  DECLARE @ImportantName nvarchar(20);
  DECLARE @OwnerName     nvarchar(10);
  DECLARE @ValidDate     datetime;
  DECLARE @Remark        nvarchar(50);
  
  --开游标寻找下一级
  DECLARE cRow CURSOR LOCAL FOR
        SELECT ChildNo,Number,Groups,Remark FROM Assemble WHERE PartNo=@No;

  SELECT @TmpGrade = @Grade + 1;
  SELECT @TmpPartCount = @PartCount;
  
  OPEN cRow
  FETCH NEXT FROM cRow INTO @NextLevel,@Number,@Level,@Remark 
  WHILE @@FETCH_STATUS = 0
	BEGIN
	  --组合件继续寻找下一级
	  IF @NextLevel LIKE 'AYT%'
	      BEGIN
            SELECT @NextLevelName=PartName,@SheetName=SheetName,@TypeName=TypeName,@ImportantName=ImportantName,@OwnerName=CnName,@ValidDate=ValidDate FROM Part A,Sheet S,Type T,Important I ,Sysuser O
            WHERE PartNo=@NextLevel AND A.SheetNo=S.SheetNo AND A.TypeNo=T.TypeNo AND A.ImportantNo=I.ImportantNo AND A.UserNo=O.UserNo;
		    
		    IF @TmpGrade = 1
		      SELECT @PartCount = 1
		    
		    SELECT @TmpPartCount = @PartCount*@Number
		    
		    INSERT INTO ##VirtualDown
	        (No,AssembleNo,NextLevel,NextLevelName,SheetName,Number,TypeName,Level,ImportantName,OwnerName,ValidDate,Remark,PartCount)
            VALUES
            (@TmpGrade,@No,@NextLevel,@NextLevelName,@SheetName,@Number,@TypeName,@Level,@ImportantName,@OwnerName,@ValidDate,@Remark,@TmpPartCount);	

			EXEC GetNextLevelVirtual @NextLevel,@TmpGrade,@TmpPartCount

	      END
      ELSE
      --单件写入
          BEGIN
              SELECT @NextLevelName=PartName,@SheetName=SheetName,@TypeName=TypeName,@ImportantName=ImportantName,@OwnerName=CnName,@ValidDate=ValidDate FROM Part A,Sheet S,Type T,Important I ,Sysuser O
              WHERE PartNo=@NextLevel AND A.SheetNo=S.SheetNo AND A.TypeNo=T.TypeNo AND A.ImportantNo=I.ImportantNo AND A.UserNo=O.UserNo;

		      IF @TmpGrade = 1
		        SELECT @PartCount = 1

              SELECT @TmpPartCount = @PartCount*@Number
              
	          INSERT INTO ##VirtualDown
	          (No,AssembleNo,NextLevel,NextLevelName,SheetName,Number,TypeName,Level,ImportantName,OwnerName,ValidDate,Remark,PartCount)
              VALUES
              (@TmpGrade,@No,@NextLevel,@NextLevelName,@SheetName,@Number,@TypeName,@Level,@ImportantName,@OwnerName,@ValidDate,@Remark,@TmpPartCount);		    
		  END
	  FETCH NEXT FROM cRow INTO @NextLevel,@Number,@Level,@Remark 	
    END

    CLOSE cRow
    DEALLOCATE cRow
END