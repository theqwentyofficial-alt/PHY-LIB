using DSharpPlus.CommandsNext;
using DSharpPlus.Interactivity;
using DSharpPlus.Interactivity.Enums;
using DSharpPlus.Interactivity.Extensions;

namespace PHY_LIB.Bots.DPlus.Client.Messaging
{
    public partial class ClientMessaging
    {
        public static async Task SendPaginatedMessageAsync(CommandContext ctx, List<Page> pages,PaginationBehaviour? pBehaviour = null, ButtonPaginationBehavior? bBehavior = null)
        {
            await ctx.Channel.SendPaginatedMessageAsync(ctx.User, pages, pBehaviour, bBehavior);
        }
    }
}
