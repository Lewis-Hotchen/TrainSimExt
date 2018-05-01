namespace TrainSimExt {
    partial class trainSim {
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStop = new System.Windows.Forms.Button();
            this.lblStops = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cmbTrains = new System.Windows.Forms.ComboBox();
            this.btnAddTrain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(9, 217);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(12, 281);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(91, 37);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Start Train";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(9, 9);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(92, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Enter Train details";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(102, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Train ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Journey Details";
            // 
            // btnAddStop
            // 
            this.btnAddStop.Location = new System.Drawing.Point(12, 150);
            this.btnAddStop.Name = "btnAddStop";
            this.btnAddStop.Size = new System.Drawing.Size(75, 23);
            this.btnAddStop.TabIndex = 6;
            this.btnAddStop.Text = "Add Stop";
            this.btnAddStop.UseVisualStyleBackColor = true;
            this.btnAddStop.Click += new System.EventHandler(this.btnAddStop_Click);
            // 
            // lblStops
            // 
            this.lblStops.AutoSize = true;
            this.lblStops.Location = new System.Drawing.Point(155, 122);
            this.lblStops.Name = "lblStops";
            this.lblStops.Size = new System.Drawing.Size(0, 13);
            this.lblStops.TabIndex = 7;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 179);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove Stop";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // cmbTrains
            // 
            this.cmbTrains.FormattingEnabled = true;
            this.cmbTrains.Location = new System.Drawing.Point(158, 52);
            this.cmbTrains.Name = "cmbTrains";
            this.cmbTrains.Size = new System.Drawing.Size(121, 21);
            this.cmbTrains.TabIndex = 9;
            this.cmbTrains.SelectedIndexChanged += new System.EventHandler(this.cmbTrains_SelectedIndexChanged);
            // 
            // btnAddTrain
            // 
            this.btnAddTrain.Location = new System.Drawing.Point(12, 80);
            this.btnAddTrain.Name = "btnAddTrain";
            this.btnAddTrain.Size = new System.Drawing.Size(75, 23);
            this.btnAddTrain.TabIndex = 10;
            this.btnAddTrain.Text = "Add Train";
            this.btnAddTrain.UseVisualStyleBackColor = true;
            this.btnAddTrain.Click += new System.EventHandler(this.btnAddTrain_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Journey Overview";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(253, 122);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(44, 13);
            this.lblSpeed.TabIndex = 12;
            this.lblSpeed.Text = "Speed: ";
            // 
            // trainSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 330);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddTrain);
            this.Controls.Add(this.cmbTrains);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblStops);
            this.Controls.Add(this.btnAddStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblOutput);
            this.Name = "trainSim";
            this.Text = "Let\'s simulate trains";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStop;
        private System.Windows.Forms.Label lblStops;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cmbTrains;
        private System.Windows.Forms.Button btnAddTrain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSpeed;
    }
}

