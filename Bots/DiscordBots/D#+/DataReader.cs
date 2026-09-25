namespace PHY_LIB.Bots.DiscordBots.DSharpPlus
{
    public class DataReader
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
