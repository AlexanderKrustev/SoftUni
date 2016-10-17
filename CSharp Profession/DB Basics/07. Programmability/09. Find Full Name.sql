CREATE PROCEDURE usp_GetHoldersFullName
AS
BEGIN
    SELECT AH.FirstName+' '+ah.LastName AS FullName FROM AccountHolders AS ah
	        
END