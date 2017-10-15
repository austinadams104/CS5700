using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLayer;

namespace MyRaceMonitor
{
    public partial class MainForm : Form
    {
        private readonly List<Athlete> _knownAthletes = new List<Athlete>();
        private readonly List<AthleteObserver> _knownDisplays = new List<AthleteObserver>();
        private AthleteObserver _selectedObserver;

        public MainForm()
        {
            InitializeComponent();
        }

        private void RefreshObversersListView()
        {
            lvObservers.Items.Clear();
            foreach (AthleteObserver observer in _knownDisplays)
            {
                ListViewItem item = new ListViewItem(observer.Title);
                lvObservers.Items.Add(item);
            }
        }

        private void RefreshAthleteLists()
        {
            lvObservedAthletes.Items.Clear();
            lvCurrentAthlete.Items.Clear();

            if (_selectedObserver != null)
                observedBallsLabel.Text = @"Subjects of " + _selectedObserver.Title;
            else
                observedBallsLabel.Text = @"No obverser selected";

            foreach (Athlete athlete in _knownAthletes)
            {
                var item = new ListViewItem(new[]
                {
                    athlete.BibNumber.ToString(),
                    athlete.FirstName.ToString() + athlete.LastName.ToString(),
                    athlete.Age.ToString(),
                    athlete.Status.ToString()
                })
                { Tag = athlete };
                if (_selectedObserver != null && athlete.Subscribers.Contains(_selectedObserver))
                    lvObservedAthletes.Items.Add(item);
                else
                    lvObservedAthletes.Items.Add(item);
            }
        }

        private void btStartRace_Click(object sender, EventArgs e)
        {
            SimulatorController controller = new SimulatorController();
            if (cbRaceCourse.Text == "Short Race Simulation")
                controller.Run("../../../SimulationData/Short Race Simulation-01.csv");
            else if (cbRaceCourse.Text == "Long Race Simulation")
                controller.Run("../../../SimulationData/Century Simulation-01.csv");
        }

        private void btCreateObserver_Click(object sender, EventArgs e)
        {
            var modalDialogForm = new ObserverCreatorForm
            {
                Text = @"New Observer",
                ObserverTitle = $"Observer #{_knownDisplays.Count + 1}"
            };
            if (modalDialogForm.ShowDialog() == DialogResult.OK)
            {
                AthleteObserver observer;
                if (modalDialogForm.ObserverType == "L")
                    observer = new ListDisplay();
                else if (modalDialogForm.ObserverType == "G")
                    observer = new GraphicalDisplay();
                else if (modalDialogForm.ObserverType == "E")
                    observer = new EmailDisplay();
                else if (modalDialogForm.ObserverType == "C")
                    observer = new CompareDisplay();
                else 
                    observer = new BestTimesDisplay();

                observer.Title = modalDialogForm.ObserverTitle;
                _knownDisplays.Add(observer);
                observer.Show();

                _selectedObserver = null;
                lvObservers.SelectedIndices.Clear();
                RefreshObversersListView();
                RefreshAthleteLists();
            }

        }

        private void btSubscribe_Click(object sender, EventArgs e)
        {

        }

        private void btUnscribe_Click(object sender, EventArgs e)
        {

        }

        private void cbRaceEvent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbRaceCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
