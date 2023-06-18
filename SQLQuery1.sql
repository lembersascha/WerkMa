INSERT INTO
	WerMa.dbo.Tbl_Email
	(
		SmtpServer,
		[Port],
		[Ssl],
		[User],
		[Password],
		Anbieter
	)
VALUES
	(
		@smtpServer,
		@port,
		@ssl,
		@user,
		@password,
		@anbieter
	);


