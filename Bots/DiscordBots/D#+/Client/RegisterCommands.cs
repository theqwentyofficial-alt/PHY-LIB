using DSharpPlus.CommandsNext;
using PHY_LIB.Bots.DiscordBots.DSharpPlus.Data;
using System.Runtime.CompilerServices;
namespace PHY_LIB.Bots.DiscordBots.DSharpPlus.Client
{
    public partial class Client
    {
       
        public void RegisterCommands<CModule, BotData>(BotData botData) where CModule : BaseCommandModule where BotData : IBotData
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
