using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary;
using TrackerLibrary.Configuration;
using TrackerLibrary.Connector;
using TrackerLibrary.Models;

namespace TrackerUI
{
    // TODO - Create universal ValidateForm method
    public static class ValidateInfo
    {
        /// <summary>
        /// Validate form and return either true or false
        /// </summary>
        /// <param name="formID">Specify form to validate: 1-Tournament,2-Team,3-Member,4-Prize</param>
        /// <returns></returns>
        public static bool ValidateForm(int formID,object form)
        {
            bool formValid = true;
            switch (formID)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    //int placeNumber = 0;
                    //decimal prizeAmount = 0;
                    //double prizePercentage = 0;
                    break;
            }
            return formValid;
        }
    }
}
