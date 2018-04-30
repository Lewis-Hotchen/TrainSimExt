using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainSimExt {

    public partial class trainSim : Form {

        private Train train;        //The train which will run
        private Journey journey;    //The journey the train will take

        public trainSim() {
            InitializeComponent();
        }//constructor

        /// <summary>
        /// This button event is what kicks off the train
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnGo_Click(object sender, EventArgs e) {
            btnAddStop.Enabled = false;                             //Disable addstop for duration of journey
            Stop Ttracker;
            if (testString(txtName.Text)) {                         //Tests if the ID is valid
                train = new Train(Convert.ToInt32(txtName.Text));   //Instatiate the train
                String res = "";                                    //String that holds the result of the update

                if (journey != null || journey.FirstStop.NextStop == null) { //Tests if the journey is not null or if the first stop has no other stops
                    Ttracker = journey.FirstStop;                            //Set temporary stop to the first stop in the journey
                    lblStops.Text = "Stops:";                                //Set the text for the stops overview label
                    do {
                        //The next stop is null
                        if (Ttracker.NextStop == null) {
                            MessageBox.Show("Detected " + Ttracker.Name + " as last stop"); //Alert the user it detected the current stop as the last
                            lblStops.Text += Ttracker.getLastStopDetails();                 //Provide alternate details text for last stop
                        } else { 
                            lblStops.Text += Ttracker.getStopDetails();                     //Else provide regular details text
                        }
                        Ttracker = Ttracker.NextStop;                                       //Incremenet the stop to the next
                    } while (Ttracker != null); //Do while

                    Ttracker = journey.FirstStop;                               //Set the Tracker back to first stop
                    lblOutput.Text = "First Stop: " + journey.FirstStop.Name;   //Change the output text to the first stop
                    do {
                        Ttracker = Ttracker.NextStop;                           //Set the tracker to the next stop
                        res = await train.StartTrain(journey);                  //Start the journey to the next stop and await the response 
                        lblOutput.Text += "\n" + res;                           //Output the update response
                    } while (Ttracker.NextStop != null);                        //While the next stop is not null
                } else {
                    MessageBox.Show("Journey is not Set!");                     //if no journey is found - meaning no stops
                }//if else
            } else {
                MessageBox.Show("Train ID invalid! (Must be integer)");         //If the Train ID is invalid
            }//else
            btnAddStop.Enabled = true;  //Re-enable add stop button
        }//btnGo_Click

        /// <summary>
        ///  This method handles adding a new stop into the journey
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStop_Click(object sender, EventArgs e) {
            Add_Stop newStop = new Add_Stop();                //Create temp new stop
            newStop.ShowDialog();                
            //If the journey is null instantiate it, otherwise add node
            if (journey == null) {
                journey = new Journey(newStop.NewStop, 50);
            } else {
                journey.AddStop(newStop.NewStop);
            }//else

            //Loop through the stops and display them
            Stop tracker = journey.FirstStop;
            lblStops.Text = "Stops:";
            do {
                lblStops.Text += tracker.getStopDetails();
                tracker = tracker.NextStop;
            } while (tracker != null);
        }//btnAddStop_Click

        /// <summary>
        /// Method to test if a string is a valid integer
        /// </summary>
        /// <param name="test"></param>
        /// <returns></returns>
        private bool testString(String test) {
            try {
                Convert.ToInt32(test);
                return true;
            } catch (InvalidCastException) {
                return false;
            } catch (System.FormatException) {
                return false;
            } catch (Exception) {
                return false;
            }

        }
    }
}
