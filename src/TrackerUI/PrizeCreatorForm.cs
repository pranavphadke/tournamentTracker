using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Configuration;
using TrackerLibrary.Connector;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class PrizeCreatorForm : Form
    {
        private List<PrizeModel> updatablePrizes = new List<PrizeModel>();
        private PrizeModel updatablePrize;
        private Form parentForm;
        public PrizeCreatorForm()
        {
            InitializeComponent();
            updatablePrizes = GlobalConfig.Connection.GetAllPrizes();
            ConnectFormToList();
        }

        public PrizeCreatorForm(MainWindow mainForm)
        {
            InitializeComponent();
            parentForm = mainForm;
            updatablePrizes = GlobalConfig.Connection.GetAllPrizes();
            ConnectFormToList();
        }

        private void ConnectFormToList()
        {
            updatablePrizesComboBox.DataSource = null;

            if (updatablePrizes != null)
            {
                updatablePrizesComboBox.DataSource = updatablePrizes;
            }

            updatablePrizesComboBox.DisplayMember = "GetAlternatePrizeName";
        }
        
        private void CreateNewPrizeButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm(newPrizePlaceNumberTextBox.Text,newPrizeAmountTextBox.Text,newPrizePercentageTextBox.Text))
            {
                PrizeModel newPrizeModel = new PrizeModel(
                    newPrizeNameTextBox.Text,
                    newPrizeAmountTextBox.Text,
                    newPrizePercentageTextBox.Text,
                    newPrizePlaceNumberTextBox.Text);

                GlobalConfig.Connection.CreatePrize(newPrizeModel);

                newPrizePlaceNumberTextBox.Text = "New prize place number";
                newPrizeNameTextBox.Text = "New prize name";
                newPrizeAmountTextBox.Text = "0";
                newPrizePercentageTextBox.Text = "0";

                MessageBox.Show("Prize created!");
            }
            else
            {
                MessageBox.Show("Error: Details provided are not valid! Please check information and try again.");
            }
        }

        private void UpdatePrizeInfoButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm(prizePlaceNumberToUpdateTextBox.Text, prizeAmountToUpdateTextBox.Text, prizePercentageToUpdateTextBox.Text))
            {
                int prizePlaceNumber = 0;
                decimal prizeAmount = 0;
                double prizePercentage = 0;

                int.TryParse(prizePlaceNumberToUpdateTextBox.Text, out prizePlaceNumber);
                decimal.TryParse(prizeAmountToUpdateTextBox.Text, out prizeAmount);
                double.TryParse(prizePercentageToUpdateTextBox.Text, out prizePercentage);

                updatablePrize.PrizeName = prizeNameToUpdateTextBox.Text;
                updatablePrize.PrizePlaceNumber= prizePlaceNumber;
                updatablePrize.PrizeAmount = prizeAmount;
                updatablePrize.PrizePercentage = prizePercentage;

                GlobalConfig.Connection.UpdatePrize(updatablePrize);

                MessageBox.Show("Prize information updated!");

                addEditPrizesTabPanel.SelectTab("addPrize");
                addEditPrizesTabPanel.SelectTab("editPrize");
            }
            else
            {
                MessageBox.Show("Error: Details provided are not valid! Please check information and try again.");
            }
        }

        private bool ValidateForm(string prizePlaceNumberTextBox, string prizeAmountTextBox, string prizePercentageTextBox)
        {
            bool formValid = true;
            int prizePlaceNumber = 0;
            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool placeNumberValid = int.TryParse(prizePlaceNumberTextBox, out prizePlaceNumber);
            bool prizeAmountValid = decimal.TryParse(prizeAmountTextBox, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageTextBox, out prizePercentage);

            if (placeNumberValid == false || prizePlaceNumber < 1)
            {
                formValid = false;
            }
            if (prizeAmountValid == false || prizeAmount < 0)
            {
                formValid = false;
            }
            if (prizePercentageValid == false || prizePercentage < 0)
            {
                formValid = false;
            }
            if (prizeAmount == 0 && prizePercentage == 0)
            {
                formValid = false;
            }

            return formValid;
        }

        private void UpdatablePrizesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrizeModel updateSelectedPrize = (PrizeModel)updatablePrizesComboBox.SelectedItem;
            
            if (updateSelectedPrize != null)
            {
                updatablePrize = updateSelectedPrize;
                prizePlaceNumberToUpdateTextBox.Text = $"{updateSelectedPrize.PrizePlaceNumber}";
                prizeNameToUpdateTextBox.Text = updateSelectedPrize.PrizeName;
                prizeAmountToUpdateTextBox.Text = $"{updateSelectedPrize.PrizeAmount}";
                prizePercentageToUpdateTextBox.Text = $"{updateSelectedPrize.PrizePercentage}";
            }
        }

        private void AddEditPrizesTabPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatablePrizes = GlobalConfig.Connection.GetAllPrizes();
            ConnectFormToList();
        }

        private void DeletePrizeInfoButton_Click(object sender, EventArgs e)
        {
            GlobalConfig.Connection.DeletePrize(updatablePrize);

            MessageBox.Show("Prize information deleted!");

            addEditPrizesTabPanel.SelectTab("addPrize");
            addEditPrizesTabPanel.SelectTab("editPrize");
        }
    }
}
