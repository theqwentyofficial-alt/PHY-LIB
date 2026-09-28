using System.Text.Json.Serialization;
using System.Text.Json;

namespace PHY_LIB.API.SteamAPI.ISteamUser
{
    public class UserRequests
    {
        public static async Task<T> GetPlayerSummaries<T>(SteamAPI api,string steamid) where T : SteamUser
        {
            Stream stream = await api.client.GetStreamAsync($"http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key={api.APIkey}&steamids={steamid}&format=json");
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
        public static async Task<T> GetFriendList<T>(SteamAPI api, string steamid) where T : SteamUser
        {
            Stream stream = await api.client.GetStreamAsync($"http://api.steampowered.com/ISteamUser/GetFriendList/v0001/?key={api.APIkey}&steamid={steamid}&format=json");
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
        public static async Task<T> GetPlayerBans<T>(SteamAPI api, string steamid) where T : SteamUser
        {
            Stream stream = await api.client.GetStreamAsync($"http://api.steampowered.com/ISteamUser/GetPlayerBans/v0001/?key={api.APIkey}&steamids={steamid}&format=json");
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
        
        public static async Task<T> ResolveVanityURL<T>(SteamAPI api, string vanityurl) where T : SteamUser
        {
            Stream stream = await api.client.GetStreamAsync($"http://api.steampowered.com/ISteamUser/ResolveVanityURL/v0001/?key={api.APIkey}&vanityurl={vanityurl}&format=json");
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
    }
}
