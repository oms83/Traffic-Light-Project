using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Light_Solution_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlTrafficLight1_LightGreenOn(object sender, ctrlTrafficLight.TrafficLightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight.ToString());
        }

        private void ctrlTrafficLight1_LightRedOn(object sender, ctrlTrafficLight.TrafficLightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight.ToString());
        }

        private void ctrlTrafficLight1_LightOrangeOn(object sender, ctrlTrafficLight.TrafficLightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlTrafficLight1.StartTimer();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
