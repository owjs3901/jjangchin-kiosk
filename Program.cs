using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Tizen.NUI;

namespace jjangchin_kiosk
{
    static class Program
    {

        public static Dictionary<string, User> globalData = new Dictionary<string, User>();
        public static User selectedUser;
        public static string nowUserId = "";

        public static Dictionary<string, object> nowUser;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            globalData.Add("2833670479702025", new User("오정민",
                new List<Item>(){ new Item("아인슈페너","~.png"),
                new Item("apple","apple.png")},
                new List<Item>()
                {
                    new Item("바닐라 라떼",""),
                    new Item("아인슈페너",""),
                    new Item("레몬 에이드",""),
                }));

            globalData.Add("2861183814422024", new User("임동연",
                new List<Item>(){ new Item("자몽 에이드","~.png"),
                new Item("apple","apple.png")},
                new List<Item>(){
                    new Item("아메리카노",""),
                    new Item("카페 모카",""),
                    new Item("연유 라떼",""),
                }));
            Scene1 Instance = new Scene1();
            Instance.Run(args);
        }
    }
}
