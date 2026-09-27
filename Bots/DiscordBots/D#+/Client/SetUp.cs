using DSharpPlus;
using DSharpPlus.CommandsNext;
using PHY_LIB.Bots.DiscordBots.DSharpPlus.Data;
using PHY_LIB.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
namespace PHY_LIB.Bots.DiscordBots.DSharpPlus.Client
{
    public partial class Client
    {
        public CommandsNextExtension Commands { get; set; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async Task<IBData> SetUp<IBData>(string fullTokenPath, DiscordIntents intents) where IBData : IBotData 
        {
            DataReader reader = new DataReader();
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

