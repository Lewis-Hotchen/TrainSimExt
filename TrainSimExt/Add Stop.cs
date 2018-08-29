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
    
    /// <summary>
    /// This form is for adding a stop into the journey
    /// </summary>
    public partial class Add_Stop : Form {
        public Stop NewStop;    //The stop that will be added
        public int Speed;
        public Add_Stop(Journey journey) {
            InitializeComponent();
            NewStop = null;     //Initially set it to null
            if(journey == null) {
                txtSpeed.Visible = true;
                lblSpeed.Visible = true;
            }
        }//constructor

        /// <summary>
        /// When you click the button to add the stop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e) {
            try {
                //Save the information
                NewStop = new Stop(txtName.Text, Convert.ToInt32(txtMiles.Text));   
                if(txtSpeed.Visible == true) {
                    Speed = Convert.ToInt32(txtSpeed.Text);
                }
                //Close the form
                this.Close();   
            } catch (System.FormatException) {  
                MessageBox.Show("Invalid input!");   //If the information is in the incorrect format
            }//try catch
            
            
        }//btnSubmit_click

    }//class
}//namespace
