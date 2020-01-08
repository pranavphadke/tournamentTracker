USE [TournamentTracker]
GO
/****** Object:  Table [dbo].[Matchup]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Matchup](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[WinnerId] [int] NULL,
	[MatchupRound] [int] NOT NULL,
	[TournamentId] [int] NOT NULL,
 CONSTRAINT [PK_Matchup] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatchupEntries]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatchupEntries](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TournamentId] [int] NOT NULL,
	[MatchupId] [int] NOT NULL,
	[ParentMatchupId] [int] NULL,
	[TeamCompetingId] [int] NULL,
	[Score] [int] NULL,
 CONSTRAINT [PK_MatchupEntry] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[EmailAddress] [nvarchar](50) NULL,
	[CellphoneNumber] [nchar](10) NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prize]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prize](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[PrizeName] [nvarchar](50) NOT NULL,
	[PrizeAmount] [money] NULL,
	[PrizePercentage] [float] NULL,
	[PrizePlaceNumber] [int] NOT NULL,
 CONSTRAINT [PK_Prizes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Team]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Team](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TeamName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Team] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeamMembers]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeamMembers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TeamId] [int] NOT NULL,
	[PersonId] [int] NOT NULL,
 CONSTRAINT [PK_TeamMembers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tournament]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tournament](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TournamentName] [nvarchar](50) NOT NULL,
	[EntryFee] [money] NULL,
 CONSTRAINT [PK_Tournament] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TournamentEnteredTeams]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TournamentEnteredTeams](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TournamentId] [int] NOT NULL,
	[TeamId] [int] NOT NULL,
 CONSTRAINT [PK_TournamentEnteredTeams] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TournamentPrizes]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TournamentPrizes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TournamentId] [int] NOT NULL,
	[PrizeId] [int] NOT NULL,
 CONSTRAINT [PK_TournamentPrizes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Matchup]  WITH CHECK ADD  CONSTRAINT [FK_Matchup_TournamentId] FOREIGN KEY([TournamentId])
REFERENCES [dbo].[Tournament] ([id])
GO
ALTER TABLE [dbo].[Matchup] CHECK CONSTRAINT [FK_Matchup_TournamentId]
GO
ALTER TABLE [dbo].[Matchup]  WITH CHECK ADD  CONSTRAINT [FK_Matchup_WinnerId] FOREIGN KEY([WinnerId])
REFERENCES [dbo].[Team] ([id])
GO
ALTER TABLE [dbo].[Matchup] CHECK CONSTRAINT [FK_Matchup_WinnerId]
GO
ALTER TABLE [dbo].[TeamMembers]  WITH CHECK ADD  CONSTRAINT [FK_TeamMembers_PersonId] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([id])
GO
ALTER TABLE [dbo].[TeamMembers] CHECK CONSTRAINT [FK_TeamMembers_PersonId]
GO
ALTER TABLE [dbo].[TeamMembers]  WITH CHECK ADD  CONSTRAINT [FK_TeamMembers_TeamId] FOREIGN KEY([TeamId])
REFERENCES [dbo].[Team] ([id])
GO
ALTER TABLE [dbo].[TeamMembers] CHECK CONSTRAINT [FK_TeamMembers_TeamId]
GO
ALTER TABLE [dbo].[TournamentEnteredTeams]  WITH CHECK ADD  CONSTRAINT [FK_TournamentEnteredTeams_TeamId] FOREIGN KEY([TeamId])
REFERENCES [dbo].[Team] ([id])
GO
ALTER TABLE [dbo].[TournamentEnteredTeams] CHECK CONSTRAINT [FK_TournamentEnteredTeams_TeamId]
GO
ALTER TABLE [dbo].[TournamentEnteredTeams]  WITH CHECK ADD  CONSTRAINT [FK_TournamentEnteredTeams_TournamentId] FOREIGN KEY([TournamentId])
REFERENCES [dbo].[Tournament] ([id])
GO
ALTER TABLE [dbo].[TournamentEnteredTeams] CHECK CONSTRAINT [FK_TournamentEnteredTeams_TournamentId]
GO
ALTER TABLE [dbo].[TournamentPrizes]  WITH CHECK ADD  CONSTRAINT [FK_TournamentPrizes_PrizeId] FOREIGN KEY([PrizeId])
REFERENCES [dbo].[Prize] ([id])
GO
ALTER TABLE [dbo].[TournamentPrizes] CHECK CONSTRAINT [FK_TournamentPrizes_PrizeId]
GO
ALTER TABLE [dbo].[TournamentPrizes]  WITH CHECK ADD  CONSTRAINT [FK_TournamentPrizes_TournamentId] FOREIGN KEY([TournamentId])
REFERENCES [dbo].[Tournament] ([id])
GO
ALTER TABLE [dbo].[TournamentPrizes] CHECK CONSTRAINT [FK_TournamentPrizes_TournamentId]
GO
/****** Object:  StoredProcedure [dbo].[spMatchup_DeleteByTournamentId]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchup_DeleteByTournamentId] 
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM dbo.Matchup WHERE TournamentId=@TournamentId;
END
GO
/****** Object:  StoredProcedure [dbo].[spMatchup_GetAll]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchup_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM dbo.Matchup
END
GO
/****** Object:  StoredProcedure [dbo].[spMatchup_GetById]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchup_GetById]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Matchup WHERE id=@Id;
END
GO
/****** Object:  StoredProcedure [dbo].[spMatchup_GetByTournament]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchup_GetByTournament]
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Matchup WHERE TournamentId=@TournamentId;
END
GO
/****** Object:  StoredProcedure [dbo].[spMatchup_Insert]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchup_Insert] 
	@TournamentId int,
	@MatchupRound int,
	@WinnerId int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.Matchup(TournamentId,MatchupRound,WinnerId)
	values (@TournamentId,@MatchupRound,@WinnerId)

	select @id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spMatchup_UpdateById]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchup_UpdateById]
	@id int,
	@WinnerId int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.Matchup
	SET WinnerId=@WinnerId
	WHERE id=@id;
END
GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_DeleteByMatchupId]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchupEntries_DeleteByMatchupId] 
	@MatchupId int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM dbo.MatchupEntries WHERE MatchupId=@MatchupId;
END
GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_DeleteByTournamentId]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchupEntries_DeleteByTournamentId] 
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM dbo.MatchupEntries WHERE TournamentId=@TournamentId;
END
GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_GetAll]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchupEntries_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM dbo.MatchupEntries
END
GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_GetByMatchupId]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchupEntries_GetByMatchupId]
	@MatchupId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.MatchupEntries WHERE MatchupId=@MatchupId;
END
GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_Insert]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchupEntries_Insert]
	@TournamentId int,
	@MatchupId int,
	@ParentMatchupId int,
	@TeamCompetingId int,
	@Score int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.MatchupEntries(TournamentId,MatchupId,ParentMatchupId,TeamCompetingId,Score)
	values (@TournamentId,@MatchupId,@ParentMatchupId,@TeamCompetingId,@Score)

	select @id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_UpdateById]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchupEntries_UpdateById] 
	@id int,
	@TeamCompetingId int,
	@Score int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.MatchupEntries
	SET TeamCompetingId=@TeamCompetingId,Score=@Score
	WHERE id=@id;
END

GO
/****** Object:  StoredProcedure [dbo].[spPerson_DeleteById]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPerson_DeleteById]
	@id int,
	@FirstName nvarchar(50),
	@MiddleName nvarchar(50),
	@LastName nvarchar(50),
	@EmailAddress nvarchar(50),
	@CellphoneNumber nchar(10)
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM dbo.Person WHERE id=@id;
END
GO
/****** Object:  StoredProcedure [dbo].[spPerson_GetAll]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPerson_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM dbo.Person
END
GO
/****** Object:  StoredProcedure [dbo].[spPerson_Insert]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPerson_Insert]
	@FirstName nvarchar(50),
	@MiddleName nvarchar(50),
	@LastName nvarchar(50),
	@EmailAddress nvarchar(50),
	@CellphoneNumber nchar(10),
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.Person(FirstName,MiddleName,LastName,EmailAddress,CellphoneNumber)
	values (@FirstName,@MiddleName,@LastName,@EmailAddress,@CellphoneNumber)

	select @id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spPerson_UpdateById]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPerson_UpdateById]
	@id int,
	@FirstName nvarchar(50),
	@MiddleName nvarchar(50),
	@LastName nvarchar(50),
	@EmailAddress nvarchar(50),
	@CellphoneNumber nchar(10)
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE dbo.Person
	SET FirstName=@FirstName,MiddleName=@MiddleName,LastName=@LastName,EmailAddress=@EmailAddress,CellphoneNumber=@CellphoneNumber
	WHERE id=@id;
END
GO
/****** Object:  StoredProcedure [dbo].[spPrize_DeleteById]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spPrize_DeleteById] 
	@id int,
	@PrizeName nvarchar(50),
	@PrizeAmount money,
	@PrizePercentage float,
	@PrizePlaceNumber int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM dbo.Prize WHERE id=@id;
END
GO
/****** Object:  StoredProcedure [dbo].[spPrize_GetAll]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPrize_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM dbo.Prize
END
GO
/****** Object:  StoredProcedure [dbo].[spPrize_Insert]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPrize_Insert]
	@PrizePlaceNumber int,
	@PrizeName nvarchar(50),
	@PrizeAmount money,
	@PrizePercentage float,
	@id int = 0 output
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into dbo.Prize(PrizePlaceNumber,PrizeName,PrizeAmount,PrizePercentage)
	values (@PrizePlaceNumber,@PrizeName,@PrizeAmount,@PrizePercentage)

	select @id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spPrize_UpdateById]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPrize_UpdateById]
	@id int,
	@PrizeName nvarchar(50),
	@PrizeAmount money,
	@PrizePercentage float,
	@PrizePlaceNumber int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.Prize
	SET PrizeName=@PrizeName,PrizeAmount=@PrizeAmount,PrizePercentage=@PrizePercentage,PrizePlaceNumber=@PrizePlaceNumber
	WHERE id=@id;
END
GO
/****** Object:  StoredProcedure [dbo].[spTeam_DeleteById]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeam_DeleteById] 
	@id int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM dbo.Team WHERE id=@id;
END
GO
/****** Object:  StoredProcedure [dbo].[spTeam_GetAll]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeam_GetAll]
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT *
	FROM dbo.Team
END
GO
/****** Object:  StoredProcedure [dbo].[spTeam_GetById]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeam_GetById]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Team WHERE id=@Id;
END
GO
/****** Object:  StoredProcedure [dbo].[spTeam_Insert]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeam_Insert]
	@TeamName nvarchar(50),
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.Team(TeamName)
	values (@TeamName)

	select @id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spTeam_UpdateById]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeam_UpdateById] 
	@id int,
	@TeamName nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.Team
	SET TeamName=@TeamName	WHERE id=@id;
END
GO
/****** Object:  StoredProcedure [dbo].[spTeamMembers_DeleteByTeamId]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeamMembers_DeleteByTeamId]
	@TeamId int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM dbo.TeamMembers WHERE TeamId=@TeamId;
END
GO
/****** Object:  StoredProcedure [dbo].[spTeamMembers_GetByTeam]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeamMembers_GetByTeam]
	@TeamId int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT pers.*
	FROM dbo.TeamMembers tm
	INNER JOIN dbo.Person pers on tm.PersonId=pers.id
	WHERE tm.TeamId=@TeamId;
END
GO
/****** Object:  StoredProcedure [dbo].[spTeamMembers_Insert]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeamMembers_Insert]
	@TeamId int,
	@PersonId int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.TeamMembers(TeamId,PersonId)
	values (@TeamId,@PersonId)

	select @id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spTournament_DeleteById]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournament_DeleteById] 
	@id int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM dbo.Tournament WHERE id=@id
END
GO
/****** Object:  StoredProcedure [dbo].[spTournament_GetAll]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournament_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM dbo.Tournament
END
GO
/****** Object:  StoredProcedure [dbo].[spTournament_Insert]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournament_Insert]
	@TournamentName nvarchar(50),
	@EntryFee money,
	@id int = 0 output	
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.Tournament(TournamentName,EntryFee)
	values (@TournamentName,@EntryFee)

	select @id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spTournament_UpdateById]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournament_UpdateById] 
	@TournamentName nvarchar(50),
	@EntryFee money,
	@id int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.Tournament
	SET TournamentName=@TournamentName,EntryFee=@EntryFee WHERE id=@id;
END
GO
/****** Object:  StoredProcedure [dbo].[spTournamentEnteredTeams_DeleteByTournamentId]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournamentEnteredTeams_DeleteByTournamentId]
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM dbo.TournamentEnteredTeams WHERE TournamentId=@TournamentId 
END
GO
/****** Object:  StoredProcedure [dbo].[spTournamentEnteredTeams_GetAll]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournamentEnteredTeams_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM dbo.TournamentEnteredTeams
END
GO
/****** Object:  StoredProcedure [dbo].[spTournamentEnteredTeams_GetByTournament]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournamentEnteredTeams_GetByTournament] 
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT teams.*
	FROM dbo.TournamentEnteredTeams et
	INNER JOIN dbo.Team teams on et.TeamId=teams.id
	WHERE et.TournamentId=@TournamentId;
END
GO
/****** Object:  StoredProcedure [dbo].[spTournamentEnteredTeams_Insert]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournamentEnteredTeams_Insert]
	@TournamentId int,
	@TeamId int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;
	
	insert into dbo.TournamentEnteredTeams(TournamentId,TeamId)
	values (@TournamentId,@TeamId)

	select @id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spTournamentPrizes_DeleteByTournamentId]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournamentPrizes_DeleteByTournamentId]
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM dbo.TournamentPrizes WHERE TournamentId=@TournamentId 
END
GO
/****** Object:  StoredProcedure [dbo].[spTournamentPrizes_GetAll]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournamentPrizes_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM dbo.TournamentPrizes
END
GO
/****** Object:  StoredProcedure [dbo].[spTournamentPrizes_GetByTournament]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournamentPrizes_GetByTournament] 
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT prizes.*
	FROM dbo.TournamentPrizes tp
	INNER JOIN dbo.Prize prizes on tp.PrizeId=prizes.id
	WHERE tp.TournamentId=@TournamentId;
END
GO
/****** Object:  StoredProcedure [dbo].[spTournamentPrizes_Insert]    Script Date: 02-Jan-20 9:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournamentPrizes_Insert]
	@TournamentId int,
	@PrizeId int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.TournamentPrizes(TournamentId,PrizeId)
	values (@TournamentId,@PrizeId)

	select @id = SCOPE_IDENTITY();
END
GO
