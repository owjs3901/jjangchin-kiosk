using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tizen.Applications;
using Tizen.NUI;
using Tizen.Peripheral.Gpio;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Xaml;

namespace jjangchin_kiosk
{
    public class Scene1 : NUIApplication
    {
        private BlackScreen mainPage;
        override protected void OnCreate()
        {
            base.OnCreate();
            // Program.globalData["hhh"];
            // NOTE To use theme.xaml, uncomment below line.
            // ThemeManager.ApplyTheme(new Theme(Tizen.Applications.Application.Current.DirectoryInfo.Resource + "theme/theme.xaml"));

            mainPage = new BlackScreen();
            
            Window.Instance.Add(mainPage);
            Window.Instance.Add(new Scene1Page());
            // GetDefaultWindow().KeyEvent += OnScene1KeyEvent;
        }

        private void OnScene1KeyEvent(object sender, Window.KeyEventArgs e)
        {
            if (e.Key.State == Key.StateType.Down && (e.Key.KeyPressedName == "XF86Back" || e.Key.KeyPressedName == "Escape"))
            {
                Exit();
            }
        }

        override protected void OnPause()
        {
            base.OnPause();
        }

        override protected void OnResume()
        {
            base.OnResume();
        }

        override protected void OnTerminate()
        {
            mainPage.Stop();
            base.OnTerminate();
        }

        override protected void OnAppControlReceived(AppControlReceivedEventArgs e)
        {
            base.OnAppControlReceived(e);
        }
    }
}
