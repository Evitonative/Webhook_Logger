using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webhook_Logger.Handlers
{
    class Warhead
    {
        internal void Stopping(StoppingEventArgs ev)
        {
            if (Plugin.Instance.Config.Stopping == "") return;
            string message = Plugin.Instance.Config.Stopping.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.server_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.warhead_url, message, Plugin.Instance.Config.server_name);
        }

        internal void Detonated()
        {
            if (Plugin.Instance.Config.Detonated == "") return;

            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[" + Plugin.Instance.Config.server_name + "] " + Plugin.Instance.Config.Detonated);
            Plugin.sendWebHook(Plugin.Instance.Config.warhead_url, Plugin.Instance.Config.Detonated, Plugin.Instance.Config.server_name);
        }

        internal void Starting(StartingEventArgs ev)
        {
            if (Plugin.Instance.Config.Starting == "") return;
            string message = Plugin.Instance.Config.Starting.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.server_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.warhead_url, message, Plugin.Instance.Config.server_name);
        }
    }
}
