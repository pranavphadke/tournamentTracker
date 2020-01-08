using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Configuration;
using TrackerLibrary.Connector;
using TrackerLibrary.Models;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize DB and/or text file connections
            GlobalConfig.IntializeConnection(ConnectionType.Sql);

            //Application.Run(new TournamentDashboardForm());
            //Application.Run(new TournamentCreatorForm());
            //Application.Run(new TeamCreatorForm());
            //Application.Run(new PrizeCreatorForm());
            Application.Run(new MainWindow());
        }
    }
}
