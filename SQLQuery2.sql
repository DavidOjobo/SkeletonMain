USE [p2416227]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblProduct_FJ_Delete]
		@ProductNo = 3

SELECT	@return_value as 'Return Value'

GO
