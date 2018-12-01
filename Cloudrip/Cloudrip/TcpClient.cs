using System;
using System.Text;
using System.Threading.Tasks;
using WatsonTcp;
using Cloudrip.Properties;

namespace Cloudrip
{
    class TcpClient
    {
        public static WatsonTcpClient Client { get; private set; } = null;
        public static bool run = false;
        public static Form1 mainGUI { get; private set; }

        public static async Task Start(Form1 form)
        {
            mainGUI = form;
            await Task.Factory.StartNew(() =>
            {
                try
                {
                    run = true;
                    Client = new WatsonTcpClient(Cloudrip.Properties.Resources.ServerIP, int.Parse(Cloudrip.Properties.Resources.ServerPort), ServerConnected, ServerDisconnected, MessageReceived, true);
                }
                catch (Exception) { CustomMessageBox.NewMessageBox(Resources.ConnectionError, ResultSet.OK, "Server error"); }
                System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
                });
        }
        
        public static bool IsRunning()
        {
            return Client != null && Client.IsConnected();
        }
        public static async void Send(string message)
        {
            if (IsRunning())
            {
                
                await Client.SendAsync(Encoding.UTF8.GetBytes(message));
            }
        }

        static bool MessageReceived(byte[] data)
        {
            string msg = Encoding.UTF8.GetString(data);
            dynamic msgJson = Newtonsoft.Json.JsonConvert.DeserializeObject(msg);

                switch (SafeTouch(msgJson.method).ToString())
                {
                    case "login":
                        switch (SafeTouch(msgJson.status).ToString())
                        {
                            case "success":
                                On_Login(true);
                                break;

                            case "failed":
                                On_Login(false);
                                break;
                        }
                        break;
                }
            return true;
        }

        private static dynamic SafeTouch(dynamic val)
        {
            if (val != null)
            {
                return val;
            }
            return "";
        }

        private static void On_Login(bool state)
        {
            if (state)
            {
                Invoker.ChangeImage(mainGUI.sideButton_Login, Cloudrip.Properties.Resources.home);
                Invoker.SetText(mainGUI.sideButton_Login, "Home");
                Invoker.ChangeVisible(mainGUI.sideButton_Search, true);
                Invoker.ChangeVisible(mainGUI.sideButton_Favorites, true);
                mainGUI.Change_MainControl(mainGUI.groupBox_Home);
            }
            else
            {
                Invoker.ChangeImage(mainGUI.sideButton_Login, Cloudrip.Properties.Resources.login);
                Invoker.SetText(mainGUI.sideButton_Login, "Login");
                Invoker.ChangeVisible(mainGUI.sideButton_Search, false);
                Invoker.ChangeVisible(mainGUI.sideButton_Favorites, false);
                mainGUI.Change_MainControl(mainGUI.groupBox_Login);
            }
        }
        static bool ServerConnected()
        {
            return true;
        }

        static bool ServerDisconnected()
        {
            run = false;
            return true;
        }
    }
}
