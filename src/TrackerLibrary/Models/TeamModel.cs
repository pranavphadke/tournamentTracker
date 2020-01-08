using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Prize id in DB
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// List of team members
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Name of this team
        /// </summary>
        public string TeamName { get; set; }

        public TeamModel()
        {

        }

        public TeamModel(List<PersonModel> personModels,string teamName)
        {
            TeamMembers = personModels;
            TeamName = teamName;
        }
    }
}
