using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using SelfBot_Framework.Startup;

namespace SelfBot_Framework.Commands
{
    public class Commands
    {

        [Command("PingEveryone"), Description("A simple test command")]
        public async Task PingEveryone(CommandContext ctx, DiscordMember member = null)
        {
            await ctx.Message.DeleteAsync();
            if (member != null)
            {
                await ctx.RespondAsync($"<sound:1>@everyone<sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1><sound:1>{member.Mention}");
            }
        }
    }
}
