SELECT u.Username, u.IpAddress FROM Users AS u
	WHERE u.IpAddress LIKE '___.1%.%.___'
	ORDER BY u.Username