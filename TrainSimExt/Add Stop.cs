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
        public Add_Stop() {
            InitializeComponent();
            NewStop = null;     //Initially set it to null
        }//constructor

        private void btnSubmit_Click(object sender, EventArgs e) {
            try {
                //Save the information
                NewStop = new Stop(txtName.Text, Convert.ToInt32(txtMiles.Text));   
                //Close the form
                this.Close();   
            } catch (System.FormatException) {  
                MessageBox.Show("Invalid input!");   //If the information is in the incorrect format
            }//try catch
            
            
        }//btnSubmit_click

    }//class
}//namespace
