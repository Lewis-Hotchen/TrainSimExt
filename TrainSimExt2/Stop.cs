using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSimExt {
    public class Stop {
        public Stop NextStop { get; set; }      //Next stop
        public string Name { get; set; }        //Name of the stop
        public int MilesToNext { get; set; }    //No of miles to the next stop
        public bool IsOccupied { get; set; }    //If there is a train at this stop

        public Stop(string name, int milesToNext) {
            Name = name;
            MilesToNext = milesToNext;
        }//Constructor

        /// <summary>
        /// Use this when displaying a stop
        /// </summary>
        /// <returns></returns>
        public String getStopDetails() {
            return "\n" + "Name: " + Name + " Miles to Next: " + MilesToNext;
        }

        /// <summary>
        /// Use this when displaying the destination
        /// </summary>
        /// <returns></returns>
        public String getLastStopDetails() {
            return "\n" + "Name: " + Name + " Last Stop";
        }
    }//class
}//namespace
