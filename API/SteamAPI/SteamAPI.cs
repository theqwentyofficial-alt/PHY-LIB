namespace PHY_LIB.API.SteamAPI
{
    public class SteamAPI
    {
        public SteamAPI(string API_Key, string? input)
        {
            client.DefaultRequestHeaders.UserAgent.ParseAdd(input);
            APIkey = API_Key;
        }
        public HttpClient client = new HttpClient();
        public string APIkey { get; set; }
    }
}
