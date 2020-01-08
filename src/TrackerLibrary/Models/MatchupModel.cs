using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Prize id in DB
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Teams in this match up
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Winning team in th match up
        /// </summary>
        public TeamModel Winner { get; set; }

        public int WinnerId { get; set; }

        /// <summary>
        /// Round number for this match up
        /// </summary>
        public int MatchupRound { get; set; }
        public int TournamentId { get; set; }
    }
}
