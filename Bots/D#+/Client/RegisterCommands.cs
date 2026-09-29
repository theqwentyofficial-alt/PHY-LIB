using DSharpPlus.CommandsNext;
using PHY_LIB.Bots.DPlus.Data;
namespace PHY_LIB.Bots.DPlus.Client
{
    public partial class Client
    {
        public static void RegisterCommands<CModule, DBot>(DBot bot) where CModule : BaseCommandModule where DBot : DiscordBot
        {
            List<string> prefixes = new List<string>();
            prefixes.Add(bot.Prefix);
            bot.Commands = bot.Client.UseCommandsNext(new CommandsNextConfiguration
            {
                StringPrefixes = prefixes
            });
          
            bot.Commands.RegisterCommands<CModule>();
        }

    }
}
