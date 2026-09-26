using DSharpPlus;
using DSharpPlus.CommandsNext;
using PHY_LIB.Bots.DiscordBots.DSharpPlus.Data;
using System.Text.Json;
namespace PHY_LIB.Bots.DiscordBots.DSharpPlus.Client
{
    public partial class Client
    {
        public static CommandsNextExtension Commands { get; set; }
        public static async Task<IBData> SetUp<IBData, IDReader>(string fullTokenPath, DiscordIntents intents) where IBData : IBotData where IDReader : IDataReader
        {
            IDataReader reader = new DataReader();
            IBData botData = JsonSerializer.Deserialize<IBData>(await reader.ReadFile(fullTokenPath));
            DiscordConfiguration config = new()
            {
                Token = botData.Token,
                TokenType = TokenType.Bot,
                Intents = intents
            };
            botData.Client = new DiscordClient(config);
            return botData;
        }
    }

}

