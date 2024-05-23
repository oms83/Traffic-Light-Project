using System;
using System.Windows.Forms;
using Traffic_Lights_Project.Properties;

namespace Traffic_Lights_Project
{
    public partial class ctrlLight : UserControl
    {
        public event Action<string> OnLightChange;

        private short _LightTimer = (short)enLights.eRed;
        private short _LightCounter = 0;
        public enum enLights
        {
            eGreen = 15,
            eAmber = 2,
            eRed = 10,
        };

        private enLights _CurrentLight = enLights.eRed;

        public enLights CurrentLight
        {
            get => _CurrentLight;
            set
            {
                _CurrentLight = value;

                switch(_CurrentLight)
                {
                    case enLights.eGreen:
                        pbLight.Image = Resources.traffic_light_green;
                        break;

                    case enLights.eRed:
                        pbLight.Image = Resources.traffic_light_red;
                        break;

                    case enLights.eAmber:
                        pbLight.Image = Resources.traffic_light_amber;
                        break;
                }
            }
        }
        public ctrlLight()
        {
            InitializeComponent();
        }

        private void ctrlLight_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
        }

        private string _GetLightColorName()
        {
            switch (_CurrentLight)
            {
                case enLights.eGreen:
                    return "Green";
                case enLights.eRed:
                    return "Red";
                case enLights.eAmber:
                return "Amber";
            }

            return "";
        }
        private void _SetTrafficLight(short LightCounter)
        {
            switch(LightCounter)
            {
                case 0:
                    _CurrentLight = enLights.eRed;
                    pbLight.Image = Resources.traffic_light_red;
                    break;
                case 1:
                    _CurrentLight = enLights.eAmber;
                    pbLight.Image = Resources.traffic_light_amber;
                    break;
                case 2:
                    _CurrentLight = enLights.eGreen;
                    pbLight.Image = Resources.traffic_light_green;
                    break;
            }

            _LightTimer = (short)_CurrentLight;

            OnLightChange?.Invoke(_GetLightColorName());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = _LightTimer.ToString();
            _LightTimer--;

            if (_LightTimer == 0)
            {

                _LightCounter++;
                
                _SetTrafficLight((short)(_LightCounter % 3));

                if (_LightCounter == 3)
                    _LightCounter = 0;
            }
        }
    }
}

