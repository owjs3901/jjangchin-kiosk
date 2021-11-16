using Tizen.NUI;
using Tizen.NUI.BaseComponents;

namespace jjangchin_kiosk
{
	public partial class SelectPage : View
    {
        int a=0;
        string Data;
        public SelectPage(string data, int a1)
        {
            InitializeComponent();
            a = a1;
            Data = data;
            this.orderText.Text = $"[{data}]를 주문하시겠습니까?";
        }
        public SelectPage(string data)
        {
            InitializeComponent();
            Data = data;

            this.orderText.Text = $"[{data}]를 주문하시겠습니까?";
        }
        private void No_Button_ClickEvent(object sender, Tizen.NUI.Components.Button e)
        {
            if(a==1)
                Window.Instance.Add(new EasySelectPage());
            else if(a==2)
                Window.Instance.Add(new KioskPage2());
            else
                Window.Instance.Add(new KioskPage1());
        }
        private void Yes_Button_ClickEvent(object sender, Tizen.NUI.Components.Button e)
        {
            Utils.RequestPost($"/order/{Program.nowUserId}/{Data}");

            if (Program.selectedUser != null)
                Program.selectedUser.Resent[0].Name = Data;
            Window.Instance.Add(new CompletePage());
        }
    }
}
