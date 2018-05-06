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
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(9, 201);
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
            this.lblDesc.Location = new System.Drawing.Point(9, 21);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(92, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Enter Train details";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(102, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Train ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Journey Details";
            // 
            // btnAddStop
            // 
            this.btnAddStop.Location = new System.Drawing.Point(12, 119);
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
            this.lblStops.Location = new System.Drawing.Point(106, 124);
            this.lblStops.Name = "lblStops";
            this.lblStops.Size = new System.Drawing.Size(37, 13);
            this.lblStops.TabIndex = 7;
            this.lblStops.Text = "Stops:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 148);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove Stop";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // trainSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 330);
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
    }
}

