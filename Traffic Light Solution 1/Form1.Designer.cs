namespace Traffic_Lights
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlTrafficLight1 = new Traffic_Lights.ctrlTrafficLight();
            this.SuspendLayout();
            // 
            // ctrlTrafficLight1
            // 
            this.ctrlTrafficLight1.CurrentLight = Traffic_Lights.ctrlTrafficLight.enLight.red;
            this.ctrlTrafficLight1.GreenTime = 10;
            this.ctrlTrafficLight1.Location = new System.Drawing.Point(91, 72);
            this.ctrlTrafficLight1.Name = "ctrlTrafficLight1";
            this.ctrlTrafficLight1.OrangeTime = 3;
            this.ctrlTrafficLight1.RedTime = 10;
            this.ctrlTrafficLight1.Size = new System.Drawing.Size(240, 282);
            this.ctrlTrafficLight1.TabIndex = 0;
            this.ctrlTrafficLight1.RedLightOn += new System.EventHandler<Traffic_Lights.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLight1_RedLightOn);
            this.ctrlTrafficLight1.GreenLightOn += new System.EventHandler<Traffic_Lights.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLight1_GreenLightOn);
            this.ctrlTrafficLight1.OrangeLightOn += new System.EventHandler<Traffic_Lights.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLight1_OrangeLightOn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.ctrlTrafficLight1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTrafficLight ctrlTrafficLight1;
    }
}

