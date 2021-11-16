using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Tizen;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;

namespace jjangchin_kiosk
{
	public partial class KioskPage2 : View
{
        string Type,UserName, FirstDrink, SecondDrink, ThirdDrink;


        public KioskPage2()
        {
            InitializeComponent();
            
            Type = "User";
            UserName = Program.nowUser["name"].ToString();
            FirstDrink = "1위 음료";
            SecondDrink = "2위 음료";
            ThirdDrink = "3위 음료";

            string resentMenuData = Program.nowUser["recent_ordered"].ToString();
            string resentMenu = resentMenuData.Length > 0 ? resentMenuData + "입니다." : "없습니다.";

            this.UserText.Text = $"[{UserName}]님이 가장 최근에 주문하신 음료는 {resentMenuData}";

            if (resentMenu != "없습니다.")
            {

                Button btn = new Button();
                btn.Text = resentMenuData;
                btn.FontFamily = "배달의민족주아";
                btn.TextColor = Color.Black;
                btn.BackgroundImage = "*Resource*/images/button_background.png";
                btn.Margin = new Extents(0, 20, 20, 20);
                this.btnList.Add(btn);
                btn.Clicked += (o, i) =>
                {
                    Window.Instance.Add(new SelectPage(resentMenuData, 2));
                };
            }


            string[] mostOrdered = ((JArray)Program.nowUser["most_ordered"]).ToObject<string[]>();
            //this.UserText2.Text = $"1위-[{Program.selectedUser.Recommand[0].Name}]  2위-[{Program.selectedUser.Recommand[1].Name}]  3위-[{Program.selectedUser.Recommand[2].Name}]";
            this.UserText2.Text = mostOrdered.Length == 0 ? "카페 추천 메뉴: 자몽에이드" : string.Join(", ", mostOrdered);


            foreach (string v in mostOrdered)
            {
                Button btn2 = new Button();
                btn2.Text = v;
                btn2.FontFamily = "배달의민족주아";
                btn2.TextColor = Color.Black;
                btn2.BackgroundImage = "*Resource*/images/button_background.png";
                btn2.Margin = new Extents(0, 20, 0, 20);
                btn2.Clicked += (o, i) =>
                {
                    Window.Instance.Add(new SelectPage(v, 2));
                };
                this.btnList2.Add(btn2);
            }
        }

        private void Ade_Button_ClickEvent(object sender, Button e)
        {
            UserText.Text = "";
            UserText2.Text = "";
            new List<View>(btnList.Children).ForEach(btnList.Remove);
            new List<View>(btnList2.Children).ForEach(btnList2.Remove);

            if (Type != "Ade")
            {
                this.adeBtn.BackgroundImage = "*Resource*/images/Selectpage.png";
                this.UserBtn.BackgroundImage = "*Resource*/images/Selectpage2.png";
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
                        Window.Instance.Add(new SelectPage(v,2));
                    };
                    this.btnList.Add(btn);
                }

            }

            Type = "Ade";


        }

        private void Coffee_Button_ClickEvent(object sender, Tizen.NUI.Components.Button e)
        {
            UserText.Text = "";
            UserText2.Text = "";
            new List<View>(btnList.Children).ForEach(btnList.Remove);
            new List<View>(btnList2.Children).ForEach(btnList2.Remove);
            if (Type != "Coffee")
            {
                this.adeBtn.BackgroundImage = "*Resource*/images/Selectpage2.png";
                this.UserBtn.BackgroundImage = "*Resource*/images/Selectpage2.png";
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
                        Window.Instance.Add(new SelectPage(v,2));
                    };
                    this.btnList.Add(btn);


                }
            }

            Type = "Coffee";
        }
            private void User_Button_ClickEvent(object sender, Tizen.NUI.Components.Button e)
            {
                if(Type != "User")
                { 


                        new List<View>(btnList.Children).ForEach(btnList.Remove);
                        this.adeBtn.BackgroundImage = "*Resource*/images/Selectpage2.png";
                        this.coffeeBtn.BackgroundImage = "*Resource*/images/Selectpage2.png";
                        this.UserBtn.BackgroundImage = "*Resource*/images/Selectpage.png";
                        string resentMenuData = Program.nowUser["recent_ordered"].ToString();
                        string resentMenu = resentMenuData.Length > 0 ? resentMenuData + "입니다." : "없습니다.";
                        this.UserText.Text = $"[{UserName}]님이 가장 최근에 주문하신 음료는 {resentMenu}";
                        Button btn = new Button();
                        btn.Text = resentMenuData;
                        btn.FontFamily = "배달의민족주아";
                        btn.TextColor = Color.Black;
                        btn.BackgroundImage = "*Resource*/images/button_background.png";
                        btn.Margin = new Extents(0, 20, 20, 20);
                        this.btnList.Add(btn);
                        btn.Clicked += (o, i) =>
                        {
                            Window.Instance.Add(new SelectPage(resentMenuData, 2));
                        };

                        string[] mostOrdered = ((JArray)Program.nowUser["most_ordered"]).ToObject<string[]>();
                        //this.UserText2.Text = $"1위-[{Program.selectedUser.Recommand[0].Name}]  2위-[{Program.selectedUser.Recommand[1].Name}]  3위-[{Program.selectedUser.Recommand[2].Name}]";
                        this.UserText2.Text = mostOrdered.Length == 0 ? "카페 추천 메뉴: 자몽에이드" : string.Join(", ", mostOrdered);
        //                this.UserText2.Text = $"1위-[{FirstDrink}]  2위-[{SecondDrink}]  3위-[{ThirdDrink}]";
 
                foreach (string v in mostOrdered)
                {
                    Button btn2 = new Button();
                    btn2.Text = v;
                    btn2.FontFamily = "배달의민족주아";
                    btn2.TextColor = Color.Black;
                    btn2.BackgroundImage = "*Resource*/images/button_background.png";
                    btn2.Margin = new Extents(0, 20, 0, 20);
                    btn2.Clicked += (o, i) =>
                    {
                        Window.Instance.Add(new SelectPage(v, 2));
                    };
                    this.btnList2.Add(btn2);
                }
                }

                Type = "User";


        }
    }
}
