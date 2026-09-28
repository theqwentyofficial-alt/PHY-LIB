using DSharpPlus;
using PHY_LIB.Bots.DiscordBots.DPlus.Data;
using PHY_LIB.IO;
using System.Text.Json;
using DSharpPlus.Interactivity;
using DSharpPlus.Interactivity.Extensions;
namespace PHY_LIB.Bots.DiscordBots.DPlus.Client
{
    public partial class Client
    {
        public static async Task<IBData> PrepareClient<IBData>(string fullTokenPath, DiscordIntents intents, bool enableInteractivity = false) where IBData : IBotData 
        {
            DataReader reader = new DataReader();
            IBData botData = JsonSerializer.Deserialize<IBData>(await reader.ReadFileAsync(fullTokenPath));

            DiscordConfiguration config = new()
            {
                Token = botData.Token,
                TokenType = TokenType.Bot,
                Intents = intents,
            };

            if (enableInteractivity)
            botData.Client.UseInteractivity(new InteractivityConfiguration()
            {
                PollBehaviour = DSharpPlus.Interactivity.Enums.PollBehaviour.DeleteEmojis,
                Timeout = TimeSpan.FromMinutes(2),
            });

            botData.Client = new DiscordClient(config);
            return botData;
        }
    }

}

