using DSharpPlus;
namespace PHY_LIB.Bots.DiscordBots.DSharpPlus.Data
{
    public interface IBotData
    {
        string Token { get; set; }
        string Prefix { get; set; }
        DiscordClient Client { get; set; }
    }
    public class BotData : IBotData
    {
        public string Token { get; set; }
        public string Prefix { get; set; }
        public DiscordClient Client { get; set; }
    }
}
