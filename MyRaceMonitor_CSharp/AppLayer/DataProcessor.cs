using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RaceData;
using RaceData.Messages;

namespace AppLayer
{
    public class DataProcessor : IAthleteUpdateHandler
    {
        public void ProcessUpdate(AthleteUpdate updateMessage)
        {
            // TODO: Do something to process the update message, depending on the concrete type of message

            if (updateMessage.UpdateType == AthleteRaceStatus.Registered)
            {
                //create athlete object, and push it to lvCurrentAthletes
            }
            if (updateMessage.UpdateType == AthleteRaceStatus.Started)
            {
                //get id of athlete that started, track start time
            }
            if (updateMessage.UpdateType == AthleteRaceStatus.DidNotFinish)
            {
                //get id of athlete, give null times for end time and total time
            }
            if (updateMessage.UpdateType == AthleteRaceStatus.DidNotStart)
            {
                //get id of registered athlete, do not start time
            }
            if (updateMessage.UpdateType == AthleteRaceStatus.OnCourse)
            {
                //get athlete id, current position
            }
            if (updateMessage.UpdateType == AthleteRaceStatus.Finished)
            {
                //get athlete id, end time, comput final time, remove from lvcurAthlete
            }
            // TODO: Note that the console write line does below here

            Console.WriteLine(updateMessage.ToString());
        }
    }
}
