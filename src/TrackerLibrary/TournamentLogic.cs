using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.Configuration;
using TrackerLibrary.Connector;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        public static MatchupEntryModel DetermineWinner(MatchupEntryModel teamA, MatchupEntryModel teamB)
        {
            if (teamA.TeamCompeting==null || teamB.TeamCompeting==null)
            {
                if (teamB.TeamCompeting == null) return teamA;
                else return teamB;
            }
            else
            {
                if (teamA.Score > teamB.Score) return teamA;
                else return teamB;
            }
        }

        public static List<List<MatchupModel>> CreateRounds(TournamentModel model)
        {
            // Get randomized list of teams
            List<TeamModel> randomizedTeams = model.EnteredTeams.OrderBy(x => Guid.NewGuid()).ToList();
            
            // Get number of rounds
            int rounds = (int)(Math.Ceiling(Math.Log((double)randomizedTeams.Count, 2)));
            
            // Get number of byes required
            int byes= (int)(Math.Pow(2, (double)(rounds-1)) - randomizedTeams.Count);

            int matchups=(int)(Math.Pow(2, (double)rounds) - 1);

            int lastroundMatchupCountBuffer = 0;
            int lastroundMatchupCount = 0;
            int lastRoundMatchupListInd = 0;
            int randomTeamIndex = 0;

            bool endOfList = false;

            List<List<MatchupModel>> matchupModelsAllRounds = new List<List<MatchupModel>>();
            List<MatchupModel> lastRoundMatchupList = new List<MatchupModel>();

            // Start creating matchups
            for (int i = 0; i < rounds; i++)
            {
                List<MatchupModel> matchupModelsPerRound = new List<MatchupModel>();
                
                if (i+1 == 1)
                {
                    for (int j = 0; j < (int)Math.Ceiling((double)randomizedTeams.Count/2); j++)
                    {
                        // Create new MatchupModel
                        MatchupModel matchupModel = new MatchupModel();
                        matchupModel.MatchupRound = i+1;
                        matchupModel.TournamentId = model.Id;

                        // Add in DB and get id
                        matchupModel=GlobalConfig.Connection.CreateMatchup(matchupModel);

                        for (int k=0;k<2;k++)//Add two teams per Matchup
                        {
                            if (endOfList)
                            {
                                // Add byes to Matchups
                                MatchupEntryModel matchupEntryModel = new MatchupEntryModel();
                                // Add null teams to matchups with bye
                                matchupEntryModel.MatchupId = matchupModel.Id;
                                matchupEntryModel.TournamentId = model.Id;

                                GlobalConfig.Connection.CreateMatchupEntry(matchupEntryModel);

                                matchupModel.Entries.Add(matchupEntryModel);
                            }
                            else
                            {
                                //  Create MatchupEntry
                                MatchupEntryModel matchupEntryModel = new MatchupEntryModel();
                                //  Add teams to first round Matchups
                                matchupEntryModel.MatchupId = matchupModel.Id;
                                matchupEntryModel.TournamentId = model.Id;
                                matchupEntryModel.TeamCompeting = randomizedTeams[randomTeamIndex];

                                GlobalConfig.Connection.CreateMatchupEntry(matchupEntryModel);

                                matchupModel.Entries.Add(matchupEntryModel);

                                if (randomizedTeams[randomTeamIndex] == randomizedTeams.Last()) endOfList = true;
                                randomTeamIndex += 1;
                            }                                                        
                        }
                        lastroundMatchupCountBuffer += 1;
                        matchupModelsPerRound.Add(matchupModel);
                    }
                }
                else
                {
                    for (int j = 0; j < lastroundMatchupCount/2; j++)
                    {
                        // Create new MatchupModel
                        MatchupModel matchupModel = new MatchupModel();
                        matchupModel.MatchupRound = i + 1;
                        matchupModel.TournamentId = model.Id;

                        // Add in DB and get id
                        matchupModel = GlobalConfig.Connection.CreateMatchup(matchupModel);

                        for (int k = 0; k < 2; k++)
                        {
                            //  Create blank MatchupEntries
                            MatchupEntryModel matchupEntryModel = new MatchupEntryModel();
                            matchupEntryModel.MatchupId = matchupModel.Id;
                            matchupEntryModel.TournamentId = model.Id;
                            matchupEntryModel.ParentMatchup = lastRoundMatchupList[lastRoundMatchupListInd];

                            GlobalConfig.Connection.CreateMatchupEntry(matchupEntryModel);

                            matchupModel.Entries.Add(matchupEntryModel);
                            lastRoundMatchupListInd += 1;
                        }
                        lastroundMatchupCountBuffer += 1;
                        matchupModelsPerRound.Add(matchupModel);
                    }
                }
                matchupModelsAllRounds.Add(matchupModelsPerRound);
                lastroundMatchupCount = lastroundMatchupCountBuffer;
                lastRoundMatchupList = matchupModelsPerRound;
            }
            return matchupModelsAllRounds;
        }
    }
}
