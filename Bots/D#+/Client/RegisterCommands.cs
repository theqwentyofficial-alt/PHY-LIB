using DSharpPlus.CommandsNext;
using PHY_LIB.Bots.DiscordBots.DPlus.Data;
namespace PHY_LIB.Bots.DiscordBots.DPlus.Client
{
    public partial class Client
    {
        public static void RegisterCommands<CModule, BotData>(BotData botData) where CModule : BaseCommandModule where BotData : IBotData
        {
            List<string> prefixes = botData.Prefix;
            botData.Commands = botData.Client.UseCommandsNext(new CommandsNextConfiguration
            {
                StringPrefixes = prefixes
            });
          
            botData.Commands.RegisterCommands<CModule>();
        }

    }
}
