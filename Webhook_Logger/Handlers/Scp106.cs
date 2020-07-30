using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Webhook_Logger.Handlers
{
    class Scp106
    {
        internal void Containing(ContainingEventArgs ev)
        {
            if (Plugin.Instance.Config.Containing == "") return;
            string message = Plugin.Instance.Config.Containing.Replace("%player%", ev.Player.ToString());
            message = message.Replace("%team%", ev.Player.Team.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.server_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.scp106_url, message, Plugin.Instance.Config.server_name);
        }

        internal void CreatingPortal(CreatingPortalEventArgs ev)
        {
            if (Plugin.Instance.Config.CreatingPortal == "") return;
            string message = Plugin.Instance.Config.CreatingPortal.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.server_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.scp106_url, message, Plugin.Instance.Config.server_name);
        }

        internal void Teleporting(TeleportingEventArgs ev)
        {
            if (Plugin.Instance.Config.Teleporting == "") return;
            string message = Plugin.Instance.Config.Teleporting.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.server_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.scp106_url, message, Plugin.Instance.Config.server_name);
        }
    }
}
