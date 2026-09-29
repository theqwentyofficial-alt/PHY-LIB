using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity.Extensions;

namespace PHY_LIB.Bots.DPlus.Client.Messaging
{
    public partial class ClientMessaging
    {
        public static async Task GetNextMessageAsync(CommandContext ctx, string wantedText, TimeSpan? waitTime = null)
        {
            DiscordChannel channel = await ctx.Client.GetChannelAsync(ctx.Channel.Id);
            DiscordMessage msg = await channel.GetMessageAsync(ctx.Message.Id);
            await msg.GetNextMessageAsync(m => { return m.Content.ToLower() == wantedText; });
        }


    }
}
