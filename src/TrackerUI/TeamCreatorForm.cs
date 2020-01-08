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
    public partial class TeamCreatorForm : Form
    {
        private List<PersonModel> selectableTeamMembers = new List<PersonModel>();
        private List<PersonModel> updatablePersons = new List<PersonModel>();
        private List<TeamModel> updatableTeams = new List<TeamModel>();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private PersonModel updatablePerson;
        private TeamModel updatableTeam;
        private Form parentForm;

        public TeamCreatorForm()
        {
            InitializeComponent();
            selectableTeamMembers = GlobalConfig.Connection.GetAllPersons();
            ConnectFormToList();
        }

        public TeamCreatorForm(MainWindow mainForm)
        {
            InitializeComponent();
            parentForm = mainForm;
            selectableTeamMembers = GlobalConfig.Connection.GetAllPersons();
            ConnectFormToList();
        }

        private void ConnectFormToList()
        {
            selectableTeamMembersListBox.DataSource = null;
            selectedTeamMembersListBox.DataSource = null;
            updatableTeamMembersComboBox.DataSource = null;
            currentSelectedTeamMembersListBox.DataSource = null;
            currentSelectableTeamMembersListBox.DataSource = null;

            updatableTeamMembersComboBox.DataSource = updatablePersons;
            updatableTeamComboBox.DataSource = updatableTeams;

            if(createEditTeamsTabPanel.SelectedIndex == 0)
            {
                if (selectableTeamMembers != null)
                {
                    selectableTeamMembersListBox.DataSource = selectableTeamMembers;
                }
                if (selectedTeamMembers != null)
                {
                    selectedTeamMembersListBox.DataSource = selectedTeamMembers;
                }
                selectableTeamMembersListBox.DisplayMember = "GetFullName";
                selectedTeamMembersListBox.DisplayMember = "GetFullName";
            }
            else if (createEditTeamsTabPanel.SelectedIndex == 1)
            {
                if (selectableTeamMembers != null)
                {
                    currentSelectableTeamMembersListBox.DataSource = selectableTeamMembers;
                }
                if (selectedTeamMembers != null)
                {
                    currentSelectedTeamMembersListBox.DataSource = selectedTeamMembers;
                }
                currentSelectableTeamMembersListBox.DisplayMember = "GetFullName";
                currentSelectedTeamMembersListBox.DisplayMember = "GetFullName";
            }

            updatableTeamMembersComboBox.DisplayMember = "GetFullName";
            updatableTeamComboBox.DisplayMember = "TeamName";
        }

        /// <summary>
        /// Checks 'Add New Member' form for valid fields
        /// </summary>
        /// <param name="memberFirstNameTextBox">First name of the new member(Required)</param>
        /// <param name="memberMiddleNameTextBox">Middle name of the new member(Optional)</param>
        /// <param name="memberLastNameTextBox">Last name of the new member(Required)</param>
        /// <param name="memberEmailTextBox">Email address of the new member(Required)</param>
        /// <param name="memberPhoneNumberTextBox">Cellphone number of the new member(Required)</param>
        /// <returns>bool True for valid form</returns>
        private bool ValidateForm(string memberFirstNameTextBox, string memberMiddleNameTextBox, string memberLastNameTextBox, string memberEmailTextBox, string memberPhoneNumberTextBox)
        {
            bool formValid = true;

            if (memberFirstNameTextBox.Length == 0 || memberLastNameTextBox.Length == 0)
            {
                formValid = false;
            }
            if (memberMiddleNameTextBox == "Middle name")
            {
                newMemberMiddleNameTextBox.Text = "";
            }
            if (memberEmailTextBox.Length == 0 || memberEmailTextBox == "E-mail address")
            {
                formValid = false;
            }
            if (memberPhoneNumberTextBox.Length == 0 && memberPhoneNumberTextBox == "xxxyyyzzzz")
            {
                formValid = false;
            }

            return formValid;
        }

        /// <summary>
        /// Checks 'New Team Form' for valid fields
        /// </summary>
        /// <param name="selectedPersonModelList">List of team members(minimum one team member required)</param>
        /// <param name="teamNameTextBox">Name of the new team(Required)</param>
        /// <returns>bool True if the form is valid</returns>
        private bool ValidateForm(List<PersonModel> selectedPersonModelList, string teamNameTextBox)
        {
            bool formValid = true;
            if (selectedPersonModelList == null)
            {
                formValid = false;
            }
            if (teamNameTextBox == "Name of the team" || teamNameTextBox == null)
            {
                formValid = false;
            }
            return formValid;
        }

        private void AddNewMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm(newMemberFirstNameTextBox.Text, newMemberMiddleNameTextBox.Text, newMemberLastNameTextBox.Text, newMemberEmailTextBox.Text, newMemberPhoneNumberTextBox.Text))
            {
                PersonModel newPersonModel = new PersonModel(
                    newMemberFirstNameTextBox.Text, 
                    newMemberMiddleNameTextBox.Text, 
                    newMemberLastNameTextBox.Text, 
                    newMemberEmailTextBox.Text, 
                    newMemberPhoneNumberTextBox.Text);

                GlobalConfig.Connection.CreatePerson(newPersonModel);

                if (newPersonModel != null)
                {
                    selectedTeamMembers.Add(newPersonModel);
                }

                ConnectFormToList();

                newMemberFirstNameTextBox.Text = "First name";
                newMemberMiddleNameTextBox.Text = "Middle name";
                newMemberLastNameTextBox.Text = "Last name";
                newMemberEmailTextBox.Text = "E-mail address";
                newMemberPhoneNumberTextBox.Text = "xxxyyyzzzz";

                MessageBox.Show("New member added!");
            }
            else
            {
                MessageBox.Show("Error: Details provided are not valid! Please check information and try again.");
            }
        }

        private void CreateNewTeamButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm(selectedTeamMembers, newTeamNameTextBox.Text))
            {
                TeamModel newTeamModel = new TeamModel(selectedTeamMembers, newTeamNameTextBox.Text);

                GlobalConfig.Connection.CreateTeam(newTeamModel);

                MessageBox.Show("New team created!");

                newTeamNameTextBox.Text = "Name of the team";

                addEditMembersTabPanel.SelectTab("addMember");
                addEditMembersTabPanel.SelectTab("editMember");
            }
            else
            {
                MessageBox.Show("Error: Details provided are not valid! Please check information and try again.");
            }
        }

        private void AddSelectedTeamMembersButton_Click(object sender, EventArgs e)
        {
            PersonModel addSelectedPersons = (PersonModel)selectableTeamMembersListBox.SelectedItem;

            if(addSelectedPersons != null)
            {
                selectableTeamMembers.Remove(addSelectedPersons);
                selectedTeamMembers.Add(addSelectedPersons);
            }

            ConnectFormToList();
        }

        private void RemoveSelectedTeamMembersButton_Click(object sender, EventArgs e)
        {
            PersonModel removeSelectedPersons = (PersonModel)selectedTeamMembersListBox.SelectedItem;

            if (removeSelectedPersons != null)
            {
                selectedTeamMembers.Remove(removeSelectedPersons);
                selectableTeamMembers.Add(removeSelectedPersons);
            }

            ConnectFormToList();
        }



        private void UpdatableTeamMembersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonModel updateSelectedPerson = (PersonModel)updatableTeamMembersComboBox.SelectedItem;

            if (updateSelectedPerson != null)
            {
                updatablePerson = updateSelectedPerson;
                updateMemberFirstNameTextBox.Text = updateSelectedPerson.FirstName;
                updateMemberMiddleNameTextBox.Text = updateSelectedPerson.MiddleName;
                updateMemberLastNameTextBox.Text = updateSelectedPerson.LastName;
                updateMemberEmailTextBox.Text = updateSelectedPerson.EmailAddress;
                updateMemberPhoneNumberTextBox.Text = updateSelectedPerson.CellphoneNumber;
            }
        }

        private void UpdateMemberInfoButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm(updateMemberFirstNameTextBox.Text, updateMemberMiddleNameTextBox.Text, updateMemberLastNameTextBox.Text, updateMemberEmailTextBox.Text, updateMemberPhoneNumberTextBox.Text))
            {
                updatablePerson.FirstName=updateMemberFirstNameTextBox.Text;
                updatablePerson.MiddleName=updateMemberMiddleNameTextBox.Text;
                updatablePerson.LastName=updateMemberLastNameTextBox.Text;
                updatablePerson.EmailAddress=updateMemberEmailTextBox.Text;
                updatablePerson.CellphoneNumber=updateMemberPhoneNumberTextBox.Text;

                GlobalConfig.Connection.UpdatePerson(updatablePerson);

                MessageBox.Show("Member information updated!");

                addEditMembersTabPanel.SelectTab("addMember");
                addEditMembersTabPanel.SelectTab("editMember");
            }
            else
            {
                MessageBox.Show("Error: Details provided are not valid! Please check information and try again.");
            }
        }

        private void AddEditMembersTabPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatablePersons = GlobalConfig.Connection.GetAllPersons();
            selectableTeamMembers = GlobalConfig.Connection.GetAllPersons();
            selectedTeamMembers = new List<PersonModel>();

            ConnectFormToList();
        }

        private void DeleteMemberInfoButton_Click(object sender, EventArgs e)
        {
            GlobalConfig.Connection.DeletePerson(updatablePerson);

            MessageBox.Show("Member information deleted!");

            addEditMembersTabPanel.SelectTab("addMember");
            addEditMembersTabPanel.SelectTab("editMember");
        }

        private void CreateEditTeamsTabPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (createEditTeamsTabPanel.SelectedIndex == 0)
            {
                selectableTeamMembers = GlobalConfig.Connection.GetAllPersons();
                selectedTeamMembers = new List<PersonModel>();
                ConnectFormToList();
            }
            else if (createEditTeamsTabPanel.SelectedIndex == 1)
            {
                updatableTeams = GlobalConfig.Connection.GetAllTeams();
                selectableTeamMembers = new List<PersonModel>();
                selectedTeamMembers = new List<PersonModel>();
                ConnectFormToList();
            }
        }

        private void UpdatableTeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatableTeam = (TeamModel)updatableTeamComboBox.SelectedItem;
            updatableTeamNameTextBox.Text = updatableTeam.TeamName;
            selectableTeamMembers = new List<PersonModel>();
            selectedTeamMembers = new List<PersonModel>();

            selectedTeamMembers = updatableTeam.TeamMembers;
            selectableTeamMembers = GlobalConfig.Connection.GetAllPersons();
            
            foreach (PersonModel selectedPersonModel in selectedTeamMembers)    
            {
                foreach (PersonModel selectablePersonModel in selectableTeamMembers)
                {
                    if (selectablePersonModel.Id == selectedPersonModel.Id)
                    {
                        selectableTeamMembers.Remove(selectablePersonModel);
                        break;
                    }
                }
            }

            ConnectFormToList();
        }

        private void removeSelectedTeamMemberFromTeamButton_Click(object sender, EventArgs e)
        {
            PersonModel removeSelectedPersons = (PersonModel)currentSelectedTeamMembersListBox.SelectedItem;

            if (removeSelectedPersons != null)
            {
                selectedTeamMembers.Remove(removeSelectedPersons);
                selectableTeamMembers.Add(removeSelectedPersons);
            }

            ConnectFormToList();
        }

        private void addSelectedTeamMemberToTeamButton_Click(object sender, EventArgs e)
        {
            PersonModel addSelectedPersons = (PersonModel)currentSelectableTeamMembersListBox.SelectedItem;

            if (addSelectedPersons != null)
            {
                selectableTeamMembers.Remove(addSelectedPersons);
                selectedTeamMembers.Add(addSelectedPersons);
            }

            ConnectFormToList();
        }

        private void updateTeamInfoButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm(selectedTeamMembers, updatableTeamNameTextBox.Text))
            {
                updatableTeam.TeamName = updatableTeamNameTextBox.Text;
                updatableTeam.TeamMembers = selectedTeamMembers;

                GlobalConfig.Connection.UpdateTeam(updatableTeam);

                MessageBox.Show("Team information updated!");

                updatableTeamNameTextBox.Text = "Name of the team";

                createEditTeamsTabPanel.SelectTab("createTeam");
                createEditTeamsTabPanel.SelectTab("editTeam");
            }
            else
            {
                MessageBox.Show("Error: Details provided are not valid! Please check information and try again.");
            }
        }

        private void deleteTeamInfoButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm(selectedTeamMembers, updatableTeamNameTextBox.Text))
            {
                GlobalConfig.Connection.DeleteTeam(updatableTeam);

                MessageBox.Show("Team deleted!");

                updatableTeamNameTextBox.Text = "Name of the team";

                createEditTeamsTabPanel.SelectTab("createTeam");
                createEditTeamsTabPanel.SelectTab("editTeam");
            }
            else
            {
                MessageBox.Show("Error: Details provided are not valid! Please check information and try again.");
            }
        }
    }
}
