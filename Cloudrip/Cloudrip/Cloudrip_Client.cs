using Newtonsoft.Json;
using System;
using System.Dynamic;

namespace Cloudrip
{
    public class Cloudrip_Client
    {
        public string Token { get; private set; }

        public Cloudrip_Client(string _token)
        {
            Token = _token;
        }

        internal static void Connect(Form1 form)
        {
            TcpClient.Start(form);
        }

        public static void Login(string username, string password)
        {
            dynamic login = Request.NewRequest("login");
            login.username = username;
            login.password = password.ToMD5(username.ToLower());

            Request.Send(login);
        }

        public static void Register(string username, string password, string password2)
        {
            dynamic register = Request.NewRequest("register");
            register.username = username;
            register.password = password;
            register.password2 = password2;

            Request.Send(register);
        }

        public void LoadFavorites(string term = "")
        {
            dynamic favorites = Request.NewRequest(this, "favorites_list");
            favorites.term = term;

            Request.Send(favorites);
        }
    }
}
