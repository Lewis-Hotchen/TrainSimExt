namespace TrainSimExt {
    partial class Add_Stop {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblStopName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblStopName
            // 
            this.lblStopName.AutoSize = true;
            this.lblStopName.Location = new System.Drawing.Point(12, 15);
            this.lblStopName.Name = "lblStopName";
            this.lblStopName.Size = new System.Drawing.Size(60, 13);
            this.lblStopName.TabIndex = 1;
            this.lblStopName.Text = "Stop Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Miles to next stop";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(107, 51);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 92);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(117, 97);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(64, 13);
            this.lblSpeed.TabIndex = 5;
            this.lblSpeed.Text = "Enter speed";
            this.lblSpeed.Visible = false;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(186, 95);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(65, 20);
            this.txtSpeed.TabIndex = 6;
            this.txtSpeed.Visible = false;
            // 
            // Add_Stop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 165);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStopName);
            this.Controls.Add(this.txtName);
            this.Name = "Add_Stop";
            this.Text = "Add a Stop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStopName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TextBox txtSpeed;
    }
}