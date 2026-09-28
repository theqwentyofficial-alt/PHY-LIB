using DSharpPlus;
using DSharpPlus.CommandsNext;
namespace PHY_LIB.Bots.DiscordBots.DPlus.Data
{
    public interface IBotData
    {
        public string Token { get; set; }
        public List<string> Prefix { get; set; }
        public DiscordClient Client { get; set; }
        public CommandsNextExtension Commands { get; set; }
    }
    public class BotData : IBotData
    {
        public string Token { get; set; }
        public List<string> Prefix { get; set; }
        public DiscordClient Client { get; set; }
        public CommandsNextExtension Commands { get; set; }
    }
}
