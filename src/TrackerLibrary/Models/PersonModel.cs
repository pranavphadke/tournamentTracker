using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Person id in DB
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Team member's first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Team member's first name
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Team member's last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Team member's email address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Team member's cellphone number
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string GetFullName
        {
            get
            {
                return $"{FirstName} {MiddleName} {LastName}";
            }
        }

        public PersonModel(string memberFirstNameTextBox,string memberMiddleNameTextBox,string memberLastNameTextBox,string memberEmailTextBox,string memberPhoneNumberTextBox)
        {
            FirstName = memberFirstNameTextBox;
            MiddleName = memberMiddleNameTextBox;
            LastName = memberLastNameTextBox;
            EmailAddress = memberEmailTextBox;
            CellphoneNumber = memberPhoneNumberTextBox;
        }

        public PersonModel()
        {

        }
    }
}
