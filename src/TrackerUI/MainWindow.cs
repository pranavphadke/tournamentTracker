using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class MainWindow : Form
    {
        TournamentDashboardForm tournamentDashboardForm;
        TournamentCreatorForm tournamentCreatorForm;
        TeamCreatorForm teamCreatorForm;
        PrizeCreatorForm prizeCreatorForm;
        public MainWindow()
        {
            InitializeComponent();
            tournamentDashboardForm = new TournamentDashboardForm(this);
            tournamentCreatorForm = new TournamentCreatorForm(this);
            teamCreatorForm = new TeamCreatorForm(this);
            prizeCreatorForm = new PrizeCreatorForm(this);

            // TODO - Check if forms can be resized depending on parent
            tournamentDashboardForm.TopLevel = false;
            tournamentDashboardForm.StartPosition= FormStartPosition.CenterParent;
            tournamentDashboardForm.SizeGripStyle = SizeGripStyle.Hide;
            tournamentDashboardForm.ShowInTaskbar = false;
            tournamentDashboardForm.ShowIcon = false;
            tournamentDashboardForm.MaximizeBox = false;
            tournamentDashboardForm.FormBorderStyle = FormBorderStyle.None;
            tournamentDashboardForm.ControlBox = false;

            tournamentCreatorForm.TopLevel = false;
            tournamentCreatorForm.StartPosition = FormStartPosition.CenterParent;
            tournamentCreatorForm.SizeGripStyle = SizeGripStyle.Hide;
            tournamentCreatorForm.ShowInTaskbar = false;
            tournamentCreatorForm.ShowIcon = false;
            tournamentCreatorForm.MaximizeBox = false;
            tournamentCreatorForm.FormBorderStyle = FormBorderStyle.None;
            tournamentCreatorForm.ControlBox = false;

            teamCreatorForm.TopLevel = false;
            teamCreatorForm.StartPosition = FormStartPosition.CenterParent;
            teamCreatorForm.SizeGripStyle = SizeGripStyle.Hide;
            teamCreatorForm.ShowInTaskbar = false;
            teamCreatorForm.ShowIcon = false;
            teamCreatorForm.MaximizeBox = false;
            teamCreatorForm.FormBorderStyle = FormBorderStyle.None;
            teamCreatorForm.ControlBox = false;

            prizeCreatorForm.TopLevel = false;
            prizeCreatorForm.StartPosition = FormStartPosition.CenterParent;
            prizeCreatorForm.SizeGripStyle = SizeGripStyle.Hide;
            prizeCreatorForm.ShowInTaskbar = false;
            prizeCreatorForm.ShowIcon = false;
            prizeCreatorForm.MaximizeBox = false;
            prizeCreatorForm.FormBorderStyle = FormBorderStyle.None;
            prizeCreatorForm.ControlBox = false;

            tournamentDashboardTab.Controls.Add(tournamentDashboardForm);
            tournamentDashboardForm.Show();
            tournamentCreatorTab.Controls.Add(tournamentCreatorForm);
            tournamentCreatorForm.Show();
            teamCreatorTab.Controls.Add(teamCreatorForm);
            teamCreatorForm.Show();
            prizeCreatorTab.Controls.Add(prizeCreatorForm);
            prizeCreatorForm.Show();
        }
        
        /// <summary>
        /// Allows control of main window tab switching from other child forms
        /// </summary>
        /// <param name="page">New tab index number. 0-Dashboard,1-TournamentCreator,2-TeamCreator,3-PrizeCreator</param>
        public void setTabPage(int page)
        {
            mainWindowTabControl.SelectedIndex = page;
        }

        public void mainWindowTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Refresh TournamentDashboard form for any new tournament or updates
            if (mainWindowTabControl.SelectedIndex == 0)
            {
                tournamentDashboardForm.ConnectFormToList();
            }
            
        }
    }
}
