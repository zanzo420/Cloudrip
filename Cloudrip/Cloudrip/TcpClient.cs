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
        public static async Task Start()
        {
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
            CustomMessageBox.NewMessageBox("Message from server: " + msg);
            return true;
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
