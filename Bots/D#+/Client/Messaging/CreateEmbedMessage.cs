using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
namespace PHY_LIB.Bots.DiscordBots.DPlus.Client
{
    public partial class ClientMessaging
    {
        public static DiscordEmbedBuilder CreateEmbedMessage(CommandContext ctx = null, string webSite_Url = null, string image_Url = null, string thumbnail_Url = null, string title = null, string description = null)
        {
            if (ctx == null)
            {
                return new DiscordEmbedBuilder().WithUrl(webSite_Url).WithImageUrl(image_Url).WithThumbnail(thumbnail_Url).WithTitle(title).WithDescription(description);
            }
            return new DiscordEmbedBuilder().WithAuthor(ctx.User.Username).WithUrl(webSite_Url).WithImageUrl(image_Url).WithThumbnail(thumbnail_Url).WithTitle(title).WithDescription(description);
        }
        public static DiscordEmbedBuilder CreateEmbedMessage(DiscordColor color, DateTime date, CommandContext ctx = null, string webSite_Url = null, string image_Url = null, string thumbnail_Url = null, string title = null, string description = null)
        {
            if (ctx == null)
            {
                return new DiscordEmbedBuilder().WithUrl(webSite_Url).WithImageUrl(image_Url).WithThumbnail(thumbnail_Url).WithTitle(title).WithDescription(description).WithColor(color).WithTimestamp(date);
            }
            return new DiscordEmbedBuilder().WithAuthor(ctx.User.Username).WithUrl(webSite_Url).WithImageUrl(image_Url).WithThumbnail(thumbnail_Url).WithTitle(title).WithDescription(description).WithColor(color).WithTimestamp(date);
        }
        public static DiscordEmbedBuilder CreateEmbedMessage(DiscordColor color, CommandContext ctx = null, string webSite_Url = null, string image_Url = null, string thumbnail_Url = null, string title = null, string description = null)
        {
            if (ctx == null)
            {
                return new DiscordEmbedBuilder().WithUrl(webSite_Url).WithImageUrl(image_Url).WithThumbnail(thumbnail_Url).WithTitle(title).WithDescription(description).WithColor(color);
            }
            return new DiscordEmbedBuilder().WithAuthor(ctx.User.Username).WithUrl(webSite_Url).WithImageUrl(image_Url).WithThumbnail(thumbnail_Url).WithTitle(title).WithDescription(description).WithColor(color);
        }
        public static DiscordEmbedBuilder CreateEmbedMessage(DateTime date, CommandContext ctx = null, string webSite_Url = null, string image_Url = null, string thumbnail_Url = null, string title = null, string description = null)
        {
            if (ctx == null)
            {
                return new DiscordEmbedBuilder().WithUrl(webSite_Url).WithImageUrl(image_Url).WithThumbnail(thumbnail_Url).WithTitle(title).WithDescription(description).WithTimestamp(date);
            }
            return new DiscordEmbedBuilder().WithAuthor(ctx.User.Username).WithUrl(webSite_Url).WithImageUrl(image_Url).WithThumbnail(thumbnail_Url).WithTitle(title).WithDescription(description).WithTimestamp(date);
        }
    }
}
