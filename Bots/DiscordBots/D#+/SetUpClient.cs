using System.Text.Json;
using DSharpPlus;

namespace PHY_LIB.Bots.DiscordBots.DSharpPlus
{
    public class Client
    {
        public static async Task<BotData> SetUp(string fullTokenPath, DiscordIntents intents)
        {
            DataReader reader = new();
            BotData botData = JsonSerializer.Deserialize<BotData>(await reader.ReadFile(fullTokenPath));
            DiscordConfiguration config = new()
            {
                Token = botData.Token,
                TokenType = TokenType.Bot,
                Intents = intents
            };
            botData.client = new DiscordClient(config);
            return botData;
        }
    }

}

