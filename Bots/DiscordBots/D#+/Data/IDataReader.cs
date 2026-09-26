namespace PHY_LIB.Bots.DiscordBots.DSharpPlus.Data
{
    public interface IDataReader
    {
        Task<string> ReadFile(string path);
    }
}
