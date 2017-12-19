using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;

namespace JigglyBot.Modules
{
    public class commands1 : ModuleBase<SocketCommandContext>
    {
        Info _info = new Info();

        Dictionary<ulong, int> users = new Dictionary<ulong, int>();

        Random rnd = new Random();

        [Command("Roll")]
        public async Task roll(int sides)
        {
            await Context.Channel.SendMessageAsync("Rolling 1-" + sides + ": " + rnd.Next(1, sides));
        }

        [Command("listscores")]
        public async Task listscores()
        {
            String[] scores = _info.getScores();
            StringBuilder _out = new StringBuilder();

            for (int i = 0; i < scores.Length; i++)
            {
                _out.Append(i + 1 + ": " + scores[i] + "\n");
            }

            await Context.Channel.SendMessageAsync(_out.ToString());

        }

        [Command("surfmebutthole")]
        public async Task buttholesurf(int repeat, String _input)
        {
            for(int i = 0; i < repeat; i++)
            {
                await Context.Channel.SendMessageAsync(_input);
            }
        }

        [Command("getuserID")]
        public async Task GetMessageID()
        {
            await Context.Channel.SendMessageAsync(Context.User.Id.ToString());
        }

        [Command("adduser")]
        public async Task adduser(SocketGuildUser user)
        {
            users.Add(user.Id, 0);

            await Context.Channel.SendMessageAsync("Added " + user + "!");
        }

        [Command("bal")]
        public async Task checkbalance()
        {
            await Context.Channel.SendMessageAsync("Your balance is $" + users[Context.User.Id]);
        }


        [Command("Could_I_be_the_one")]
        public async Task Could_I_be_the_one()
        {
<<<<<<< HEAD
            int pick = rnd.Next(0,2);
            if (pick == 1){
              await Context.Channel.SendMessageAsync("You COULD be the one");

            }
            else{
              await Context.Channel.SendMessageAsync("You could not be the one :(");

=======
            int pick = rnd.Next(0,2)
            if ( pick == 1){
              await Context.Channel.SendMessageAsync("You COULD be the one")

            }
            else{
              await Context.Channel.SendMessageAsync("You could not be the one :(")
>>>>>>> 9b8d20597a1469db10abf4b52f66f25530b0bb90
            }
        }
    }
}
