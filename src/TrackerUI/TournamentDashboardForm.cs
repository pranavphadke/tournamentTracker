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
    public partial class TournamentDashboardForm : Form
    {
        private MainWindow parentForm;
        private List<TournamentModel> selectableTournaments = new List<TournamentModel>();
        private TournamentModel selectedTournament;
        private List<int> selectableMatchupNumbers;
        private List<MatchupModel> selectableMatchups;
        private MatchupModel selectedMatchup;
        private List<MatchupEntryModel> selectableMatchupEntries;
        private List<int> rounds;
        private int selectedRound;
        private MatchupEntryModel winningMatchupEntry;
        bool bye;

        public TournamentDashboardForm()
        {
            InitializeComponent();
            ConnectFormToList();
        }

        public TournamentDashboardForm(MainWindow mainForm)
        {
            InitializeComponent();
            parentForm = mainForm;
            ConnectFormToList();
        }

        public void ConnectFormToList()
        {
            tournamentNameComboBox.DataSource = null; 
            selectableTournaments = GlobalConfig.Connection.GetAllTournaments();
            if (selectableTournaments.Count() > 0)
            {
                tournamentNameComboBox.DataSource = selectableTournaments;
                tournamentNameComboBox.DisplayMember = "TournamentName"; 
            }
            else
            {
                tournamentNameComboBox.DataSource = null;
                tournamentNameComboBox.Text = "-";
            }
        }

        private void jumpCreateTournamentButton_Click(object sender, EventArgs e) => parentForm.setTabPage(1);

        private void tournamentNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTournament = (TournamentModel)tournamentNameComboBox.SelectedItem;
            rounds = new List<int>();
            if (selectedTournament!=null)
            {
                for (int i = 1; i <= selectedTournament.Rounds.Count(); i++) rounds.Add(i);
                //roundNumberComboBox.DataSource = null;
                roundNumberComboBox.DataSource = rounds;               
            }
            else
            {
                roundNumberComboBox.DataSource = null;
                roundNumberComboBox.SelectedItem = null;
                roundNumberComboBox.Text = "-";
            }
        }

        private void roundNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {           
            
            int i = 0;
            selectableMatchupNumbers = new List<int>();
            selectableMatchups = new List<MatchupModel>();
            if (roundNumberComboBox.SelectedItem!=null)
            {
                selectedRound = (int)roundNumberComboBox.SelectedItem;
                foreach (MatchupModel matchupModel in selectedTournament.Rounds[selectedRound - 1])
                {

                    if (!unplayedOnlyCheckBox.Checked)
                    {
                        i += 1;
                        selectableMatchupNumbers.Add(i);
                        selectableMatchups.Add(matchupModel);
                    }
                    else if (unplayedOnlyCheckBox.Checked && matchupModel.Winner == null)
                    {
                        i += 1;
                        selectableMatchupNumbers.Add(i);
                        selectableMatchups.Add(matchupModel);
                    }
                } 
            }
            if (selectableMatchupNumbers.Count() == 0 || roundNumberComboBox.SelectedItem==null)
            {
                matchupNameComboBox.DataSource = null;
                matchupNameComboBox.SelectedItem = null;
                matchupNameComboBox.Text = "-";
            }
            else
            {
                matchupNameComboBox.DataSource = selectableMatchupNumbers;
            }           
        }

        private void matchupNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (matchupNameComboBox.SelectedItem!=null)
            {
                selectedMatchup = selectableMatchups[(int)matchupNameComboBox.SelectedItem - 1];
                selectableMatchupEntries = selectedMatchup.Entries;
                int j = 1;
                bye = false;
                foreach (MatchupEntryModel matchupEntry in selectableMatchupEntries)
                {
                    if (j == 1)
                    {
                        if (matchupEntry.TeamCompeting == null && selectedRound == 1)
                        {
                            team1NameLabel.Text = "-";
                            team1ScoreTextBox.Text = "-";
                            team2ScoreTextBox.Text = "-";
                            bye = true;

                        }
                        else if (matchupEntry.TeamCompeting == null && selectedRound > 1) team1NameLabel.Text = "TBA";
                        else
                        {
                            team1NameLabel.Text = matchupEntry.TeamCompeting.TeamName;
                            team1ScoreTextBox.Text = matchupEntry.Score.ToString();
                        }
                    }
                    else
                    {
                        if (matchupEntry.TeamCompeting == null && selectedRound == 1)
                        {
                            team2NameLabel.Text = "-";
                            team2ScoreTextBox.Text = "-";
                            team1ScoreTextBox.Text = "-";
                            bye = true;
                        }
                        else if (matchupEntry.TeamCompeting == null && selectedRound > 1) team2NameLabel.Text = "TBA";
                        else
                        {
                            team2NameLabel.Text = matchupEntry.TeamCompeting.TeamName;
                            team2ScoreTextBox.Text = matchupEntry.Score.ToString();
                        }
                    }
                    j += 1;
                }

                // If displaying a bye Matchup, determine the winner and update DB
                if (selectedMatchup.Winner == null && selectedRound < selectedTournament.Rounds.Count() && bye)
                {
                    winningMatchupEntry = TournamentLogic.DetermineWinner(selectableMatchupEntries[0], selectableMatchupEntries[1]);
                    winningTeamNameLabel.Text = winningMatchupEntry.TeamCompeting.TeamName;
                    selectedMatchup.Winner = winningMatchupEntry.TeamCompeting;
                    selectedMatchup.WinnerId = winningMatchupEntry.TeamCompeting.Id;

                    GlobalConfig.Connection.UpdateMatchup(selectedMatchup);

                    // Add winning TeamModel to next round's Matchupup corresponding to the winning team's MatchupId
                    foreach (MatchupModel matchupModel in selectedTournament.Rounds[selectedRound])
                    {
                        foreach (MatchupEntryModel matchupEntryModel in matchupModel.Entries)
                        {
                            if (matchupEntryModel.ParentMatchupId == selectedMatchup.Id)
                            {
                                matchupEntryModel.TeamCompeting = winningMatchupEntry.TeamCompeting;
                                matchupEntryModel.TeamCompetingId = winningMatchupEntry.TeamCompeting.Id;
                                GlobalConfig.Connection.UpdateMatchupEntry(matchupEntryModel);
                            }
                        }
                    }
                    ConnectFormToList();
                    roundNumberComboBox.SelectedIndex = 0;
                }
                else if (selectedMatchup.Winner == null && !bye) winningTeamNameLabel.Text = "TBD";
                else winningTeamNameLabel.Text = selectedMatchup.Winner.TeamName; 
            }
            else
            {
                team1NameLabel.Text = "-";
                team1ScoreTextBox.Text = "-";
                team2NameLabel.Text = "-";
                team2ScoreTextBox.Text = "-";
                winningTeamNameLabel.Text = "-";
            }
        }
        

        private void updateScoreButton_Click(object sender, EventArgs e)
        {
            if (!bye)
            {
                // Update MatchupEntries with current score
                if (ValidateForm(team1ScoreTextBox.Text, team2ScoreTextBox.Text))
                {
                    selectableMatchupEntries[0].Score = Convert.ToDouble(team1ScoreTextBox.Text);
                    selectableMatchupEntries[1].Score = Convert.ToDouble(team2ScoreTextBox.Text);
                    foreach (MatchupEntryModel matchupEntry in selectableMatchupEntries)
                    {
                        GlobalConfig.Connection.UpdateMatchupEntry(matchupEntry);
                    }

                    // Determine winner
                    winningMatchupEntry = TournamentLogic.DetermineWinner(selectableMatchupEntries[0], selectableMatchupEntries[1]);
                    winningTeamNameLabel.Text = winningMatchupEntry.TeamCompeting.TeamName;

                    // Add winning MatchupEntryModel to MatchupModel
                    selectedMatchup.Winner = winningMatchupEntry.TeamCompeting;
                    selectedMatchup.WinnerId = winningMatchupEntry.TeamCompeting.Id;

                    // Update MatchupModel
                    GlobalConfig.Connection.UpdateMatchup(selectedMatchup);

                    // Add winning MatchupEntry to next round's Matchup unless current round is the last round
                    if (selectedRound != rounds.Count())
                    {
                        foreach (MatchupModel matchupModel in selectedTournament.Rounds[selectedRound])
                        {
                            foreach (MatchupEntryModel matchupEntryModel in matchupModel.Entries)
                            {
                                if (matchupEntryModel.ParentMatchupId == selectedMatchup.Id)
                                {
                                    matchupEntryModel.TeamCompeting = winningMatchupEntry.TeamCompeting;
                                    matchupEntryModel.TeamCompetingId = winningMatchupEntry.TeamCompeting.Id;
                                    GlobalConfig.Connection.UpdateMatchupEntry(matchupEntryModel);
                                }
                            }
                        }
                    }

                    // Update Lists
                    ConnectFormToList();
                    roundNumberComboBox.SelectedIndex = 0;
                }
                else MessageBox.Show("Please enter a valid score");
            }
        }

        private void unplayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ConnectFormToList();
        }

        private bool ValidateForm(string team1Score,string team2Score)
        {
            bool formValid = true;
            double op;

            if(!double.TryParse(team1Score, out op) || !double.TryParse(team2Score, out op)) formValid= false;

            return formValid;
        }
    }
}
