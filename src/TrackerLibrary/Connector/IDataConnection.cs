using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary;
using TrackerLibrary.Models;
using System.Data.SqlClient;

namespace TrackerLibrary.Connector
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
        PersonModel CreatePerson(PersonModel model);
        TeamModel CreateTeam(TeamModel model);
        TournamentModel CreateTournament(TournamentModel model);
        MatchupModel CreateMatchup(MatchupModel model);
        MatchupEntryModel CreateMatchupEntry(MatchupEntryModel model);
        void UpdatePrize(PrizeModel model);
        void UpdatePerson(PersonModel model);
        void UpdateTeam(TeamModel model);
        void UpdateTournament(TournamentModel model);
        void UpdateMatchupEntry(MatchupEntryModel model);
        void UpdateMatchup(MatchupModel model);
        void DeletePerson(PersonModel model);
        void DeletePrize(PrizeModel model);
        void DeleteTeam(TeamModel model);
        void DeleteTournament(TournamentModel model);
        List<PersonModel> GetAllPersons();
        List<PrizeModel> GetAllPrizes();
        List<TeamModel> GetAllTeams();
        List<PersonModel> GetAllPersonsByTeam(TeamModel model);
        List<TournamentModel> GetAllTournaments();
        List<TeamModel> GetAllTeamsByTournament(TournamentModel model);
    }
}
