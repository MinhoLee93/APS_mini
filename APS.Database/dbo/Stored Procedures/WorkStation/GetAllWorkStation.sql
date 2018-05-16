﻿CREATE PROCEDURE [dbo].[GetAllWorkStation]
	@GroupUID Int,
	@PageCount Int
AS
	With WorkStationByGroup
	As
	(
		Select Id, Title, Image, Description, SetupTime, ProcessingTime, ViewOrder, GroupUID, 
		ROW_NUMBER() Over (Order by ViewOrder Asc) as 'RowNumber'
		From WorkStation
	)
	Select * From WorkStationByGroup
	Where RowNumber Between @PageCount*8 +1 And (@PageCount+1)*8
Go
