using DSharpPlus;
using DSharpPlus.CommandsNext;
namespace PHY_LIB.Bots.DPlus.Data
{
    public interface IBotData
    {
        public string Token { get; set; }
        public string Prefix { get; set; }
        public DiscordClient Client { get; set; }
        public CommandsNextExtension Commands { get; set; }
    }
    public class DiscordBot : IBotData
    {
        public string Token { get; set; }
        public string Prefix { get; set; }
        public DiscordClient Client { get; set; }
        public CommandsNextExtension Commands { get; set; }
    }
}
