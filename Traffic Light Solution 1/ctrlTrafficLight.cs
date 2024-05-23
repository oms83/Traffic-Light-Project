using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traffic_Lights.Properties;

namespace Traffic_Lights
{
    public partial class ctrlTrafficLight : UserControl
    {
        public class TrafficLightEventArgs:EventArgs
        {
            public enLight CurrenLight { get; }
            public int LightDuration { get; }

            public TrafficLightEventArgs(enLight CurrenLight, int LightDuration)
            {
                this.CurrenLight = CurrenLight;
                this.LightDuration = LightDuration;
            }
        }

        public enum enLight
        {
            green,
            red,
            orange,
        }

        public enLight _CurrentLight = enLight.red;
        public enLight _LightAfterOrangeGreenOrRed;

        private int _RedTime = 10;
        private int _GreenTime = 10;
        private int _OrangeTime = 3;



        public event EventHandler<TrafficLightEventArgs> RedLightOn;
        public void RaiseRedLightOn()
        {
            RaiseRedLightOn(new TrafficLightEventArgs(enLight.red, _RedTime));
        }
        protected virtual void RaiseRedLightOn(TrafficLightEventArgs e)
        {
            RedLightOn?.Invoke(this, e);
        }

        public event EventHandler<TrafficLightEventArgs> RedLightOff;
        public void RaiseRedLightOff()
        {
            RaiseRedLightOff(new TrafficLightEventArgs(enLight.red, _RedTime));
        }
        protected virtual void RaiseRedLightOff(TrafficLightEventArgs e)
        {
            RedLightOn?.Invoke(this, e);
        }



        public event EventHandler<TrafficLightEventArgs> GreenLightOn;
        
        public void RaiseGreenLightOn()
        {
            RaiseGreenLightOn(new TrafficLightEventArgs(enLight.green, _GreenTime));
        }
        protected virtual void RaiseGreenLightOn(TrafficLightEventArgs e)
        {
            GreenLightOn?.Invoke(this, e);
        }

        public event EventHandler<TrafficLightEventArgs> GreenLightOff;

        public void RaiseGreenLightOff()
        {
            RaiseGreenLightOff(new TrafficLightEventArgs(enLight.green, _GreenTime));
        }
        protected virtual void RaiseGreenLightOff(TrafficLightEventArgs e)
        {
            GreenLightOn?.Invoke(this, e);
        }



        public event EventHandler<TrafficLightEventArgs> OrangeLightOn;

        public void RaiseOrangeLightOn()
        {
            RaiseOrangeLightOn(new TrafficLightEventArgs(enLight.orange, _OrangeTime));
        }
        protected virtual void RaiseOrangeLightOn(TrafficLightEventArgs e)
        {
            GreenLightOn?.Invoke(this, e);
        }


        public enLight CurrentLight
        {
            get => _CurrentLight;
            set
            {
                _CurrentLight = value;   
                switch (_CurrentLight)
                {
                    case enLight.green:
                        _CurrentLight = enLight.green;
                        pictureBox1.Image = Resources.traffic_light_green;
                        break;

                    case enLight.orange:
                        _CurrentLight = enLight.orange;
                        pictureBox1.Image = Resources.traffic_light_amber;
                        break;

                    case enLight.red:
                        _CurrentLight = enLight.red;
                        pictureBox1.Image = Resources.traffic_light_red;
                        break;

                }
            }
        }

        public int RedTime
        {
            get => _RedTime;
            set => _RedTime = value;
        }
        public int GreenTime
        {
            get => _GreenTime;
            set => _GreenTime = value;
        }
        public int OrangeTime
        {
            get => _OrangeTime;
            set => _OrangeTime = value;
        }

        private int _CurrentCountDownValue = 0;

        private int _GetCurrentTime()
        {
            switch (_CurrentLight)
            {
                case enLight.red:
                    return _RedTime;
                case enLight.orange:
                    return _OrangeTime;
                case enLight.green:
                    return _GreenTime;
                default:
                    return _RedTime;
            }
        }
        public void StartTimer()
        {
            _CurrentCountDownValue = _GetCurrentTime();

            timer1.Start();
        }
        public void StopTimer()
        {
            _CurrentCountDownValue = 0;
            label1.Text = "??"; 
            timer1.Stop(); 
        }
        public ctrlTrafficLight()
        {
            InitializeComponent();
        }
        private void _ChangeLight()
        {
            switch (CurrentLight)
            {
                case enLight.red:
                    _LightAfterOrangeGreenOrRed = enLight.green;
                    CurrentLight = enLight.orange;
                    _CurrentCountDownValue = OrangeTime;
                    label1.Text = _CurrentCountDownValue.ToString();
                    RaiseOrangeLightOn();
                    break;

                case enLight.orange:
                    if (_LightAfterOrangeGreenOrRed == enLight.green)
                    {
                        CurrentLight = enLight.green;
                        _CurrentCountDownValue = GreenTime;
                        label1.Text = _CurrentCountDownValue.ToString();
                        RaiseGreenLightOn();
                        break;
                    }
                    else
                    {
                        CurrentLight = enLight.red;
                        _CurrentCountDownValue = RedTime;
                        label1.Text = _CurrentCountDownValue.ToString();
                        RaiseRedLightOn();
                        break;
                    }

                case enLight.green:
                    CurrentLight = enLight.orange;
                    _LightAfterOrangeGreenOrRed = enLight.red;
                    _CurrentCountDownValue = OrangeTime;
                    label1.Text = _CurrentCountDownValue.ToString();
                    RaiseOrangeLightOn();
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = _CurrentCountDownValue.ToString();

            if (_CurrentCountDownValue == 0)
            {
                _ChangeLight();
            }
            else
            {
                --_CurrentCountDownValue;   
            }
        }
    }
}
