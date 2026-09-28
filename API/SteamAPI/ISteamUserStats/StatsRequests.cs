using PHY_LIB.API.SteamAPI.ISteamUser;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace PHY_LIB.API.SteamAPI.ISteamUserStats
{
    public class StatsRequests
    {
        public static async Task<T> GetPlayerAchievements<T>(SteamAPI api,string steamid,string appid) where T : UserStats
        {
            Stream stream = await api.client.GetStreamAsync($"http://api.steampowered.com/ISteamUserStats/GetPlayerAchievements/v0001/?key={SteamAPI.APIkey}&steamid={steamid}&appid={appid}&format=json");
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
        public static async Task<T> GetUserStatsForGame<T>(SteamAPI api,string steamid, string appid) where T : UserStats
        {
            Stream stream = await api.client.GetStreamAsync($"http://api.steampowered.com/ISteamUserStats/GetUserStatsForGame/v0002/?key={SteamAPI.APIkey}&steamid={steamid}&appid={appid}&format=json");
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
  
    }
}
