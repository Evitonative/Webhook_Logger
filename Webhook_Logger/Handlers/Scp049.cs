using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webhook_Logger.Handlers
{
    class Scp049
    {
        internal void StartingRecall(StartingRecallEventArgs ev)
        {
            if (Plugin.Instance.Config.StartingRecall == "") return;
            string message = Plugin.Instance.Config.StartingRecall.Replace("%049name%", ev.Scp049.Nickname.ToString());
            message = message.Replace("%049hp%", ev.Scp049.Health.ToString());
            message = message.Replace("%targetname%", ev.Target.Nickname.ToString());
            message = message.Replace("%targetteam%", ev.Target.Team.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.server_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.scp049_url, message, Plugin.Instance.Config.server_name);
        }

        internal void FinishingRecall(FinishingRecallEventArgs ev)
        {
            if (Plugin.Instance.Config.FinishingRecall == "") return;
            string message = Plugin.Instance.Config.FinishingRecall.Replace("%049name%", ev.Scp049.Nickname.ToString());
            message = message.Replace("%049hp%", ev.Scp049.Health.ToString());
            message = message.Replace("%targetname%", ev.Target.Nickname.ToString());
            message = message.Replace("%targetteam%", ev.Target.Team.ToString());

            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.server_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.scp049_url, message, Plugin.Instance.Config.server_name);
        }
    }
}
