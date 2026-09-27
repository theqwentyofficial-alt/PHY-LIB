using System.Runtime.CompilerServices;

namespace PHY_LIB.API.SteamAPI
{
    public class SteamAPI
    {
        public static HttpClient client = new HttpClient();
        public static string APIkey { get; set; }
        public static void SetUp(string API_Key,string? input = "Mozilla/5.0 (Windows NT 10.0)") 
        {
            client.DefaultRequestHeaders.UserAgent.ParseAdd(input);
            APIkey = API_Key;
        }
    }
}
