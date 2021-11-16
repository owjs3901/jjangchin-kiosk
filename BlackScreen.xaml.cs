using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Tizen;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.Peripheral.Gpio;

namespace jjangchin_kiosk
{

    public partial class BlackScreen : View
    {
        private const int SENSOR_MOTION_GPIO_NUMBER = 4;
        // private GpioPin motionGpio;
        public BlackScreen() : base()
        {
            InitializeComponent();
         
            /*
            motionGpio = new GpioPin(SENSOR_MOTION_GPIO_NUMBER, GpioPinDriveMode.Input);
            motionGpio.ValueChanged += MotionChanged;
            Window.Instance.Add(new Scene1Page());
            */

        }



        public void Stop()
        {
            //motionGpio.Dispose();

        }

    }

}