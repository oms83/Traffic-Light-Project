using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traffic_Light_Solution_4.Properties;

namespace Traffic_Light_Solution_4
{
    public partial class ctrlTrafficLight : UserControl
    {
        public ctrlTrafficLight()
        {
            InitializeComponent();
        }

        public enum enLight
        {
            Green, 
            Orange,
            Red,
        }
        public class TrafficLightEventArgs:EventArgs
        {
            public enLight CurrentLight { get; }
            public short LightDuration { get; }

            public TrafficLightEventArgs(enLight currentLight, short lightDuration)
            {
                CurrentLight = currentLight;
                LightDuration = lightDuration;
            }
        }

        private short _RedTime = 10;
        private short _GreenTime = 10;
        private short _OrangeTime = 3;
        
        public short RedTime
        {
            get => _RedTime;
            set => _RedTime = value;
        }
        public short OrangeTime
        {
            get => _OrangeTime;
            set => _OrangeTime = value;
        }
        public short GreenTime
        {
            get => _GreenTime;
            set => _GreenTime = value;
        }


        public event EventHandler<TrafficLightEventArgs> LightRedOn;
        protected virtual void RaiseLightRedOn(TrafficLightEventArgs e)
        {
            if (LightRedOn != null)
            {
                LightRedOn(this, e);
            }
        }
        public void RaiseLightRedOn()
        {
            RaiseLightRedOn(new TrafficLightEventArgs(enLight.Red, _RedTime));
        }



        public event EventHandler<TrafficLightEventArgs> LightRedOff;
        protected virtual void RaiseLightRedOff(TrafficLightEventArgs e)
        {
            if (LightRedOff != null)
            {
                LightRedOff(this, e);
            }
        }
        public void RaiseLightRedOff()
        {
            RaiseLightRedOn(new TrafficLightEventArgs(enLight.Red, _RedTime));
        }



        public event EventHandler<TrafficLightEventArgs> LightGreenOn;
        protected virtual void RaiseLightGreenOn(TrafficLightEventArgs e)
        {
            if (LightRedOn != null)
            {
                LightRedOn(this, e);
            }
        }
        public void RaiseLightGreenOn()
        {
            RaiseLightRedOn(new TrafficLightEventArgs(enLight.Green, _GreenTime));
        }



        public event EventHandler<TrafficLightEventArgs> LightGreenOff;
        protected virtual void RaiseLightGreenOff(TrafficLightEventArgs e)
        {
            if (LightRedOff != null)
            {
                LightRedOff(this, e);
            }
        }
        public void RaiseLightGreenOff()
        {
            RaiseLightRedOn(new TrafficLightEventArgs(enLight.Green, _GreenTime));
        }


        public event EventHandler<TrafficLightEventArgs> LightOrangeOn;
        protected virtual void RaiseLightOrangeOn(TrafficLightEventArgs e)
        {
            LightOrangeOn?.Invoke(this, e);
        }
        public void RaiseLightOrange()
        {
            RaiseLightOrangeOn(new TrafficLightEventArgs(enLight.Orange, _OrangeTime));
        }

        private short _CurrentCountDownValue = 0; 

        private enLight _CurrentLight = enLight.Red;
        private enLight _LightAfterOrangeRedOrGreen;

        public enLight CurrentLight
        {
            get => _CurrentLight;
            set
            {
                _CurrentLight = value;
                switch (_CurrentLight)
                {
                    case enLight.Red:
                        pbLight.Image = Resources.Red;
                        _CurrentLight = enLight.Red; 
                        break;

                    case enLight.Green:
                        pbLight.Image = Resources.Green;
                        _CurrentLight = enLight.Green;
                        break;

                    case enLight.Orange:
                        pbLight.Image = Resources.Orange;
                        _CurrentLight = enLight.Orange;
                        break;
                }
            }
        }
        private short _GetLightTime()
        {
            switch (_CurrentLight)
            {
                case enLight.Red:
                    return _RedTime;
                case enLight.Green:
                    return _GreenTime;
                case enLight.Orange:
                    return _OrangeTime;
                default:
                    return _RedTime;
            }
        }
        public void StartTimer()
        {
            _CurrentCountDownValue = _GetLightTime();
            timer1.Start();
        }
        public void StopTimer()
        {
            lblTimer.Text = "??";
            _CurrentCountDownValue = 0;
            timer1.Stop();
        }
        private void _ChangeLight()
        {
            switch ( _CurrentLight )
            {
                case enLight.Red:
                    lblTimer.Text = _OrangeTime.ToString();
                    CurrentLight = enLight.Orange;
                    _CurrentCountDownValue = _OrangeTime;
                    _LightAfterOrangeRedOrGreen = enLight.Green;

                    RaiseLightOrange();
                    break;

                case enLight.Orange:
                    if (_LightAfterOrangeRedOrGreen == enLight.Green)
                    {
                        lblTimer.Text = _GreenTime.ToString();
                        CurrentLight = enLight.Green;
                        _CurrentCountDownValue = GreenTime;

                        RaiseLightGreenOn();
                    }
                    else
                    {
                        lblTimer.Text = _RedTime.ToString();
                        CurrentLight = enLight.Red;
                        _CurrentCountDownValue = RedTime;

                        RaiseLightRedOn();
                    }
                    break;

                case enLight.Green:
                    lblTimer.Text = OrangeTime.ToString();
                    CurrentLight = enLight.Orange;
                    _CurrentCountDownValue = _OrangeTime;
                    _LightAfterOrangeRedOrGreen = enLight.Red;

                    RaiseLightOrange();
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = _CurrentCountDownValue.ToString();
            if ( _CurrentCountDownValue == 0 )
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
