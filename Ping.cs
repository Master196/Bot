using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace DiscordBot.Modules
{
    public class Ping : ModuleBase<SocketCommandContext>

    //!Sieg, !lama, !lama1, !lenny, !OjciecLamy
    {
        [Command("help")]
        public async Task Help()
        {
            await ReplyAsync("Dostępne Komendy: !Sieg, !lama, !lama1, !lenny, !OjciecLamy");
        }


        [Command("Sieg")]
        public async Task Sieg()
        {
            await ReplyAsync("Heil!");
        }

        [Command("lama")]
        public async Task Lama()
        {
            await ReplyAsync("Lama chuj wozi gnój");
        }

        [Command("lama1")]
        public async Task Lama1()
        {
            await ReplyAsync("Lama pedał");
        }

        [Command("lenny")]
        public async Task Lenny()
        {
            await ReplyAsync("( ͡° ͜ʖ ͡°)");
        }

        [Command("OjciecLamy")]
        public async Task OjciecLamy()
        {
            await ReplyAsync("Nie mamy tu tego czego szukasz.");
        }

        [Command("command")]
        public async Task Command()
        {
            await ReplyAsync($"{Context.User.Mention} xDD");
        }

    }
}
