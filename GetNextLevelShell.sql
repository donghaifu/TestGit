USE [Harvest2]
GO
/****** Object:  StoredProcedure [dbo].[GetNextLevelShell]    Script Date: 04/17/2017 22:19:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROC [dbo].[GetNextLevelShell]
	@No nvarchar(20),--装配件号
	@SalesNo nvarchar(10),--目前无用
	@Type int --类型
AS
BEGIN
	DECLARE @LevelHigh nvarchar(2);

	DECLARE @PartCount int = 1;
	DECLARE @Grade int = 0;

	DECLARE @NextLevel  nvarchar(20);
	DECLARE @SumCount   int;

	DECLARE @TopLevel nvarchar(20);
	DECLARE @NoForTop int;
	DECLARE @NaturalNoForTop int;
	--DECLARE @TempNo nvarchar(20);

	--查找去向的类型为4
	IF @Type = 4
	BEGIN
		SELECT AssembleNo,NextLevel,NextLevelName AS 名称,TypeName AS 件型,Level,TopLevel,PartCount AS 数量,SumCount,SalesNo
		FROM TempTable
		WHERE NextLevel=@No
	END

	--从装配属性表中得到本装配号的最高级属性“是”还是“否”
	--SELECT @LevelHigh=LevelHigh FROM AssembleList WHERE AssembleNo = @No;
	--如果类似为10001则执行下面这些语句
	IF @No NOT LIKE 'AYT%'
	BEGIN
		--如果类型1，生成装配表
		IF @Type = 1
		BEGIN
			SELECT No AS 层级,NextLevel AS 件号,NextLevelName AS 名称,SheetName AS 图幅,Number AS 数量,TypeName AS 件型,
			Level AS 分组,ImportantName AS 重要度,OwnerName AS 设计,ValidDate AS 生效日期,Remark AS 备注
			FROM TempTable
			WHERE SalesNo = @No ORDER BY NaturalNo;
		END

		--如果类型2，生成生产用表
		IF @Type = 2
		BEGIN
			SELECT DISTINCT NextLevel AS 件号,NextLevelName AS 名称,SheetName AS 图幅,
			TypeName AS 件型,
			--Level AS 分组,
			ImportantName AS 重要度,OwnerName AS 设计,ValidDate AS 生效日期,
			--Remark AS 备注,
			SumCount AS 总数 FROM TempTable
			WHERE (TypeName = 'A件型' OR TypeName = 'P件型' OR TypeName = 'N件型') AND SalesNo = @No;
		END

		--如果类型3，生成采购用表
		IF @Type = 3
		BEGIN
			SELECT DISTINCT NextLevel AS 件号,NextLevelName AS 名称,SheetName AS 图幅,
			--Number AS 数量,
			TypeName AS 件型,
			--  Level AS 分组,
			ImportantName AS 重要度,OwnerName AS 设计,ValidDate AS 生效日期,
			--Remark AS 备注,
			SumCount AS 总数 FROM TempTable
			WHERE (TypeName = 'F件型' OR TypeName = 'N件型' ) AND SalesNo = @No;
		END

		--如果类型5，生成图纸管理表
		IF @Type = 5
		BEGIN
			SELECT DISTINCT NextLevel AS 文件编号,NextLevelName AS 文件名称,SheetName AS 图幅,OwnerName AS 设计
			FROM TempTable
			WHERE SheetName != 'Z'
		END


	END
	ELSE
	--如果类似为AYT10001则执行下面这些语句
	BEGIN

		IF OBJECT_ID('Tempdb..##VirtualDown') IS NOT NULL
		--IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[##VirtualDown]') AND type in (N'U'))
		DROP TABLE ##VirtualDown
		--DROP TABLE ##VirtualDown

		CREATE TABLE ##VirtualDown
		(
		NaturalNo     int           IDENTITY  NOT NULL,
		No            int           NOT NULL,/* */
		--SalesNo       nvarchar(10)  NOT NULL,
		AssembleNo    nvarchar(20)  NOT NULL,
		NextLevel     nvarchar(20)  NOT NULL,
		NextLevelName nvarchar(50)  NOT NULL,
		SheetName     nvarchar(20)  NOT NULL,
		Number        int           NOT NULL,
		TypeName      nvarchar(20) NOT NULL,
		Level         int           NOT NULL,
		ImportantName nvarchar(20)  NOT NULL,
		OwnerName     nvarchar(10)  NOT NULL,
		ValidDate     datetime      NOT NULL,
		Remark        nvarchar(50)  NULL,
		TopLevel      nvarchar(20)  NULL,
		PartCount     int           NULL,
		SumCount      int           NULL
		)

		EXEC GetNextLevelVirtual @No,@Grade,@PartCount

		--把每一部分数相加到总数
		DECLARE cSumRow CURSOR LOCAL FOR
		SELECT NextLevel,SUM(PartCount) AS TPartCount FROM ##VirtualDown GROUP BY NextLevel;

		OPEN cSumRow
		FETCH NEXT FROM cSumRow INTO @NextLevel,@SumCount 
		WHILE @@FETCH_STATUS = 0
		BEGIN
			UPDATE ##VirtualDown
			SET SumCount=@SumCount
			WHERE NextLevel=@NextLevel;
			-- AND @NextLevel NOT LIKE 'AYT%';
			FETCH NEXT FROM cSumRow INTO @NextLevel,@SumCount
		END

		--寻找最高级
		DECLARE cTopLevel CURSOR LOCAL FOR
		SELECT NaturalNo,No,NextLevel FROM ##VirtualDown; 
		OPEN cTopLevel
		FETCH NEXT FROM cTopLevel INTO @NaturalNoForTop,@NoForTop,@NextLevel
		WHILE @@FETCH_STATUS = 0
		BEGIN
			IF @NoForTop != 1
			BEGIN
				WHILE @NoForTop != 1
				BEGIN
					SELECT @NaturalNoForTop = @NaturalNoForTop - 1;
					SELECT @NoForTop=No FROM ##VirtualDown WHERE NaturalNo=@NaturalNoForTop;
				END

				SELECT @TopLevel = NextLevel FROM ##VirtualDown WHERE NaturalNo=@NaturalNoForTop;

				UPDATE ##VirtualDown
				SET TopLevel=@TopLevel
				WHERE Current OF cTopLevel;

			END
			ELSE
				UPDATE ##VirtualDown
				SET TopLevel=@SalesNo     --这里可能会有无关紧要的bug
				WHERE NextLevel=@NextLevel;

			FETCH NEXT FROM cTopLevel INTO @NaturalNoForTop,@NoForTop,@NextLevel
		END

		--如果类型1，生成装配表
		IF @Type = 1
		BEGIN
			SELECT No AS 层级,NextLevel AS 件号,NextLevelName AS 名称,SheetName AS 图幅,Number AS 数量,TypeName AS 件型,
			Level AS 分组,ImportantName AS 重要度,OwnerName AS 设计,ValidDate AS 生效日期,Remark AS 备注
			FROM ##VirtualDown
		END

		--如果类型2，生成生产用表
		IF @Type = 2
		BEGIN
			SELECT DISTINCT NextLevel AS 件号,NextLevelName AS 名称,SheetName AS 图幅,
			TypeName AS 件型,
			--Level AS 分组,
			ImportantName AS 重要度,OwnerName AS 设计,ValidDate AS 生效日期,
			--Remark AS 备注,
			SumCount AS 总数 FROM ##VirtualDown
			WHERE TypeName = 'A件型' OR TypeName = 'P件型' OR TypeName = 'N件型'
		END

		--如果类型3，生成采购用表
		IF @Type = 3
		BEGIN
			SELECT DISTINCT NextLevel AS 件号,NextLevelName AS 名称,SheetName AS 图幅,
			--Number AS 数量,
			TypeName AS 件型,
			--  Level AS 分组,
			ImportantName AS 重要度,OwnerName AS 设计,ValidDate AS 生效日期,
			--Remark AS 备注,
			SumCount AS 总数 FROM ##VirtualDown
			WHERE TypeName = 'F件型' OR TypeName = 'N件型'
		END

		--如果类型5，生成图纸管理表
		IF @Type = 5
		BEGIN
			SELECT DISTINCT NextLevel AS 文件编号,NextLevelName AS 文件名称,SheetName AS 图幅,OwnerName AS 设计
			FROM ##VirtualDown
			WHERE SheetName != 'Z'
		END

		DROP TABLE ##VirtualDown
		CLOSE cSumRow
		DEALLOCATE cSumRow
		CLOSE cTopLevel
		DEALLOCATE cTopLevel
	END

	--测试用,
	IF @Type = 10
	BEGIN
		--SELECT NaturalNo,No AS 层级,NextLevel AS 件号,NextLevelName AS 名称,AssembleNo AS 上级件号,SheetName AS 图幅,Number AS 数量,TypeName AS 件型,
		--Level AS 分组,ImportantName AS 重要度,OwnerName AS 设计,ValidDate AS 生效日期,Remark AS 备注,TopLevel AS 顶级件号,PartCount AS 部分数,SumCount AS 总数 FROM ##VirtualDown
		SELECT * FROM ##VirtualDown
	END

END
