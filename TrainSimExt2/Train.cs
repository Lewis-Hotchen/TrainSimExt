using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainSimExt {
    class Train {
        public int ID { get; } //ID to identify the train
        public Journey TrainJourney { get; set; } //All the properties for the journey
        public Stop CurrStop { get; set; }  //Current stop the train is at
        public double TimeRunning { get; set; } //how long the train has been running

        public Train(int id) {
            ID = id;
            TrainJourney = null;
            CurrStop = null;
        }//constructor

        /// <summary>
        /// This method kicks off the train
        /// </summary>
        /// <param name="journey"></param>
        /// <returns></returns>
        public async Task<string> StartTrain(Journey journey) {
            TrainJourney = journey;                 //Set the journey passed in from the parameters
            if (CurrStop == null) {                 //If the current stop is empty
                CurrStop = TrainJourney.FirstStop;  //Set the current stop to the first
            }

            Task<string> getUpdate = Task.Run(() => MoveTrain());   //Setup task to simulate train
            String update = await getUpdate;    //Save result in string
            return update;                      //Return the result
        }//StartTrain

        /// <summary>
        /// This handles the simulation of time passing
        /// </summary>
        /// <returns></returns>
        public string MoveTrain() {
            double Ttime = 0.0;                                 //Measure the amount of time it takes
            int distance = CurrStop.MilesToNext;                //This is the distance it takes to get to the next stop
            Ttime = (double)distance / TrainJourney.Speed;      //use speed = distance / time equation to calculate time
            CurrStop.IsOccupied = false;                        //make the current stop not occupied
            Thread.Sleep((int)(Ttime * 60) * 1000);             //Wait for the alotted time (1000x as it must be milliseconds - Simulated in seconds for convenience)
            if (CurrStop.NextStop != null) {                    //If the next stop exists
                CurrStop = CurrStop.NextStop;                   //Set the current stop to the next
                CurrStop.IsOccupied = true;                     //Occupy the stop
            }
            TimeRunning += Ttime * 60;          //Add on the time to keep track of how long has passed
            if(CurrStop.NextStop == null) {     //If the next stop is empty
                //Return the string that the train has reached it's destination
                return "Train has reached destination: " + CurrStop.Name + " at " + TimeRunning + " minutes";
            } else {
                //Return the string that the train is at the next stop with timestamp
                return "Stopped at " + CurrStop.Name + ", at " + TimeRunning + " minutes"; 
            }//if else
           
        }//moveTrain

    }//class
}//namespace
