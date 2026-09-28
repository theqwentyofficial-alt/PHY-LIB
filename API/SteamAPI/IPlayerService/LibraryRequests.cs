using System.Text.Json;
namespace PHY_LIB.API.SteamAPI.IPlayerService
{
    public class LibraryRequests
    {
        public static async Task<T> GetOwnedGames<T>(SteamAPI api,string steamid) where T : ProfileLibrary
        {
            Stream stream = await api.client.GetStreamAsync($"http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key={api.APIkey}&steamid={steamid}&format=json");
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
        public static async Task<T> GetRecentlyPlayedGames<T>(SteamAPI api,string steamid) where T : ProfileLibrary
        {
            Stream stream = await api.client.GetStreamAsync($"http://api.steampowered.com/IPlayerService/GetRecentlyPlayedGames/v0001/?key={api.APIkey}&steamid={steamid}&format=json");
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
        public static async Task<T> GetSteamLevel<T>(SteamAPI api,string steamid) where T : ProfileLibrary
        {
            Stream stream = await api.client.GetStreamAsync($"http://api.steampowered.com/IPlayerService/GetSteamLevel/v0001/?key={api.APIkey}&steamid={steamid}&format=json");
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
    }
}
