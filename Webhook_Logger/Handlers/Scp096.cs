using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webhook_Logger.Handlers
{
    class Scp096
    {
        internal void Enraging(EnragingEventArgs ev)
        {
            if (Plugin.Instance.Config.Enraging == "") return;
            string message = Plugin.Instance.Config.Enraging.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.scp096_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.scp096_url, message, Plugin.Instance.Config.scp096_name);
        }

        internal void CalmingDown(CalmingDownEventArgs ev)
        {
            if (Plugin.Instance.Config.CalmingDown == "") return;
            string message = Plugin.Instance.Config.CalmingDown.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.scp096_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.scp096_url, message, Plugin.Instance.Config.scp096_name);
        }
    }
}