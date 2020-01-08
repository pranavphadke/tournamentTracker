using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary;
using TrackerLibrary.Connector;
using System.Configuration;
using System.IO;

namespace TrackerLibrary.Configuration
{
    public static class GlobalConfig
    {
        /// <summary>
        /// Type of storage connection in use (Sql or Textfile)
        /// </summary>
        public static IDataConnection Connection { get; private set; }

        /// <summary>
        /// Initializes storage connection to use
        /// </summary>
        /// <param name="connectionType">Specify if Sql or Textfile connection</param>
        public static void IntializeConnection(ConnectionType connectionType)
        {
            switch (connectionType)
            {
                case ConnectionType.Sql:
                    SqlConnector sql = new SqlConnector();
                    Connection = sql;
                    break;
                case ConnectionType.Textfile:
                    TextConnector text = new TextConnector();
                    Connection = text;
                    break;
                default:
                    break;
            }
            //if (connectionType == ConnectionType.Sql)
            //{
            //    
            //    SqlConnector sql = new SqlConnector();
            //    Connections.Add(sql);
            //}
            //elseif (connectionType == ConnectionType.Textfile)
            //{
            //    
            //    TextConnector text = new TextConnector();
            //    Connections.Add(text);
            //}
        }

        /// <summary>
        /// Returns connection string for a particular Sql DB
        /// </summary>
        /// <param name="name">Specify the name of the database</param>
        /// <returns></returns>
        public static string ConnectionString(string name) => ConfigurationManager.ConnectionStrings[name].ConnectionString;

        /// <summary>
        /// Prepares full path to storage folder for the application
        /// </summary>
        /// <returns>String for full path to the storage folder</returns>
        public static string DataStoragePath()
        {
            string dataFolder = "TournamentTrackerData";
            
            // TODO - Change storage location to local appdata folder for user
            
            // Temp location for \TournamentTrackerData\
            string dataPath = $"c:\\{ dataFolder }";

            // Use this location later for \TournamentTrackerData\
            //dataPath =Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dataFolder);

            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath);
            }

            return dataPath;
        }

        public static string AppKeyLookup(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
