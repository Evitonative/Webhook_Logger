using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webhook_Logger.Handlers
{
    class Server
    {
        public void WaitingForPlayers()
        {
            if (Plugin.Instance.Config.WaitingForPlayers == "") return;

            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[" + Plugin.Instance.Config.server_name + "] " + Plugin.Instance.Config.WaitingForPlayers);
            Plugin.sendWebHook(Plugin.Instance.Config.server_url, "``` ```", Plugin.Instance.Config.server_name);
            Plugin.sendWebHook(Plugin.Instance.Config.server_url, Plugin.Instance.Config.WaitingForPlayers, Plugin.Instance.Config.server_name);
        }

        internal void RoundStarted()
        {
            if (Plugin.Instance.Config.RoundStarted == "") return;
            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[" + Plugin.Instance.Config.server_name + "] " + Plugin.Instance.Config.RoundStarted);
            Plugin.sendWebHook(Plugin.Instance.Config.server_url, Plugin.Instance.Config.RoundStarted, Plugin.Instance.Config.server_name);
        }

        internal void RoundEnded(RoundEndedEventArgs ev)
        {
            if (Plugin.Instance.Config.RoundEnded == "") return;
            string message = Plugin.Instance.Config.RoundEnded.Replace("%team%", ev.LeadingTeam.ToString());
            message = message.Replace("%time%", ev.TimeToRestart.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.server_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.server_url, message, Plugin.Instance.Config.server_name);
        }

        internal void RestartingRound()
        {
            if (Plugin.Instance.Config.RestartingRound == "") return;
            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[" + Plugin.Instance.Config.server_name + "] " + Plugin.Instance.Config.RestartingRound);
            Plugin.sendWebHook(Plugin.Instance.Config.server_url, Plugin.Instance.Config.RestartingRound, Plugin.Instance.Config.server_name);
        }

        internal void ReportingCheater(ReportingCheaterEventArgs ev)
        {
            if (Plugin.Instance.Config.ReportingCheater == "") return;
            string message = Plugin.Instance.Config.ReportingCheater.Replace("%reason%", ev.Reason.ToString());
            message = message.Replace("%reported%", ev.Reported.ToString());
            message = message.Replace("%reporter%", ev.Reporter.ToString());
            

            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.server_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.server_url, message, Plugin.Instance.Config.server_name);
        }

        internal void RespawningTeam(RespawningTeamEventArgs ev)
        {
            if (Plugin.Instance.Config.RespawningTeam == "") return;
            string message = Plugin.Instance.Config.RespawningTeam.Replace("%maxRespawn%", ev.MaximumRespawnAmount.ToString());
            message = message.Replace("%team%", ev.NextKnownTeam.ToString());
            string players = string.Join(", ", ev.Players);
            message = message.Replace("%players%", players);


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.server_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.server_url, message, Plugin.Instance.Config.server_name);
        }

        internal void SendingConsoleCommand(SendingConsoleCommandEventArgs ev)
        {
            if (Plugin.Instance.Config.SendingConsoleCommand == "") return;
            string message = Plugin.Instance.Config.SendingConsoleCommand.Replace("%name%", ev.Player.Nickname.ToString());
            message = message.Replace("%encrypted%", ev.IsEncrypted.ToString());
            message = message.Replace("%command%", ev.Name.ToString());
            string args = string.Join(", ", ev.Arguments);
            message = message.Replace("%args%", args);


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.server_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.server_url, message, Plugin.Instance.Config.server_name);
        }

        internal void SendingRemoteAdminCommand(SendingRemoteAdminCommandEventArgs ev)
        {
            if (Plugin.Instance.Config.SendingRemoteAdminCommand == "") return;
            string message = Plugin.Instance.Config.SendingRemoteAdminCommand.Replace("%name%", ev.Sender.Nickname.ToString());
            message = message.Replace("%command%", ev.Name.ToString());
            string args = string.Join(", ", ev.Arguments);
            message = message.Replace("%args%", args);


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.server_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.server_url, message, Plugin.Instance.Config.server_name);
        }

        internal void ReloadedConfigs()
        {
            if (Plugin.Instance.Config.ReloadedConfigs == "") return;
            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[" + Plugin.Instance.Config.server_name + "] " + Plugin.Instance.Config.ReloadedConfigs);
            Plugin.sendWebHook(Plugin.Instance.Config.server_url, Plugin.Instance.Config.ReloadedConfigs, Plugin.Instance.Config.server_name);
        }

        internal void ReloadedRA()
        {
            if (Plugin.Instance.Config.ReloadedRA == "") return;
            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[" + Plugin.Instance.Config.server_name + "] " + Plugin.Instance.Config.ReloadedRA);
            Plugin.sendWebHook(Plugin.Instance.Config.server_url, Plugin.Instance.Config.ReloadedRA, Plugin.Instance.Config.server_name);
        }

        internal void ReloadedGameplay()
        {
            if (Plugin.Instance.Config.ReloadedGameplay == "") return;
            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[" + Plugin.Instance.Config.server_name + "] " + Plugin.Instance.Config.ReloadedGameplay);
            Plugin.sendWebHook(Plugin.Instance.Config.server_url, Plugin.Instance.Config.ReloadedGameplay, Plugin.Instance.Config.server_name);
        }

        internal void LocalReporting(LocalReportingEventArgs ev)
        {
            if (Plugin.Instance.Config.LocalReporting == "") return;
            string message = Plugin.Instance.Config.LocalReporting.Replace("%reason%", ev.Reason.ToString());
            message = message.Replace("%reported%", ev.Target.ToString());
            message = message.Replace("%reporter%", ev.Issuer.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.server_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.server_url, message, Plugin.Instance.Config.server_name);
        }
    }
}
