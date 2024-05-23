namespace Traffic_Light_Solution_4
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
            this.ctrlTrafficLight1 = new Traffic_Light_Solution_4.ctrlTrafficLight();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlTrafficLight1
            // 
            this.ctrlTrafficLight1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.ctrlTrafficLight1.CurrentLight = Traffic_Light_Solution_4.ctrlTrafficLight.enLight.Red;
            this.ctrlTrafficLight1.GreenTime = ((short)(10));
            this.ctrlTrafficLight1.Location = new System.Drawing.Point(53, 12);
            this.ctrlTrafficLight1.Name = "ctrlTrafficLight1";
            this.ctrlTrafficLight1.OrangeTime = ((short)(3));
            this.ctrlTrafficLight1.RedTime = ((short)(10));
            this.ctrlTrafficLight1.Size = new System.Drawing.Size(287, 478);
            this.ctrlTrafficLight1.TabIndex = 0;
            this.ctrlTrafficLight1.LightRedOn += new System.EventHandler<Traffic_Light_Solution_4.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLight1_LightRedOn);
            this.ctrlTrafficLight1.LightGreenOn += new System.EventHandler<Traffic_Light_Solution_4.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLight1_LightGreenOn);
            this.ctrlTrafficLight1.LightOrangeOn += new System.EventHandler<Traffic_Light_Solution_4.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLight1_LightOrangeOn);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Traffic_Light_Solution_4.Properties.Resources.eradicate;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(346, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 43);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(402, 508);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlTrafficLight1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTrafficLight ctrlTrafficLight1;
        private System.Windows.Forms.Button btnClose;
    }
}

