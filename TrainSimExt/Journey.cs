using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSimExt {
    class Journey {
        public int Distance { get; set; }   //This is in miles
        public int Time { get; set; }          //This is in hours
        public int Speed { get; set; }         //This is in mph
        public Stop FirstStop { get; set; } //The first stop in the journey
        public Journey(Stop firstStop, int speed) {
            Speed = speed;
            //Set firststop
            FirstStop = firstStop;
            CalcDistTime();
        }//constructor

        /// <summary>
        /// Add a stop onto the journey
        /// </summary>
        /// <param name="newStop"></param>
        public void AddStop(Stop newStop) {
            Stop temp = FirstStop;
            while(temp.NextStop != null) {
                temp = temp.NextStop;
            }
            temp.NextStop = newStop;
            CalcDistTime();
        }//addStop
        
        /// <summary>
        /// Calculates the distance of the journey (updates every time a new stop is added)
        /// </summary>
        private void CalcDistTime() {
            //Calculate the distance from all the stops
            Stop temp = FirstStop;
            while (temp != null) {
                Distance += temp.MilesToNext;
                temp = temp.NextStop;
            }

            //Calcualte the time the journey takes
            Time = Distance / Speed;
        }
    }//class
}//namespace
