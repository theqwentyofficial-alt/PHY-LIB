using DSharpPlus.Entities;
using DSharpPlus.Interactivity;

namespace PHY_LIB.Bots.DPlus.Client.Messaging
{
    public partial class ClientMessaging
    {
        public static List<Page> CreatePages(int amount, string[] content = null, params DiscordEmbedBuilder[] builders)
        {
            List<Page> pages = new List<Page>(amount);
                for (int i = 0; i < amount; i++)
                {
                    if (content[i] == null)
                    {
                        content[i] = new string("");
                    }
                pages.Add(new Page(content[i], builders[i]));
            }
            return pages;
        }
        public static List<Page> CreatePages(int amount, params DiscordEmbedBuilder[] builders)
        {
            List<Page> pages = new List<Page>(amount);
                string[] temp;
                temp = new string[amount];
                for (int i = 0; i < amount; i++)
                {
                    temp[i] = "";
                }
                for (int i = 0; i < amount; i++)
                {
                pages.Add(new Page(temp[i], builders[i]));
                }
            return pages;
        }
    }
}
