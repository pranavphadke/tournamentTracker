using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Prize id in DB
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of this tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Entry fee if any for this tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// List of prizes for this tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// List of temas in the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// List of all rounds (and match ups) in this tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

        public TournamentModel()
        {

        }

        public TournamentModel(List<TeamModel> selectedTeams,List<PrizeModel> selectedPrizes,string newTournamentNameTextBox,string entryFeeTextBox)
        {
            TournamentName = newTournamentNameTextBox;
            EntryFee = Convert.ToDecimal(entryFeeTextBox);
            Prizes = selectedPrizes;
            EnteredTeams = selectedTeams;

        }
    }
}
