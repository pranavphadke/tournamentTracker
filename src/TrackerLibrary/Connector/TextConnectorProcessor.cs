using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Configuration;
using TrackerLibrary.Models;

namespace TrackerLibrary.Connector.TextFileProcessor
{
    public static class TextConnectorProcessor
    {
        /// <summary>
        /// Prepares full path for data storage file
        /// </summary>
        /// <param name="fileName">Name of the storage file (.csv)</param>
        /// <returns>String for full path to the storage file</returns>
        public static string FullFilePath(this string fileName)
        {
            // TODO - Check how to specify location for appData folder on user computer in XML?
            //return $"{ConfigurationManager.AppSettings["dataStoragePathTemp"]}\\{fileName}";
            return $"{GlobalConfig.DataStoragePath()}\\{fileName}";
        }

        /// <summary>
        /// Load data storage text file and read all lines in the file
        /// </summary>
        /// <param name="filePath">Full path of the storage file</param>
        /// <returns>List of strings for each line in file</returns>
        public static List<string> LoadFile(this string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<string>();
            }

            return File.ReadAllLines(filePath).ToList();
        }

        /// <summary>
        /// Gets list of PrizeModels from list of lines extract from storage file
        /// </summary>
        /// <param name="lines"></param>
        /// <returns>List of PrizeModel</returns>
        public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines)
        {
            List<PrizeModel> prizeModels = new List<PrizeModel>();

            foreach(string line in lines)
            {
                string[] lineFields = line.Split(',');

                PrizeModel model = new PrizeModel();
                model.Id = int.Parse(lineFields[0]);
                model.PrizePlaceNumber = int.Parse(lineFields[1]);
                model.PrizeName = lineFields[2];
                model.PrizeAmount = decimal.Parse(lineFields[3]);
                model.PrizePercentage = double.Parse(lineFields[4]);

                prizeModels.Add(model);
            }

            return prizeModels;
        }

        public static List<PersonModel> ConvertToPersonModel(this List<string> lines)
        {
            List<PersonModel> personModels = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] lineFields = line.Split(',');

                PersonModel model = new PersonModel();
                model.Id = int.Parse(lineFields[0]);
                model.FirstName = lineFields[1];
                model.MiddleName = lineFields[2];
                model.LastName = lineFields[3];
                model.EmailAddress = lineFields[4];
                model.CellphoneNumber = lineFields[5];

                personModels.Add(model);
            }

            return personModels;
        }

        /// <summary>
        /// Gets list of String from list of PrizeModels
        /// </summary>
        /// <param name="prizeModels"></param>
        /// <returns></returns>
        public static List<string> ConvertPrizeToStringList(this List<PrizeModel> prizeModels)
        {
            List<String> lines = new List<string>();

            foreach (PrizeModel model in prizeModels)
            {
                lines.Add($"{model.Id},{model.PrizePlaceNumber},{model.PrizeName},{model.PrizeAmount},{model.PrizePercentage}");
            }

            return lines;
        }

        public static List<string> ConvertPersonToStringList(this List<PersonModel> personModels)
        {
            List<String> lines = new List<string>();

            foreach (PersonModel model in personModels)
            {
                lines.Add($"{model.Id},{model.FirstName},{model.MiddleName},{model.LastName},{model.EmailAddress},{model.CellphoneNumber}");
            }

            return lines;
        }

        public static void WriteFile(this List<string> lines, string fileName)
        {
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
