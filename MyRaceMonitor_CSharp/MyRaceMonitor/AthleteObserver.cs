using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRaceMonitor
{
    public partial class AthleteObserver : Form
    {
        private readonly Dictionary<int, Athlete> _athletesBeingObserved = new Dictionary<int, Athlete>();

        protected bool UpdateNeeded;
        private readonly Timer _refreshTester = new Timer();
        private readonly object _myLock = new object();

        public AthleteObserver()
        {
            InitializeComponent();
        }
        public int RefreshFrequency { get; set; }
        public string Title { get;  set; }
        public virtual void Update(Subject subject)
        {
            var athlete = subject as Athlete;
            if (athlete == null)
                return;

            lock (_myLock)
            {
                if (!_athletesBeingObserved.ContainsKey(athlete.BibNumber))
                    _athletesBeingObserved.Add(athlete.BibNumber, athlete);
                else
                    _athletesBeingObserved[athlete.BibNumber] = athlete;
            }
            UpdateNeeded = true;
        }
        protected void StartRefreshTimer()
        {
            if (RefreshFrequency <= 0)
                RefreshFrequency = 50;

            _refreshTester.Interval = RefreshFrequency;
            _refreshTester.Tick += refreshTimer_Tick;
            _refreshTester.Start();
        }
        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            if (UpdateNeeded)
            {
                lock (_myLock)
                {
                    RefreshDisplay();
                    UpdateNeeded = false;
                }
            }
        }
        protected virtual void RefreshDisplay() { }

        protected void UnregisterFromAllSubjects()
        {
            var iterator = _athletesBeingObserved.GetEnumerator();
            while (iterator.MoveNext())
                iterator.Current.Value.Unsubscribe(this);
        }

        protected List<Athlete> AthletesBeingObserved => _athletesBeingObserved.Values.ToList();

    }
}
