using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Prize id in DB
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// One team in the match up
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        public int TeamCompetingId { get; set; }

        /// <summary>
        /// Score for this team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Match up from where this team came from
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
        public int ParentMatchupId { get; set; }

        public int MatchupId { get; set; }

        public int TournamentId { get; set; }
    }
}
