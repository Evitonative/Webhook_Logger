using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webhook_Logger.Handlers
{
    class Scp079
    {
        internal void GainingExperience(GainingExperienceEventArgs ev)
        {
            if (Plugin.Instance.Config.GainingExperience == "") return;
            string message = Plugin.Instance.Config.GainingExperience.Replace("%player%", ev.Player.ToString());
            message = message.Replace("%level%", ev.Player.Level.ToString());
            message = message.Replace("%experience%", ev.Player.Experience.ToString());
            message = message.Replace("%energy%", ev.Player.Energy.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.scp079_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.scp079_url, message, Plugin.Instance.Config.scp079_name);
        }

        internal void GainingLevel(GainingLevelEventArgs ev)
        {
            if (Plugin.Instance.Config.GainingLevel == "") return;
            string message = Plugin.Instance.Config.GainingLevel.Replace("%player%", ev.Player.ToString());
            message = message.Replace("%level%", ev.NewLevel.ToString());
            message = message.Replace("%experience%", ev.Player.Experience.ToString());
            message = message.Replace("%energy%", ev.Player.Energy.ToString());
            message = message.Replace("%door%", ev.Player.Energy.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.scp079_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.scp079_url, message, Plugin.Instance.Config.scp079_name);
        }

        internal void InteractingDoor(InteractingDoorEventArgs ev)
        {
            if (Plugin.Instance.Config.InteractingDoor079 == "") return;
            string message = Plugin.Instance.Config.InteractingDoor079.Replace("%player%", ev.Player.ToString());
            message = message.Replace("%level%", ev.Player.Level.ToString());
            message = message.Replace("%experience%", ev.Player.Experience.ToString());
            message = message.Replace("%energy%", ev.Player.Energy.ToString());
            message = message.Replace("%door%", ev.Door.name);


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.scp079_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.scp079_url, message, Plugin.Instance.Config.scp079_name);
        }

        internal void InteractingTesla(InteractingTeslaEventArgs ev)
        {
            if (Plugin.Instance.Config.InteractingTesla == "") return;
            string message = Plugin.Instance.Config.InteractingTesla.Replace("%player%", ev.Player.ToString());
            message = message.Replace("%level%", ev.Player.Level.ToString());
            message = message.Replace("%experience%", ev.Player.Experience.ToString());
            message = message.Replace("%energy%", ev.Player.Energy.ToString());
            message = message.Replace("%tesla%", ev.Tesla.name);


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.scp079_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.scp079_url, message, Plugin.Instance.Config.scp079_name);
        }
    }
}
