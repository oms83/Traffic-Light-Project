namespace Traffic_Light_Solution_4
{
    partial class ctrlTrafficLight
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbLight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(192)))), ((int)(((byte)(149)))));
            this.lblTimer.Location = new System.Drawing.Point(108, 394);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(68, 52);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "??";
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbLight
            // 
            this.pbLight.Image = global::Traffic_Light_Solution_4.Properties.Resources.Red;
            this.pbLight.Location = new System.Drawing.Point(56, 18);
            this.pbLight.Name = "pbLight";
            this.pbLight.Size = new System.Drawing.Size(191, 363);
            this.pbLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLight.TabIndex = 0;
            this.pbLight.TabStop = false;
            // 
            // ctrlTrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pbLight);
            this.Name = "ctrlTrafficLight";
            this.Size = new System.Drawing.Size(305, 493);
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLight;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
    }
}
