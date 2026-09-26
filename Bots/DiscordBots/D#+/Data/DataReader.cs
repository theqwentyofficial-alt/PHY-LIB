using System.Data;

namespace PHY_LIB.Bots.DiscordBots.DSharpPlus.Data
{
    public class DataReader : IDataReader
    {
        public async Task<string> ReadFile(string path)
        {
            using (StreamReader reader = new(path))
            {
                CancellationToken token = new();
                string data = await reader.ReadToEndAsync(token);
                return data;
            }
        }
    }
}
