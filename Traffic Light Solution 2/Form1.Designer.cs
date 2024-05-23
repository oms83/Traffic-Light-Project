namespace Traffic_Lights_Project
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
            this.ctrlLight1 = new Traffic_Lights_Project.ctrlLight();
            this.SuspendLayout();
            // 
            // ctrlLight1
            // 
            this.ctrlLight1.CurrentLight = Traffic_Lights_Project.ctrlLight.enLights.eRed;
            this.ctrlLight1.Location = new System.Drawing.Point(291, 32);
            this.ctrlLight1.Name = "ctrlLight1";
            this.ctrlLight1.Size = new System.Drawing.Size(150, 221);
            this.ctrlLight1.TabIndex = 0;
            this.ctrlLight1.OnLightChange += new System.Action<string>(this.ctrlLight1_OnLightChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 404);
            this.Controls.Add(this.ctrlLight1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlLight ctrlLight1;
    }
}

