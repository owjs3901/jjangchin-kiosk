﻿using System.Collections.Generic;
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

            List<string> li = new List<string>()
                {
                "아메리카노",
                "라떼",
                "바닐라 라떼",
                "카페 모카",
                "아인슈페너",
                "연유 라떼"
                };

            foreach (string v in li)
            {
                Button btn = new Button();
                btn.Text = v;
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
                List<string> li = new List<string>()
                {
                "오렌지 에이드",
                "자몽 에이드",
                "레몬 에이드",
                "망고 에이드",
                "딸기 에이드"
                };

                foreach (string v in li)
                {
                    Button btn = new Button();
                    btn.Text = v;
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
                List<string> li = new List<string>()
                {
                "아메리카노",
                "라떼",
                "바닐라 라떼",
                "카페 모카",
                "아인슈페너",
                "연유 라떼"
                };

                foreach (string v in li)
                {
                    Button btn = new Button();
                    btn.Text = v;
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
