using System.Text.Json.Serialization;
using System.Text.Json;

namespace PHY_LIB.API.SteamAPI.ISteamUser
{
    public class UserRequests
    {
        public static async Task<T> GetPlayerSummaries<T>(string steamid) where T : SteamUser
        {
            Stream stream = await SteamAPI.client.GetStreamAsync($"http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key={SteamAPI.APIkey}&steamids={steamid}&format=json");
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
        public static async Task<T> GetFriendList<T>(string steamid) where T : SteamUser
        {
            Stream stream = await SteamAPI.client.GetStreamAsync($"http://api.steampowered.com/ISteamUser/GetFriendList/v0001/?key={SteamAPI.APIkey}&steamid={steamid}&format=json");
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
        public static async Task<T> GetPlayerBans<T>(string steamid) where T : SteamUser
        {
            Stream stream = await SteamAPI.client.GetStreamAsync($"http://api.steampowered.com/ISteamUser/GetPlayerBans/v0001/?key={SteamAPI.APIkey}&steamids={steamid}&format=json");
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
        
        public static async Task<T> ResolveVanityURL<T>(string vanityurl) where T : SteamUser
        {
            Stream stream = await SteamAPI.client.GetStreamAsync($"http://api.steampowered.com/ISteamUser/ResolveVanityURL/v0001/?key={SteamAPI.APIkey}&vanityurl={vanityurl}&format=json");
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
    }
}
