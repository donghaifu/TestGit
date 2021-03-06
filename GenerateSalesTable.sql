USE [Harvest2]
GO
/****** Object:  StoredProcedure [dbo].[GenerateSalesTable]    Script Date: 09/27/2017 09:59:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROC [dbo].[GenerateSalesTable]
	@SalesNo nvarchar(20)
AS
BEGIN
	--迭代使用参数
	DECLARE @No        nvarchar(20);
	DECLARE @Grade     int = 0;
	DECLARE @PartCount numeric(11,2) = 1;

	--算总数使用参数
	DECLARE @NextLevel nvarchar(20);
	DECLARE @SumCount  numeric(11,2);

	--寻找最高级使用参数
	DECLARE @TopLevel  nvarchar(20);
	DECLARE @NoForTop  int;
	DECLARE @NaturalNoForTop    int;
	DECLARE @TempNo    nvarchar(20);

	--销售号作为大表的最后一个字段，在迭代的过程中为了防止改变，采用传入参数的方法
	SELECT @No=@SalesNo
	--传入参数为，件号，销售号，层级，数量
	EXEC GetNextLevel @No,@SalesNo,@Grade,@PartCount


	--把每一部分数相加到总数，以销售号为界
	DECLARE cSumRow CURSOR LOCAL FOR
		SELECT NextLevel,SUM(PartCount) AS TPartCount FROM TempTable WHERE SalesNo=@SalesNo GROUP BY NextLevel;

	OPEN cSumRow
	FETCH NEXT FROM cSumRow INTO @NextLevel,@SumCount
	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE TempTable
		SET SumCount=@SumCount
		WHERE NextLevel=@NextLevel
		AND SalesNo=@SalesNo;
    --AND @NextLevel NOT LIKE 'AYT%';

		FETCH NEXT FROM cSumRow INTO @NextLevel,@SumCount
	END

	--寻找最高级
	DECLARE cTopLevel CURSOR LOCAL FOR
		SELECT NaturalNo,No,NextLevel FROM TempTable WHERE SalesNo=@SalesNo;

	OPEN cTopLevel
	FETCH NEXT FROM cTopLevel INTO @NaturalNoForTop,@NoForTop,@NextLevel
	WHILE @@FETCH_STATUS = 0
	BEGIN
			WHILE @NoForTop != 1
			BEGIN
				SELECT @NaturalNoForTop = @NaturalNoForTop - 1;
				SELECT @NoForTop=No FROM TempTable WHERE NaturalNo=@NaturalNoForTop;
			END

			SELECT @TopLevel = NextLevel FROM TempTable WHERE NaturalNo=@NaturalNoForTop;

			UPDATE TempTable
			SET TopLevel=@TopLevel
			WHERE Current OF cTopLevel;

		FETCH NEXT FROM cTopLevel INTO @NaturalNoForTop,@NoForTop,@NextLevel
	END


  --DROP TABLE TempTable
	CLOSE cSumRow
	DEALLOCATE cSumRow
	CLOSE cTopLevel
	DEALLOCATE cTopLevel

END
