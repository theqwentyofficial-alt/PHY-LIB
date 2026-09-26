using DSharpPlus.CommandsNext;
using PHY_LIB.Bots.DiscordBots.DSharpPlus.Data;
namespace PHY_LIB.Bots.DiscordBots.DSharpPlus.Client
{
    public partial class Client
    {
        public static void UseCommands<CModule, BotData>(BotData botData) where CModule : BaseCommandModule where BotData : IBotData
        {
            string[] prefixes = { botData.Prefix };
            Commands = botData.Client.UseCommandsNext(new CommandsNextConfiguration
            {
                StringPrefixes = prefixes
            });
            Commands.RegisterCommands<CModule>();
        }

    }
}
