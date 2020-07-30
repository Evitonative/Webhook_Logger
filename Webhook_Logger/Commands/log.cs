using System;
using CommandSystem;
using Exiled.API.Features;
using RemoteAdmin;

namespace Webhook_Logger.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class log : ICommand
    {
        public string Command { get; } = "log";

        public string[] Aliases { get; } = { "" };

        public string Description { get; } = "It works.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = "It works!";
            return true;
        }
    }
}
