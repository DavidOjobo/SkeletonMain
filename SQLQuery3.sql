USE [p2416227]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblCustomer_FJ_FilterByProductNo]

SELECT	@return_value as 'Return Value'

GO
