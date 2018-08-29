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
        List<Train> trains = new List<Train>();
        
        public trainSim() {
            InitializeComponent();
        }//constructor

        /// <summary>
        /// This button event is what starts the chain of events for the train
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnGo_Click(object sender, EventArgs e) {
            if (detectCurrTrain() != null) {
                 MessageBox.Show(await Begin(detectCurrTrain()));
            }
            btnAddStop.Enabled = true;  //Re-enable add stop button
        }//btnGo_Click

        /// <summary>
        ///  This method handles adding a new stop into the journey
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStop_Click(object sender, EventArgs e) {
            if (detectCurrTrain() != null) {
                Journey journey = detectCurrTrain().TrainJourney;
                Add_Stop newStop = new Add_Stop(journey);           //Create temp new stop
                newStop.ShowDialog();
                //If the journey is null, instantiate it. Otherwise add node
                if (journey == null) {
                    detectCurrTrain().TrainJourney = new Journey(newStop.NewStop, newStop.Speed);
                    lblSpeed.Text = newStop.Speed.ToString();
                } else {
                    journey.AddStop(newStop.NewStop);
                }//else

                displayJourney();
            }//if
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
            }//catch
        }//testString

        /// <summary>
        /// This method is what does the processing for the journey and displaying the output
        /// </summary>
        /// <param name="train"></param>
        /// <returns></returns>
        private async Task<string> Begin(Train train) {
            Journey journey = train.TrainJourney;
            btnAddStop.Enabled = false;                         //Disable addstop for duration of journey
            Stop Ttracker;                                      //Tracks what stop the train is at
            //Tests if the ID is valid
            String res = "";                                    //String that holds the result of the update

            if (journey != null && journey.FirstStop.NextStop != null) { //Tests if the journey is not null or if the first stop has no other stops
                Ttracker = journey.FirstStop;                            //Set temporary stop to the first stop in the journey
                lblStops.Text = "Stops:";                                //Set the text for the stops overview label
                do {
                    //The next stop is null
                    if (Ttracker.NextStop == null) {
                        lblStops.Text += Ttracker.getLastStopDetails();                 //Provide alternate details text for last stop
                        MessageBox.Show("Detected " + Ttracker.Name + " as last stop"); //Alert the user it detected the current stop as the last
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
                    lblOutput.Text += "\n" + res;                           //Return the result
                } while (Ttracker.NextStop != null);                        //While the next stop is not null
            } else {
                MessageBox.Show("Journey is not Set!");                     //if no journey is found - meaning no stops
                return "";
            }//if else
            return "Journey complete";
        }//begin

        /// <summary>
        /// Add a new train to run
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTrain_Click(object sender, EventArgs e) {
            //flag for testing if a train already exists
            bool flag = false;                
            if (testString(txtName.Text)) {                           //Test if the ID is valid
                trains.Add(new Train(Convert.ToInt32(txtName.Text))); //Add the train into the list of trains
                cmbTrains.Items.Clear();                              //Clear the combobox
                foreach (Train t in trains) {                         //For each train in the list of trains
                    for (int index = 0; index < cmbTrains.Items.Count; index++) {           //For each item in the combo box
                        if (t.ID == Convert.ToInt32(cmbTrains.Items[index].ToString())) {   //Test if the ID of the train is equal to the ID of
                            flag = true;                                                    //If any are equal set flag to true
                            MessageBox.Show("That train already exists!");  
                        }//if
                    }//for
                    if (flag == false) {
                        cmbTrains.Items.Add(t.ID);  //Add the train to the combo box
                    }//if
                }//foreach
            } else {
                MessageBox.Show("ID is invalid!");
            }//else
        }//btnAddTrain

        /// <summary>
        /// Get's the current train selected
        /// </summary>
        /// <returns></returns>
        private Train detectCurrTrain() {
            if (cmbTrains.SelectedItem == null) {       //If there is no item selected
                MessageBox.Show("Choose a train!");
            } else {
                int id = Convert.ToInt32(cmbTrains.SelectedItem.ToString());
                foreach (Train t in trains) {
                    if (t.ID == id) {
                        return t;
                    }//if
                }//foreach
            }//else
            return null;
        }//detectCurrTrain

        /// <summary>
        /// Display all the stops in journey
        /// </summary>
        private void displayJourney() {
            if (detectCurrTrain().TrainJourney != null) {
                lblStops.Text = detectCurrTrain().TrainJourney.ToString();
            }
        }

        /// <summary>
        /// Everytime a different train is selected redisplay the
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTrains_SelectedIndexChanged(object sender, EventArgs e) {
            displayJourney();
        }//cmbTrains_SelectedIndexChanged

        public int returnInt() => 
             5;
    
    }//class



    
           
}//namespace










