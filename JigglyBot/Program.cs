using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace JigglyBot
{
    class Program
    {
        static void Main(string[] args)
        => new Program().StartAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;
        private CommandHandler _handler;

        public async Task StartAsync()
        {
            _client = new DiscordSocketClient();
            _handler = new CommandHandler(_client);
            await _client.LoginAsync(TokenType.Bot, "MzkyNDIxMTk2NjA5NjE3OTM4.DRnI-A.CMJsVsFwBIZrAd5At7Z-mqqBd2U");
            await _client.StartAsync();
            await Task.Delay(-1);
        }
    }
}
