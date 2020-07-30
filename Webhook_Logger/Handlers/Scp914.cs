using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webhook_Logger.Handlers
{
    class Scp914
    {
        internal void UpgradingItems(UpgradingItemsEventArgs ev)
        {
            if (Plugin.Instance.Config.UpgradingItems == "") return;
            string message = Plugin.Instance.Config.UpgradingItems.Replace("%setting%", ev.KnobSetting.ToString());
            string players = string.Join(", ", ev.Players);
            message = message.Replace("%players%", players);
            message = message.Replace("%items%", ev.Items.Count.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.scp914_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.scp914_url, message, Plugin.Instance.Config.scp914_name);
        }

        internal void Activating(ActivatingEventArgs ev)
        {
            if (Plugin.Instance.Config.Activating == "") return;
            string message = Plugin.Instance.Config.Activating.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.scp914_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.scp914_url, message, Plugin.Instance.Config.scp914_name);
        }

        internal void ChangingKnobSetting(ChangingKnobSettingEventArgs ev)
        {
            if (Plugin.Instance.Config.ChangingKnobSetting == "") return;
            string message = Plugin.Instance.Config.ChangingKnobSetting.Replace("%player%", ev.Player.ToString());
            message = message.Replace("%setting%", ev.KnobSetting.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.scp914_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.scp914_url, message, Plugin.Instance.Config.scp914_name);
        }
    }
}
