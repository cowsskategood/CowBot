using System;
using System.Threading.Tasks;
using Discord.Commands;



namespace CowBot.Module
{









    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("moo")]
        public async Task Moo()
        {
            await ReplyAsync("Moo");
        }

        [Command("time")]
        public async Task time()
        {
            DateTime date1 = DateTime.Now;

            DateTime date2 = DateTime.UtcNow;

            await ReplyAsync($"Your time: {date1:HH:mm:ss} and {date2:HH:mm:ss} in torn");

        }


       

    }
}
