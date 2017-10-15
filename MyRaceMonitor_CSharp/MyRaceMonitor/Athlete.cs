using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRaceMonitor
{
    public class Athlete : Subject
    {
        public virtual int BibNumber { get; set; }
        public virtual int Age { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime EndTime { get; set; }
        public virtual double CompletedTime { get; set; }
        public virtual double Position { get; set; }
        public virtual AthleteStatus Status { get; set; } 
        public enum AthleteStatus { Registered, Started, DidNotStart, DidNotFinish, Finished, Location }
        
        public Athlete()
        {

        }
        public virtual void Start()
        {
        }

        public virtual void Stop()
        {
           
        }
    }


}
