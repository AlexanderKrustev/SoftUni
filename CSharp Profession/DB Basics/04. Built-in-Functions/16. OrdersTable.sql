SELECT o.ProductName, CONVERT(VARCHAR, o.OrderDate , 121) AS 'OrderDate', 
      CONVERT(VARCHAR, DATEADD(DAY,3,o.OrderDate),121) AS 'Pay Due' ,
	  CONVERT(VARCHAR, DATEADD(MONTH,1,o.OrderDate),121) AS 'Deliver Due' 
      FROM [dbo].[Orders] AS o

