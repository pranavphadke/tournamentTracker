using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Prize id in DB
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Prize name (first,second,etc)
        /// </summary>
        public string PrizeName { get; set; }

        /// <summary>
        /// Fixed prize amount
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Prize percentage based on percentage of the total fee collection
        /// </summary>
        public double PrizePercentage { get; set; }

        /// <summary>
        /// Prize number (1,2,etc)
        /// </summary>
        public int PrizePlaceNumber { get; set; }

        public string GetAlternatePrizeName
        {
            get
            {
                return $"{PrizeName} ({PrizeAmount}/{PrizePercentage}%)";
            }
        }

        public PrizeModel()
        {

        }

        public PrizeModel(string prizeNameTextBox, string prizeAmountTextBox, string prizePercentageTextBox, string prizePlaceNumberTextBox)
        {
            int prizePlaceNumber = 0;
            decimal prizeAmount = 0;
            double prizePercentage = 0;
            

            int.TryParse(prizePlaceNumberTextBox, out prizePlaceNumber);
            decimal.TryParse(prizeAmountTextBox, out prizeAmount);
            double.TryParse(prizePercentageTextBox, out prizePercentage);

            PrizeName = prizeNameTextBox;
            PrizePlaceNumber = prizePlaceNumber;
            PrizeAmount = prizeAmount;
            PrizePercentage = prizePercentage;
        }

    }
}
