using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary;
using TrackerLibrary.Models;
using TrackerLibrary.Connector.TextFileProcessor;
using System.Linq;

namespace TrackerLibrary.Connector
{
    public class TextConnector : IDataConnection
    {
        private const string PrizeFile = "Prize.csv";
        private const string PersonFile = "Person.csv";

        public MatchupModel CreateMatchup(MatchupModel model)
        {
            throw new NotImplementedException();
        }

        public MatchupEntryModel CreateMatchupEntry(MatchupEntryModel model)
        {
            throw new NotImplementedException();
        }

        // TODO - Add person in the text file
        public PersonModel CreatePerson(PersonModel model)
        {
            // Load text file-OK
            // Convert text to list<PrizeModel>-OK
            List<PersonModel> models = PersonFile.FullFilePath().LoadFile().ConvertToPersonModel();
            int latestId = 0;
            // Read and find latest Id
            if (models.Count() > 0)
            {
                latestId = models.OrderByDescending(person => person.Id).First().Id + 1;
            }
            else
            {
                latestId = 1;
            }

            model.Id = latestId;

            // Add new PrizeModel with new Id
            models.Add(model);

            // Convert list<PrizeModel> to list<string>
            // Write to text file
            models.ConvertPersonToStringList().WriteFile(PersonFile);

            return model;
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load text file-OK
            // Convert text to list<PrizeModel>-OK
            List<PrizeModel> models = PrizeFile.FullFilePath().LoadFile().ConvertToPrizeModel();
            int latestId = 0;
            // Read and find latest Id
            if (models.Count() > 0)
            {
                latestId = models.OrderByDescending(prize => prize.Id).First().Id + 1;
            }
            else
            {
                latestId = 1;
            }
                
            model.Id = latestId;

            // Add new PrizeModel with new Id
            models.Add(model);

            // Convert list<PrizeModel> to list<string>
            // Write to text file
            models.ConvertPrizeToStringList().WriteFile(PrizeFile);

            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            throw new NotImplementedException();
        }

        public TournamentModel CreateTournament(TournamentModel model)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(PersonModel model)
        {
            throw new NotImplementedException();
        }

        public void DeletePrize(PrizeModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteTeam(TeamModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteTournament(TournamentModel model)
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetAllPersons()
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetAllPersonsByTeam(TeamModel model)
        {
            throw new NotImplementedException();
        }

        public List<PrizeModel> GetAllPrizes()
        {
            throw new NotImplementedException();
        }

        public List<TeamModel> GetAllTeams()
        {
            throw new NotImplementedException();
        }

        public List<TeamModel> GetAllTeamsByTournament(TournamentModel model)
        {
            throw new NotImplementedException();
        }

        public List<TournamentModel> GetAllTournaments()
        {
            throw new NotImplementedException();
        }

        public void UpdateMatchup(MatchupModel model)
        {
            throw new NotImplementedException();
        }

        public void UpdateMatchupEntry(MatchupEntryModel model)
        {
            throw new NotImplementedException();
        }

        // TODO - Update person information in text file
        public void UpdatePerson(PersonModel model)
        {
            throw new NotImplementedException();
        }

        // TODO - Update prize information in text file
        public void UpdatePrize(PrizeModel model)
        {
            throw new NotImplementedException();
        }

        public void UpdateTeam(TeamModel model)
        {
            throw new NotImplementedException();
        }

        public void UpdateTournament(TournamentModel model)
        {
            throw new NotImplementedException();
        }
    }
}
