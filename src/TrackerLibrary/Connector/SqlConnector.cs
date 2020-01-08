using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TrackerLibrary;
using TrackerLibrary.Models;
using TrackerLibrary.Configuration;
using Dapper;
using System.Data.SqlClient;
using System.Linq;


namespace TrackerLibrary.Connector
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Creates a new person in DB
        /// </summary>
        /// <param name="model">The new person with id</param>
        /// <returns>Echos saved person with id</returns>
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                var dbData = new DynamicParameters();
                dbData.Add("@FirstName", model.FirstName);
                dbData.Add("@MiddleName", model.MiddleName);
                dbData.Add("@LastName", model.LastName);
                dbData.Add("@EmailAddress", model.EmailAddress);
                dbData.Add("@CellphoneNumber", model.CellphoneNumber);
                dbData.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPerson_Insert", dbData, commandType: CommandType.StoredProcedure);

                model.Id = dbData.Get<int>("@id");

                return model;
            }
        }

        /// <summary>
        /// Creates a new prize in DB
        /// <param name="model">The new prize entry without id</param>
        /// <returns>Echos saved prize entry with id</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                var dbData = new DynamicParameters();
                dbData.Add("@PrizePlaceNumber", model.PrizePlaceNumber);
                dbData.Add("@PrizeName", model.PrizeName);
                dbData.Add("@PrizeAmount", model.PrizeAmount);
                dbData.Add("@PrizePercentage", model.PrizePercentage);
                dbData.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrize_Insert", dbData, commandType: CommandType.StoredProcedure);

                model.Id = dbData.Get<int>("@id");

                return model;
            }
        }

        /// <summary>
        /// Creates new team in the DB
        /// </summary>
        /// <param name="model">The new new team without id</param>
        /// <returns>Echos saved team entry with id</returns>
        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                var dbData = new DynamicParameters();
                dbData.Add("@TeamName", model.TeamName);
                dbData.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeam_Insert", dbData, commandType: CommandType.StoredProcedure);

                model.Id = dbData.Get<int>("@id");

                foreach (PersonModel personModel in model.TeamMembers)
                {
                    dbData = new DynamicParameters();
                    dbData.Add("@TeamId", model.Id);
                    dbData.Add("@PersonId", personModel.Id);
                    dbData.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spTeamMembers_Insert", dbData, commandType: CommandType.StoredProcedure);
                }
                return model;
            }
        }

        /// <summary>
        /// Creates new tournament in the DB
        /// </summary>
        /// <param name="model">The new tournament without the id</param>
        /// <returns>Echos saved tournament with id</returns>
        public TournamentModel CreateTournament(TournamentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                var dbData = new DynamicParameters();
                dbData.Add("@TournamentName", model.TournamentName);
                dbData.Add("@EntryFee", model.EntryFee);
                dbData.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournament_Insert", dbData, commandType: CommandType.StoredProcedure);

                model.Id = dbData.Get<int>("@id");

                foreach (TeamModel teamModel in model.EnteredTeams)
                {
                    dbData = new DynamicParameters();
                    dbData.Add("@TournamentId", model.Id);
                    dbData.Add("@TeamId", teamModel.Id);
                    dbData.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spTournamentEnteredTeams_Insert", dbData, commandType: CommandType.StoredProcedure);
                }

                foreach (PrizeModel prizeModel in model.Prizes)
                {
                    dbData = new DynamicParameters();
                    dbData.Add("@TournamentId", model.Id);
                    dbData.Add("@PrizeId", prizeModel.Id);
                    dbData.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spTournamentPrizes_Insert", dbData, commandType: CommandType.StoredProcedure);
                }

                return model;
            }
        }

        public MatchupModel CreateMatchup(MatchupModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                var dbData = new DynamicParameters();
                dbData.Add("@TournamentId", model.TournamentId);
                dbData.Add("@MatchupRound", model.MatchupRound);
                dbData.Add("@WinnerId", null);
                dbData.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spMatchup_Insert", dbData, commandType: CommandType.StoredProcedure);

                model.Id = dbData.Get<int>("@id");
            }
            return model;
        }

        public MatchupEntryModel CreateMatchupEntry(MatchupEntryModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                var dbData = new DynamicParameters();
                dbData.Add("@TournamentId", model.TournamentId);
                dbData.Add("@MatchupId", model.MatchupId);

                if (model.ParentMatchup==null) dbData.Add("@ParentMatchupId", null);
                else dbData.Add("@ParentMatchupId", model.ParentMatchup.Id);

                if (model.TeamCompeting==null) dbData.Add("@TeamCompetingId", null);
                else dbData.Add("@TeamCompetingId", model.TeamCompeting.Id);
                
                dbData.Add("@Score", 0);
                dbData.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spMatchupEntries_Insert", dbData, commandType: CommandType.StoredProcedure);

                model.Id = dbData.Get<int>("@id");
            }
            return model;
        }

        /// <summary>
        /// Updates person already in DB
        /// </summary>
        /// <param name="model">Person entry to be updated</param>
        /// <returns></returns>
        public void UpdatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                var dbData = new DynamicParameters();
                dbData.Add("@id", model.Id);
                dbData.Add("@FirstName", model.FirstName);
                dbData.Add("@MiddleName", model.MiddleName);
                dbData.Add("@LastName", model.LastName);
                dbData.Add("@EmailAddress", model.EmailAddress);
                dbData.Add("@CellphoneNumber", model.CellphoneNumber);
                
                connection.Execute("dbo.spPerson_UpdateById", dbData, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Updates prize entry already in the DB
        /// </summary>
        /// <param name="model">Prize entry to be updated</param>
        /// <returns></returns>
        public void UpdatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                var dbData = new DynamicParameters();
                dbData.Add("@id", model.Id);
                dbData.Add("@PrizeName", model.PrizeName);
                dbData.Add("@PrizeAmount", model.PrizeAmount);
                dbData.Add("@PrizePercentage", model.PrizePercentage);
                dbData.Add("@PrizePlaceNumber", model.PrizePlaceNumber);

                connection.Execute("dbo.spPrize_UpdateById", dbData, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Updates team entry already in the DB
        /// </summary>
        /// <param name="model">Team entry to be updated</param>
        public void UpdateTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                var dbData = new DynamicParameters();
                dbData.Add("@id", model.Id);
                dbData.Add("@TeamName", model.TeamName);

                connection.Execute("dbo.spTeam_UpdateById", dbData, commandType: CommandType.StoredProcedure);
                
                dbData = new DynamicParameters();
                dbData.Add("@TeamId", model.Id);

                connection.Execute("dbo.spTeamMembers_DeleteByTeamId", dbData, commandType: CommandType.StoredProcedure);

                foreach (PersonModel personModel in model.TeamMembers)
                {
                    dbData = new DynamicParameters();
                    dbData.Add("@TeamId", model.Id);
                    dbData.Add("@PersonId", personModel.Id);
                    dbData.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spTeamMembers_Insert", dbData, commandType: CommandType.StoredProcedure);
                }
            }
        }

        /// <summary>
        /// Updates tournament entry already in the DB
        /// </summary>
        /// <param name="model">Tournament entry to be updated</param>
        public void UpdateTournament(TournamentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                var dbData = new DynamicParameters();
                dbData.Add("@TournamentName", model.TournamentName);
                dbData.Add("@EntryFee", model.EntryFee);
                dbData.Add("@id", model.Id);

                connection.Execute("dbo.spTournament_UpdateById", dbData, commandType: CommandType.StoredProcedure);

                dbData = new DynamicParameters();
                dbData.Add("@TournamentId", model.Id);

                connection.Execute("dbo.spTournamentEnteredTeams_DeleteByTournamentId", dbData, commandType: CommandType.StoredProcedure);
                connection.Execute("dbo.spTournamentPrizes_DeleteByTournamentId", dbData, commandType: CommandType.StoredProcedure);
                
                connection.Execute("dbo.spMatchupEntries_DeleteByTournamentId", dbData, commandType: CommandType.StoredProcedure);
                connection.Execute("dbo.spMatchup_DeleteByTournamentId", dbData, commandType: CommandType.StoredProcedure);

                foreach (TeamModel teamModel in model.EnteredTeams)
                {
                    dbData = new DynamicParameters();
                    dbData.Add("@TournamentId", model.Id);
                    dbData.Add("@TeamId", teamModel.Id);
                    dbData.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spTournamentEnteredTeams_Insert", dbData, commandType: CommandType.StoredProcedure);
                }

                foreach (PrizeModel prizeModel in model.Prizes)
                {
                    dbData = new DynamicParameters();
                    dbData.Add("@TournamentId", model.Id);
                    dbData.Add("@PrizeId", prizeModel.Id);
                    dbData.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spTournamentPrizes_Insert", dbData, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public void UpdateMatchupEntry(MatchupEntryModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                var dbData = new DynamicParameters();
                dbData.Add("@id", model.Id);
                dbData.Add("@TeamCompetingId", model.TeamCompetingId);
                dbData.Add("@Score", model.Score);


                connection.Execute("dbo.spMatchupEntries_UpdateById", dbData, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateMatchup(MatchupModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                var dbData = new DynamicParameters();
                dbData.Add("@id", model.Id);
                dbData.Add("@WinnerId", model.WinnerId);

                connection.Execute("dbo.spMatchup_UpdateById", dbData, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Gets all Persons in the DB
        /// </summary>
        /// <returns>List of PersonModel</returns>
        public List<PersonModel> GetAllPersons()
        {
            List<PersonModel> selectablePersons;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                selectablePersons = connection.Query<PersonModel>("dbo.spPerson_GetAll").ToList();   
            }
            return selectablePersons;
        }

        /// <summary>
        /// Gets all Prizes in the DB
        /// </summary>
        /// <returns>List of PrizeModel</returns>
        public List<PrizeModel> GetAllPrizes()
        {
            List<PrizeModel> selectablePrizes;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                selectablePrizes = connection.Query<PrizeModel>("dbo.spPrize_GetAll").ToList();
            }
            return selectablePrizes;
        }

        /// <summary>
        /// Gets all Teams in the DB
        /// </summary>
        /// <returns>List of TeamModel</returns>
        public List<TeamModel> GetAllTeams()
        {
            List<TeamModel> selectableTeams;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                selectableTeams = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

                foreach(TeamModel teamModel in selectableTeams)
                {
                    var dbData = new DynamicParameters();
                    dbData.Add("@TeamId", teamModel.Id);
                    teamModel.TeamMembers= connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam",dbData,commandType: CommandType.StoredProcedure).ToList();
                }
            }
            return selectableTeams;
        }

        /// <summary>
        /// Gets all Tournaments existing in the DB
        /// </summary>
        /// <returns>List of TournamentModel</returns>
        public List<TournamentModel> GetAllTournaments()
        {
            List<TournamentModel> selectableTournaments;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                selectableTournaments = connection.Query<TournamentModel>("dbo.spTournament_GetAll").ToList();

                foreach (TournamentModel tournamentModel in selectableTournaments)
                {
                    var dbData = new DynamicParameters();
                    dbData.Add("@TournamentId", tournamentModel.Id);
                    tournamentModel.EnteredTeams=connection.Query<TeamModel>("dbo.spTournamentEnteredTeams_GetByTournament",dbData,commandType: CommandType.StoredProcedure).ToList();
                    tournamentModel.Prizes=connection.Query<PrizeModel>("dbo.spTournamentPrizes_GetByTournament",dbData,commandType: CommandType.StoredProcedure).ToList();
                    
                    List<MatchupModel> matchupModels= connection.Query<MatchupModel>("dbo.spMatchup_GetByTournament", dbData, commandType: CommandType.StoredProcedure).ToList();
                    int rounds = (int)(Math.Ceiling(Math.Log((double)matchupModels.Count + 1, 2)));
                    List<List<MatchupModel>> matchupModelsAllRounds = new List<List<MatchupModel>>();
                    for (int i = 0; i < rounds; i++)
                    {
                        List<MatchupModel> matchupModelsPerRound = new List<MatchupModel>();
                        foreach (MatchupModel matchupModel in matchupModels)
                        {
                            if (matchupModel.MatchupRound == i + 1)
                            {
                                dbData = new DynamicParameters();
                                dbData.Add("@MatchupId", matchupModel.Id);
                                List<MatchupEntryModel> matchupEntries = connection.Query<MatchupEntryModel>("dbo.spMatchupEntries_GetByMatchupId", dbData, commandType: CommandType.StoredProcedure).ToList();
                                foreach(MatchupEntryModel matchupEntry in matchupEntries)
                                {                                  
                                    if (matchupEntry.TeamCompetingId > 0)
                                    {
                                        dbData = new DynamicParameters();
                                        dbData.Add("@Id", matchupEntry.TeamCompetingId);
                                        matchupEntry.TeamCompeting = connection.Query<TeamModel>("dbo.spTeam_GetById", dbData, commandType: CommandType.StoredProcedure).ToList().First();
                                    }

                                    if (matchupEntry.ParentMatchupId > 0)
                                    {
                                        dbData = new DynamicParameters();
                                        dbData.Add("@Id", matchupEntry.ParentMatchupId);
                                        matchupEntry.ParentMatchup = connection.Query<MatchupModel>("dbo.spMatchup_GetById", dbData, commandType: CommandType.StoredProcedure).ToList().First();
                                    }
                                }
                                matchupModel.Entries = matchupEntries;

                                if (matchupModel.WinnerId>0)
                                {
                                    dbData = new DynamicParameters();
                                    dbData.Add("@Id", matchupModel.WinnerId);
                                    matchupModel.Winner = connection.Query<TeamModel>("dbo.spTeam_GetById", dbData, commandType: CommandType.StoredProcedure).ToList().First();
                                }                                

                                matchupModelsPerRound.Add(matchupModel);
                            }
                        }
                        matchupModelsAllRounds.Add(matchupModelsPerRound);
                    }
                    tournamentModel.Rounds = matchupModelsAllRounds; 
                }
            }
            return selectableTournaments;
        }

        /// <summary>
        /// Deletes passed PersonModel from the DB
        /// </summary>
        /// <param name="model">PersonModel to be deleted from DB</param>
        public void DeletePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                var dbData = new DynamicParameters();
                dbData.Add("@id", model.Id);
                dbData.Add("@FirstName", model.FirstName);
                dbData.Add("@MiddleName", model.MiddleName);
                dbData.Add("@LastName", model.LastName);
                dbData.Add("@EmailAddress", model.EmailAddress);
                dbData.Add("@CellphoneNumber", model.CellphoneNumber);

                connection.Execute("dbo.spPerson_DeleteById", dbData, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Deletes passed PrizeModel from the DB
        /// </summary>
        /// <param name="model">PrizeModel to be deleted from DB</param>
        public void DeletePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                var dbData = new DynamicParameters();
                dbData.Add("@id", model.Id);
                dbData.Add("@PrizeName", model.PrizeName);
                dbData.Add("@PrizeAmount", model.PrizeAmount);
                dbData.Add("@PrizePercentage", model.PrizePercentage);
                dbData.Add("@PrizePlaceNumber", model.PrizePlaceNumber);

                connection.Execute("dbo.spPrize_DeleteById", dbData, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Deletes passed TeamModel along with associated members from the DB
        /// </summary>
        /// <param name="model">Team to be deleted</param>
        public void DeleteTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                var dbData = new DynamicParameters();
                dbData.Add("@TeamId", model.Id);

                connection.Execute("dbo.spTeamMembers_DeleteByTeamId", dbData, commandType: CommandType.StoredProcedure);

                dbData = new DynamicParameters();
                dbData.Add("@id", model.Id);

                connection.Execute("dbo.spTeam_DeleteById", dbData, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Deletes passed TournamentModel along with associated Teams and Prizes from the DB
        /// </summary>
        /// <param name="model">Tournament to be deleted</param>
        public void DeleteTournament(TournamentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentTracker")))
            {
                var dbData = new DynamicParameters();
                dbData.Add("@TournamentId", model.Id);

                connection.Execute("dbo.spTournamentPrizes_DeleteByTournamentId", dbData, commandType: CommandType.StoredProcedure);
                connection.Execute("dbo.spTournamentEnteredTeams_DeleteByTournamentId", dbData, commandType: CommandType.StoredProcedure);
                connection.Execute("dbo.spMatchupEntries_DeleteByTournamentId", dbData, commandType: CommandType.StoredProcedure);
                connection.Execute("dbo.spMatchup_DeleteByTournamentId", dbData, commandType: CommandType.StoredProcedure);

                dbData = new DynamicParameters();
                dbData.Add("@id", model.Id);

                connection.Execute("dbo.spTournament_DeleteById", dbData, commandType: CommandType.StoredProcedure);
            }
        }

        public List<PersonModel> GetAllPersonsByTeam(TeamModel model)
        {
            throw new NotImplementedException();
        }

        public List<TeamModel> GetAllTeamsByTournament(TournamentModel model)
        {
            throw new NotImplementedException();
        }
    }
}
