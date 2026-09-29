using DSharpPlus;
using PHY_LIB.Bots.DPlus.Data;
using PHY_LIB.IO;
using System.Text.Json;
using DSharpPlus.Interactivity;
using DSharpPlus.Interactivity.Extensions;
namespace PHY_LIB.Bots.DPlus.Client
{
    public partial class Client
    {
        public static async Task<DBot> PrepareClient<DBot>(string fullTokenPath, DiscordIntents intents, bool enableInteractivity = false) where DBot : DiscordBot 
        {
            DataReader reader = new DataReader();
            DBot bot = JsonSerializer.Deserialize<DBot>(await reader.ReadFileAsync(fullTokenPath));
            
            DiscordConfiguration config = new()
            {
                Token = bot.Token,
                TokenType = TokenType.Bot,
                Intents = intents,
            };
            bot.Client = new DiscordClient(config);
            if (enableInteractivity)
                bot.Client.UseInteractivity(new InteractivityConfiguration()
                {
                    PollBehaviour = DSharpPlus.Interactivity.Enums.PollBehaviour.DeleteEmojis,
                    Timeout = TimeSpan.FromMinutes(2),
                });
            return bot;
        }
    }

}

