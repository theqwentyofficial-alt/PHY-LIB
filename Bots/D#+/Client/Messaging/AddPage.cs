using DSharpPlus.Entities;
using DSharpPlus.Interactivity;
namespace PHY_LIB.Bots.DiscordBots.DPlus.Client.Messages
{
    public static partial class ClientMessaging
    {
        public static void AddPage(List<Page> pages,DiscordEmbedBuilder embedPage = null, string content = "")
        {
            pages.Add(new Page(content,embedPage));
        }

    }
}
