using System;
using System.Windows.Forms;

namespace MyRaceMonitor
{
    public partial class ListDisplay : AthleteObserver
    {
        public ListDisplay()
        {
            InitializeComponent();
        }
        protected override void RefreshDisplay()
        {
            lvAthleteList.Items.Clear();
            foreach (Athlete athlete in AthletesBeingObserved)
            {
                ListViewItem item = new ListViewItem(new[]
                {
                    athlete.BibNumber.ToString(),
                    athlete.FirstName.ToString() + " " + athlete.LastName.ToString(),
                    athlete.Age.ToString(),
                    athlete.StartTime.ToString(),
                    athlete.Position.ToString(),
                    athlete.EndTime.ToString(),
                    athlete.Status.ToString()
                });
                lvAthleteList.Items.Add(item);
            }
        }

        private void ListDisplay_Load(object sender, EventArgs e)
        {
            Text = Title;
            StartRefreshTimer();
        }
    }
}
