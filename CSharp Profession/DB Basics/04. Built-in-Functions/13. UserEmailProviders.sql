SELECT u.Username, SUBSTRING(u.Email,CHARINDEX('@',u.Email,1)+1,LEN(u.Email)-CHARINDEX(u.Email,'@',1)) FROM Users AS u
    ORDER BY SUBSTRING(u.Email,CHARINDEX('@',u.Email,1)+1,LEN(u.Email)-CHARINDEX(u.Email,'@',1)), u.Username
	