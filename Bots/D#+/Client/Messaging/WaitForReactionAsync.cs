using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity.Extensions;
namespace PHY_LIB.Bots.DPlus.Client.Messaging
{
    public partial class ClientMessaging
    {
        public static async Task WaitForReactionAsync(CommandContext ctx, string emojiName, TimeSpan? waitTime = null)
        {
            DiscordEmoji emoji = DiscordEmoji.FromName(ctx.Client, emojiName);
            DiscordChannel channel = await ctx.Client.GetChannelAsync(ctx.Channel.Id);
            DiscordMessage msg = await channel.GetMessageAsync(ctx.Message.Id);
            await msg.WaitForReactionAsync(ctx.User,emoji, waitTime);
        }
             
    }
}
