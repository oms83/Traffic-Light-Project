namespace Traffic_Lights_Project
{
    partial class ctrlLight
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.pbLight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(51, 164);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(39, 30);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "00";
            // 
            // pbLight
            // 
            this.pbLight.Image = global::Traffic_Lights_Project.Properties.Resources.traffic_light_amber;
            this.pbLight.Location = new System.Drawing.Point(9, 33);
            this.pbLight.Name = "pbLight";
            this.pbLight.Size = new System.Drawing.Size(128, 109);
            this.pbLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLight.TabIndex = 2;
            this.pbLight.TabStop = false;
            // 
            // ctrlLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pbLight);
            this.Name = "ctrlLight";
            this.Size = new System.Drawing.Size(150, 221);
            this.Load += new System.EventHandler(this.ctrlLight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox pbLight;
    }
}
