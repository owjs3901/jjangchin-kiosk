using Newtonsoft.Json;
using System.Collections.Generic;
using Tizen;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;

namespace jjangchin_kiosk{
    public partial class MainPage1 : View
{
    public MainPage1()
    {
        InitializeComponent();
    }

        private void Button_ClickEvent1(object sender, Tizen.NUI.Components.Button e)
        {
            Window.Instance.Add(new KioskPage1());
        }
        private void Button_ClickEvent2(object sender, Tizen.NUI.Components.Button e)
        {
            Window.Instance.Add(new EasySelectPage());
        }

        public ImageView Icon { get; }


        private void textField_TextChanged(object sender, TextField.TextChangedEventArgs e)
        {
            Program.nowUserId = e.TextField.Text;

            if (e.TextField.Text.Length == 16)
            {
                Log.Info("owjs3901", "LOGIN");


                var obj = JsonConvert.DeserializeObject<Dictionary<string, object>>(Utils.Request("/user/" + e.TextField.Text));

                if(!obj.ContainsKey("res"))
                {
                    Program.nowUser = obj;
                }
                else
                {
                    Program.nowUser = JsonConvert.DeserializeObject<Dictionary<string, object>>(Utils.RequestPost("/user/" + e.TextField.Text));
                }
                Log.Fatal("owjs3901", "NOW!!");
                Window.Instance.Add(new KioskPage2());
            }


            Tizen.Log.Info("NUI", "Data Changed" + e.TextField.Text + "\n");

        }

    }
}
