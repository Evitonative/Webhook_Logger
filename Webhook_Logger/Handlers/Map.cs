using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webhook_Logger.Handlers
{
    class Map
    {
        //TODO: TEST THIS AND COMPLETE THIS
        internal void AnnouncingDecontamination(AnnouncingDecontaminationEventArgs ev)
        {
            if (Plugin.Instance.Config.AnnouncingDecontamination == "") return;
            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[" + Plugin.Instance.Config.map_name + "] " + Plugin.Instance.Config.AnnouncingDecontamination);
            Plugin.sendWebHook(Plugin.Instance.Config.map_url, Plugin.Instance.Config.AnnouncingDecontamination, Plugin.Instance.Config.map_name);
        }

        internal void AnnouncingNtfEntrance(AnnouncingNtfEntranceEventArgs ev)
        {
            if (Plugin.Instance.Config.AnnouncingNtfEntrance == "") return;
            string message = Plugin.Instance.Config.AnnouncingNtfEntrance.Replace("%scps%", ev.ScpsLeft.ToString());
            message = message.Replace("%name%", ev.UnitName.ToString());
            message = message.Replace("%number%", ev.UnitNumber.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.map_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.map_url, message, Plugin.Instance.Config.map_name);
        }

        internal void AnnouncingScpTermination(AnnouncingScpTerminationEventArgs ev)
        {
            if (Plugin.Instance.Config.AnnouncingScpTermination == "") return;
            string message = Plugin.Instance.Config.AnnouncingScpTermination.Replace("%cause%", ev.TerminationCause.ToString());
            message = message.Replace("%role%", ev.Role.ToString());
            message = message.Replace("%killer%", ev.Killer.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.map_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.map_url, message, Plugin.Instance.Config.map_name);
        }

        internal void Decontaminating(DecontaminatingEventArgs ev)
        {
            if (Plugin.Instance.Config.Decontaminating == "") return;
            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[" + Plugin.Instance.Config.map_name + "] " + Plugin.Instance.Config.Decontaminating);
            Plugin.sendWebHook(Plugin.Instance.Config.map_url, Plugin.Instance.Config.Decontaminating, Plugin.Instance.Config.map_name);
        }

        internal void ExplodingGrenade(ExplodingGrenadeEventArgs ev)
        {
            if (Plugin.Instance.Config.ExplodingGrenade == "") return;
            string message = Plugin.Instance.Config.ExplodingGrenade.Replace("%frag%", ev.IsFrag.ToString());
            string targets = string.Join(", ", ev.Targets);
            message = message.Replace("%targets%", targets);


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.map_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.map_url, message, Plugin.Instance.Config.map_name);
        }

        internal void GeneratorActivated(GeneratorActivatedEventArgs ev)
        {
            if (Plugin.Instance.Config.GeneratorActivated == "") return;
            string message = Plugin.Instance.Config.GeneratorActivated.Replace("%room%", ev.Generator.CurRoom.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.map_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.map_url, message, Plugin.Instance.Config.map_name);
        }
    }
}
