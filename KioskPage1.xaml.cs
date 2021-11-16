using Newtonsoft.Json;
using System.Collections.Generic;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;

namespace jjangchin_kiosk
{
	public partial class KioskPage1 : View
{
        string Type;

        public KioskPage1()
        {
            InitializeComponent();
            Type = "Coffee";

            string data = Utils.Request("/menu/beverage/");

            var li = JsonConvert.DeserializeObject<List<string>>(data);


            foreach (string v in li)
            {
                Button btn = new Button();
                btn.Text = v;
                btn.FontFamily = "배달의민족주아";
                btn.TextColor = Color.Black;
                btn.BackgroundImage = "*Resource*/images/button_background.png";
                btn.Margin = new Extents(0, 20, 0, 20);
                btn.Clicked += (o, i) =>
                {
                    Window.Instance.Add(new SelectPage(v));
                };
                this.btnList.Add(btn);


            }
        }

        private void Ade_Button_ClickEvent(object sender, Button e)
        {
            new List<View>(btnList.Children).ForEach(btnList.Remove);

            if (Type != "Ade")
            {
                this.adeBtn.BackgroundImage = "*Resource*/images/Selectpage.png";
                this.coffeeBtn.BackgroundImage = "*Resource*/images/Selectpage2.png";
                string data = Utils.Request("/menu/food/");

                var li = JsonConvert.DeserializeObject<List<string>>(data);

                foreach (string v in li)
                {
                    Button btn = new Button();
                    btn.Text = v;
                    btn.FontFamily = "배달의민족주아";
                    btn.TextColor = Color.Black;
                    btn.BackgroundImage = "*Resource*/images/button_background.png";
                    btn.Margin = new Extents(0, 20, 0, 20);
                    btn.Clicked += (o, i) =>
                    {
                        Window.Instance.Add(new SelectPage(v));
                    };
                    this.btnList.Add(btn);
                }

            }

            Type = "Ade";


        }

        private void Coffee_Button_ClickEvent(object sender, Tizen.NUI.Components.Button e)
        {
            new List<View>(btnList.Children).ForEach(btnList.Remove);

            if (Type != "Coffee")
            {
                this.adeBtn.BackgroundImage = "*Resource*/images/Selectpage2.png";
                this.coffeeBtn.BackgroundImage = "*Resource*/images/Selectpage.png";

                string data = Utils.Request("/menu/beverage/");

                var li = JsonConvert.DeserializeObject<List<string>>(data);

                foreach (string v in li)
                {
                    Button btn = new Button();
                    btn.Text = v;
                    btn.FontFamily = "배달의민족주아";
                    btn.TextColor = Color.Black;
                    btn.BackgroundImage = "*Resource*/images/button_background.png";
                    btn.Margin = new Extents(0, 20, 0, 20);
                    btn.Clicked += (o, i) =>
                    {
                        Window.Instance.Add(new SelectPage(v));
                    };
                    this.btnList.Add(btn);


                }
            }

            Type = "Coffee";
        }
    }
}
