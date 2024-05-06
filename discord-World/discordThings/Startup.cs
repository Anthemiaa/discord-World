using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using Newtonsoft.Json.Linq;

namespace SelfBot_Framework.Startup
{
    class Startup : IDisposable
    {
        public static DiscordClient _discordClient;
        private CommandsNextModule _commandsNext;
        readonly bool disposed = false;
        public static string token = "";
        public static string username;

        public static void ass()
        {
            if (!File.Exists("token"))
            {
                Console.WriteLine("No token Found, please input token:");
                string token = Console.ReadLine();
                Console.WriteLine($"Saved token");
                Thread.Sleep(1000);
                File.WriteAllText("token", token);
                Console.Clear();
            }

            token = File.ReadAllText("token");
            Console.Title = "Discord Console";
            /* CREATE REFERENCE TO STARTUP */
            Startup startupClass = new Startup();
            /* PASS TO ASYNC CODE */
            startupClass.Run().ConfigureAwait(false).GetAwaiter().GetResult();
        }
        async Task Run()
        {
            try
            {
               
                var clientConfig = new DiscordConfiguration
                {
                    LogLevel = LogLevel.Critical,
                    Token = token,
                    TokenType = TokenType.User,
                    UseInternalLogHandler = true
                };
                var commandConfig = new CommandsNextConfiguration
                {
                    StringPrefix = "!",
                    EnableDefaultHelp = false,
                    SelfBot = true,
                    CaseSensitive = false
                };

                /* INSTANTIATE DISCORDCLIENT */
                _discordClient = new DiscordClient(clientConfig);
                /* TELL IT TO USE COMMANDSNEXT */
                _commandsNext = _discordClient.UseCommandsNext(commandConfig);

                _commandsNext.RegisterCommands<Commands.Commands>();

                /* HOOK EVENTS */
                _discordClient.Heartbeated += Logging.Logging.HeartBeatRecieved;
                _discordClient.MessageCreated += Logging.Logging.MessageRecieved;
                _commandsNext.CommandErrored += Logging.Logging.CommandErrored;
                _commandsNext.CommandExecuted += Logging.Logging.CommandExecuted;
                if (_discordClient != null)
                {
                    var currentUser = _discordClient.CurrentUser;
                    if (currentUser != null)
                    {
                        username = _discordClient.CurrentUser.Username;
                    }
                    else
                    {
                        Console.WriteLine("Current user is null.");
                        // Handle the situation accordingly
                    }
                }
                else
                {
                    Console.WriteLine("Discord client is not initialized.");
                    // Handle the situation accordingly
                }
                await _discordClient.ConnectAsync();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                System.Threading.Thread.Sleep(5000);
                Environment.Exit(0);
            }
            await Task.Delay(-1);
        }


        /* DISPOSE OF MANAGED RESOURCES */
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if (disposing)
            {
                Run().Dispose();
            }

        }
    }
}
