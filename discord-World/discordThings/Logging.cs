using System;
using System.Threading.Tasks;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using DSharpPlus.CommandsNext;

namespace SelfBot_Framework.Logging
{
    public class Logging
    {
        /* EVENT LOGGING - not made by me */
        public static Task CommandErrored(CommandErrorEventArgs e)
        {
            Error($"{e.Context.User.Username} failed to execute: {e.Command?.QualifiedName ?? "Unknown command"} and recieved error: {e.Exception.Message ?? "No message"}");
            return Task.CompletedTask;
        }
        public static Task CommandExecuted(CommandExecutionEventArgs e)
        {
            Beautify($"{e.Context.User.Username} successfully executed: {e.Command.QualifiedName}");
            return Task.CompletedTask;
        }
        public static Task MessageRecieved(MessageCreateEventArgs e)
        {
            /* AUTHOR CHECK */
            if (!e.Author.IsBot && e.Author != e.Client.CurrentUser)
            {
                /* MESSAGE TYPE CHECK */
                if (e.Message.MessageType == MessageType.Default)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (e.Message.Channel.Guild.Name != null)
                    {
                        Console.Write($"[{DateTime.Now}] ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{e.Message.Channel.Guild.Name} |");
                        Console.Write($"{e.Message.Channel.Name} |");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($" {e.Message.Author.Username} | ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write($"{e.Message.Content} \n");
                        Console.ResetColor();
                    }
                    else if (e.Message.Channel.Name != null)
                    {
                        Console.Write($"[{DateTime.Now}] ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{e.Message.Channel.Guild.Name} |");
                        Console.Write($"{e.Message.Channel.Name} |");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($" {e.Message.Author.Username} | ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write($"{e.Message.Content} \n");
                        Console.ResetColor();
                    }
                }
            }
            return Task.CompletedTask;
        }
        public static Task HeartBeatRecieved(HeartbeatEventArgs e)
        {
            Beautify($"Heartbeat recieved: {e.Ping}ms");
            return Task.CompletedTask;
        }

       
        public static Task Beautify(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"[{DateTime.Now}] ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(message + Environment.NewLine);
            return Task.CompletedTask;
        }
        public static Task Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"[{DateTime.Now}] ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(message + Environment.NewLine);
            return Task.CompletedTask;
        }
    }
}
