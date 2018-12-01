using Newtonsoft.Json;
using System.Dynamic;

namespace Cloudrip
{
    public static class Request
    {
        public static dynamic NewRequest(string methodName)
        {
            dynamic req = new ExpandoObject();
            req.method = methodName;
            return req;
        }
        public static dynamic NewRequest(Cloudrip_Client client, string methodName)
        {
            dynamic req = new ExpandoObject();
            req.method = methodName;
            req.token = client.Token;
            return req;
        }
        public static void Send(dynamic obj)
        {
            TcpClient.Send(JsonConvert.SerializeObject(obj));
        }
    }
}
