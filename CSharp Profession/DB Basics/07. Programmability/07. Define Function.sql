ALTER FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(MAX), @word VARCHAR(MAX))
RETURNS BIT
AS
BEGIN
	 DECLARE @counter1 INT = 1
	 DECLARE @counter2 INT = 1
	 DECLARE @Pattern VARCHAR(1)
	 DECLARE @InnerResult BIT = 0
	 DECLARE @Result BIT = 0

	 IF(LEN(@word)>LEN(@setOfLetters))
		BEGIN
		RETURN @Result

		END
	 WHILE(@counter1<=LEN(@word))
		BEGIN
		    SET @Pattern = SUBSTRING(@word,@counter1,1)
			SET @counter2=1
				WHILE(@counter2<=LEN(@setOfLetters))
				BEGIN
			    	 SET @InnerResult=0	
				     IF(@Pattern = SUBSTRING(@setOfLetters,@counter2,1))
					   
					   BEGIN
					     SET @InnerResult=1
						 BREAK
					   END			        				  					 
					 SET @counter2=@counter2+1
				END
		    IF(@InnerResult=0)
			  BEGIN
			    SET @Result=0
				RETURN @Result
				
			  END
			ELSE
			  BEGIN
			    SET @Result=1
			  END
			SET @counter1=@counter1+1
		END

		RETURN @Result
END

SELECT 'oistmiahf','Sofia', dbo.ufn_IsWordComprised('oistmiahf','Sofia')
UNION ALL
SELECT 'oistmiahf','halves', dbo.ufn_IsWordComprised('oistmiahf','halves')
UNION ALL
SELECT 'bobr','Rob', dbo.ufn_IsWordComprised('bobr','Rob')
UNION ALL
SELECT 'pppp','Guy', dbo.ufn_IsWordComprised('pppp','Guy')


SELECT 'oistmiahf','halves', dbo.ufn_IsWordComprised('oistmiahf','halves')