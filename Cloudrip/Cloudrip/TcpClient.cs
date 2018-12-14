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

            switch (SafeTouch<string>(msgJson.method))
            {
                case "login":
                    bool success = SafeTouch<bool>(msgJson.success);
                    Login_Callback(success, SafeTouch<string>(msgJson.token));
                    break;
                case "register":
                    Register_Callback(SafeTouch<bool>(msgJson.success), SafeTouch<string>(msgJson.statusLabel));
                    break;
                case "session_start":
                    Start_User_GUI(msg);
                    break;
            }
            return true;
        }

        private static T SafeTouch<T>(dynamic val)
        {
            if (val != null)
            {
                return (T)val;
            }
            return default(T);
        }
        private static void Register_Callback(bool state, string msg)
        {
            CustomMessageBox.NewMessageBox(msg, ResultSet.OK, "Register");

            if (state)
            {
                Invoker.ChangeImage(mainGUI.sideButton_Login, Cloudrip.Properties.Resources.login);
                Invoker.SetText(mainGUI.sideButton_Login, "Login");
                Invoker.ChangeVisible(mainGUI.sideButton_Search, false);
                Invoker.ChangeVisible(mainGUI.sideButton_Favorites, false);
                mainGUI.Change_MainControl(mainGUI.groupBox_Login);
                mainGUI.login_textBox_Username.Clear();
                mainGUI.login_textBox_Password.Clear();
            }
            else
            {
                mainGUI.Change_MainControl(mainGUI.groupBox_Register);
            }
        }
        private static void Login_Callback(bool state, string token)
        {
            if (state)
            {
                Prepare_User_GUI(token);
                Invoker.ChangeImage(mainGUI.sideButton_Login, Cloudrip.Properties.Resources.home);
                Invoker.SetText(mainGUI.sideButton_Login, "Home");
                Invoker.ChangeVisible(mainGUI.sideButton_Search, true);
                Invoker.ChangeVisible(mainGUI.sideButton_Favorites, true);
                mainGUI.Change_MainControl(mainGUI.groupBox_Home);
                mainGUI.RefreshSeriesList();
                mainGUI.UpdateSeriesList();
            }
            else
            {
                Invoker.ChangeImage(mainGUI.sideButton_Login, Cloudrip.Properties.Resources.login);
                Invoker.SetText(mainGUI.sideButton_Login, "Login");
                Invoker.ChangeVisible(mainGUI.sideButton_Search, false);
                Invoker.ChangeVisible(mainGUI.sideButton_Favorites, false);
                mainGUI.Change_MainControl(mainGUI.groupBox_Login);
                Invoker.SetText(mainGUI.login_textBox_Username, "");
                Invoker.SetText(mainGUI.login_textBox_Password, "");
            }
        }

        private static void Prepare_User_GUI(string token)
        {
            dynamic request = Request.NewRequest("session_start");
            request.token = token;

            Request.Send(request);
        }
        private static void Start_User_GUI(string userDump)
        {
            mainGUI.user = Newtonsoft.Json.JsonConvert.DeserializeObject<CloudripUser>(userDump);
            CloudripUser user = mainGUI.user;
            Invoker.SetText(mainGUI.Home_Label_Welcome, 
                "Nickname: " + user.username + Environment.NewLine + 
                "Favorites: " + user.favorites.Count.ToString());

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
