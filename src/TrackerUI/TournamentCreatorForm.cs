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
    public partial class TournamentCreatorForm : Form
    {
        private List<TeamModel> selectableTeams = new List<TeamModel>();
        private List<TeamModel> selectedTeams = new List<TeamModel>();
        private List<PrizeModel> selectablePrizes = new List<PrizeModel>();
        private List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        private List<TournamentModel> updatableTournaments = new List<TournamentModel>();
        private MainWindow parentForm;
        private TournamentModel updatableTournament;

        public TournamentCreatorForm()
        {
            InitializeComponent();
            selectableTeams = GlobalConfig.Connection.GetAllTeams();
            selectablePrizes = GlobalConfig.Connection.GetAllPrizes();
            ConnectFormToList();
        }

        public TournamentCreatorForm(MainWindow mainForm)
        {
            InitializeComponent();
            parentForm = mainForm;
            selectableTeams = GlobalConfig.Connection.GetAllTeams();
            selectablePrizes = GlobalConfig.Connection.GetAllPrizes();
            ConnectFormToList();
        }

        private void ConnectFormToList()
        {
            selectableTeamsListBox.DataSource = null;
            selectedTeamsListBox.DataSource = null;
            selectablePrizesListBox.DataSource = null;
            selectedPrizesListBox.DataSource = null;
            currentSelectableTeamsListBox.DataSource = null;
            currentSelectedTeamsListBox.DataSource = null;
            currentSelectablePrizesListBox.DataSource = null;
            currentSelectedPrizesListBox.DataSource = null;

            updatableTournamentsComboBox.DataSource = updatableTournaments;

            if (createEditTournamentsTabPanel.SelectedIndex == 0)
            {
                if (selectableTeams != null)
                {
                    selectableTeamsListBox.DataSource = selectableTeams;
                }
                if (selectedTeams != null)
                {
                    selectedTeamsListBox.DataSource = selectedTeams;
                }
                if (selectablePrizes != null)
                {
                    selectablePrizesListBox.DataSource = selectablePrizes;
                }
                if (selectedPrizes != null)
                {
                    selectedPrizesListBox.DataSource = selectedPrizes;
                }
                selectableTeamsListBox.DisplayMember = "TeamName";
                selectedTeamsListBox.DisplayMember = "TeamName";
                selectablePrizesListBox.DisplayMember = "GetAlternatePrizeName";
                selectedPrizesListBox.DisplayMember = "GetAlternatePrizeName";
            }

            if (createEditTournamentsTabPanel.SelectedIndex == 1)
            {
                if (selectableTeams != null)
                {
                    currentSelectableTeamsListBox.DataSource = selectableTeams;
                }
                if (selectedTeams != null)
                {
                    currentSelectedTeamsListBox.DataSource = selectedTeams;
                }
                if (selectablePrizes != null)
                {
                    currentSelectablePrizesListBox.DataSource = selectablePrizes;
                }
                if (selectedPrizes != null)
                {
                    currentSelectedPrizesListBox.DataSource = selectedPrizes;
                }
                currentSelectableTeamsListBox.DisplayMember = "TeamName";
                currentSelectedTeamsListBox.DisplayMember = "TeamName";
                currentSelectablePrizesListBox.DisplayMember = "GetAlternatePrizeName";
                currentSelectedPrizesListBox.DisplayMember = "GetAlternatePrizeName";               
            }
            updatableTournamentsComboBox.DisplayMember = "TournamentName";
        }

        private bool ValidateForm(List<TeamModel> selectedTeamModelList, List<PrizeModel> selectedPrizeModelList, string tournamentNameTextBox, string tournamentFeeTextBox)
        {
            bool formValid = true;
            if (selectedTeamModelList == null)
            {
                formValid = false;
            }
            if (selectedPrizeModelList == null)
            {
                formValid = false;
            }
            if (tournamentNameTextBox == "Name of the tournament" || tournamentNameTextBox == null)
            {
                formValid = false;
            }
            return formValid;
        }

        private void CreateNewTournamentButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm(selectedTeams, selectedPrizes, newTournamentNameTextBox.Text, entryFeeTextBox.Text))
            {
                TournamentModel newTournamentModel = new TournamentModel(selectedTeams, selectedPrizes, newTournamentNameTextBox.Text, entryFeeTextBox.Text);

                newTournamentModel=GlobalConfig.Connection.CreateTournament(newTournamentModel);
                
                newTournamentModel.Rounds=TournamentLogic.CreateRounds(newTournamentModel);

                MessageBox.Show("New tournament created!");

                newTournamentNameTextBox.Text = "Name of the tournament";
                entryFeeTextBox.Text = "0";

                selectableTeams = GlobalConfig.Connection.GetAllTeams();
                selectedTeams = new List<TeamModel>();
                selectablePrizes = GlobalConfig.Connection.GetAllPrizes();
                selectedPrizes = new List<PrizeModel>();

                ConnectFormToList();
            }
            else
            {
                MessageBox.Show("Error: Details provided are not valid! Please check information and try again.");
            }
        }

        private void AddSelectedTeamsButton_Click(object sender, EventArgs e)
        {
            TeamModel addSelectedTeams = (TeamModel)selectableTeamsListBox.SelectedItem;

            if (addSelectedTeams != null)
            {
                selectableTeams.Remove(addSelectedTeams);
                selectedTeams.Add(addSelectedTeams);
            }
            ConnectFormToList();
        }

        private void RemoveSelectedTeamsButton_Click(object sender, EventArgs e)
        {
            TeamModel removeSelectedTeams = (TeamModel)selectedTeamsListBox.SelectedItem;

            if (removeSelectedTeams != null)
            {
                selectedTeams.Remove(removeSelectedTeams);
                selectableTeams.Add(removeSelectedTeams);
            }
            ConnectFormToList();
        }

        private void AddSelectedPrizesButton_Click(object sender, EventArgs e)
        {
            PrizeModel addSelectedPrizes = (PrizeModel)selectablePrizesListBox.SelectedItem;

            if (addSelectedPrizes != null)
            {
                selectablePrizes.Remove(addSelectedPrizes);
                selectedPrizes.Add(addSelectedPrizes);
            }
            ConnectFormToList();
        }

        private void RemoveSelectedPrizesButton_Click(object sender, EventArgs e)
        {
            PrizeModel removeSelectedPrizes = (PrizeModel)selectedPrizesListBox.SelectedItem;

            if (removeSelectedPrizes != null)
            {
                selectedPrizes.Remove(removeSelectedPrizes);
                selectablePrizes.Add(removeSelectedPrizes);
            }
            ConnectFormToList();
        }

        private void JumpToCreateNewTeamButton_Click(object sender, EventArgs e) => parentForm.setTabPage(2);

        private void JumpToCreateNewPrizeButton_Click(object sender, EventArgs e) => parentForm.setTabPage(3);

        private void updatableTournamentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatableTournament = (TournamentModel)updatableTournamentsComboBox.SelectedItem;
            updatableTornamentNameTextBox.Text = updatableTournament.TournamentName;
            updatableTornamentFeeTextBox.Text = updatableTournament.EntryFee.ToString("N0");
            selectableTeams = new List<TeamModel>();
            selectedTeams = new List<TeamModel>();
            selectablePrizes = new List<PrizeModel>();
            selectedPrizes = new List<PrizeModel>();

            selectedTeams = updatableTournament.EnteredTeams;
            selectableTeams = GlobalConfig.Connection.GetAllTeams();

            foreach (TeamModel selectedTeamModel in selectedTeams)
            {
                foreach (TeamModel selectableTeamModel in selectableTeams)
                {
                    if (selectableTeamModel.Id == selectedTeamModel.Id)
                    {
                        selectableTeams.Remove(selectableTeamModel);
                        break;
                    }
                }
            }

            selectedPrizes = updatableTournament.Prizes;
            selectablePrizes = GlobalConfig.Connection.GetAllPrizes();

            foreach (PrizeModel selectedPrizeModel in selectedPrizes)
            {
                foreach (PrizeModel selectablePrizeModel in selectablePrizes)
                {
                    if (selectablePrizeModel.Id == selectedPrizeModel.Id)
                    {
                        selectablePrizes.Remove(selectablePrizeModel);
                        break;
                    }
                }
            }
            ConnectFormToList();
        }

        private void removeSelectedTeamsFromTournamentButton_Click(object sender, EventArgs e)
        {
            TeamModel removeSelectedTeams = (TeamModel)currentSelectedTeamsListBox.SelectedItem;

            if (removeSelectedTeams != null)
            {
                selectedTeams.Remove(removeSelectedTeams);
                selectableTeams.Add(removeSelectedTeams);
            }
            ConnectFormToList();
        }

        private void addSelectedTeamsToTournamentButton_Click(object sender, EventArgs e)
        {
            TeamModel addSelectedTeams = (TeamModel)currentSelectableTeamsListBox.SelectedItem;

            if (addSelectedTeams != null)
            {
                selectableTeams.Remove(addSelectedTeams);
                selectedTeams.Add(addSelectedTeams);
            }
            ConnectFormToList();
        }

        private void removeSelectedPrizeFromTournamentButton_Click(object sender, EventArgs e)
        {
            PrizeModel removeSelectedPrizes = (PrizeModel)currentSelectedPrizesListBox.SelectedItem;

            if (removeSelectedPrizes != null)
            {
                selectedPrizes.Remove(removeSelectedPrizes);
                selectablePrizes.Add(removeSelectedPrizes);
            }
            ConnectFormToList();
        }

        private void addSelectedPrizeToTournamentButton_Click(object sender, EventArgs e)
        {
            PrizeModel addSelectedPrizes = (PrizeModel)currentSelectablePrizesListBox.SelectedItem;

            if (addSelectedPrizes != null)
            {
                selectablePrizes.Remove(addSelectedPrizes);
                selectedPrizes.Add(addSelectedPrizes);
            }
            ConnectFormToList();
        }

        private void updateTournomentButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm(selectedTeams, selectedPrizes, updatableTornamentNameTextBox.Text, updatableTornamentFeeTextBox.Text))
            {
                TournamentModel updatableTournamentModel = new TournamentModel(selectedTeams, selectedPrizes, updatableTornamentNameTextBox.Text, updatableTornamentFeeTextBox.Text);
                updatableTournamentModel.Id = updatableTournament.Id;
                
                GlobalConfig.Connection.UpdateTournament(updatableTournamentModel);

                updatableTournamentModel.Rounds = TournamentLogic.CreateRounds(updatableTournamentModel);

                MessageBox.Show("Tournament information updated!");

                updatableTornamentNameTextBox.Text = "Name of the tournament";
                updatableTornamentFeeTextBox.Text = "0";

                createEditTournamentsTabPanel.SelectedIndex = 0;
                createEditTournamentsTabPanel.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Error: Details provided are not valid! Please check information and try again.");
            }
        }

        private void deleteTournamentButton_Click(object sender, EventArgs e)
        {
            GlobalConfig.Connection.DeleteTournament(updatableTournament);

            MessageBox.Show("Tournament information deleted!");

            createEditTournamentsTabPanel.SelectedIndex = 0;
            createEditTournamentsTabPanel.SelectedIndex = 1;

            updatableTornamentNameTextBox.Text = "Name of the tournament";
            updatableTornamentFeeTextBox.Text = "0";
        }

        private void createEditTournamentsTabPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (createEditTournamentsTabPanel.SelectedIndex == 0)
            {
                selectableTeams = GlobalConfig.Connection.GetAllTeams();
                selectedTeams = new List<TeamModel>();
                selectablePrizes = GlobalConfig.Connection.GetAllPrizes();
                selectedPrizes = new List<PrizeModel>();
                ConnectFormToList();
            }
            else if (createEditTournamentsTabPanel.SelectedIndex == 1)
            {
                updatableTournaments = GlobalConfig.Connection.GetAllTournaments();
                selectableTeams = new List<TeamModel>();
                selectedTeams = new List<TeamModel>();
                selectablePrizes = new List<PrizeModel>();
                selectedPrizes = new List<PrizeModel>();
                ConnectFormToList();
            }
        }
    }
}
