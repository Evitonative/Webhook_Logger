using Exiled.API.Features;
using Exiled.API.Enums;
using System;

using Map = Exiled.Events.Handlers.Map;
using Player = Exiled.Events.Handlers.Player;
using Scp049 = Exiled.Events.Handlers.Scp049;
using Scp079 = Exiled.Events.Handlers.Scp079;
using Scp096 = Exiled.Events.Handlers.Scp096;
using Scp106 = Exiled.Events.Handlers.Scp106;
using Scp914_light = Exiled.Events.Handlers.Scp914;
using Server = Exiled.Events.Handlers.Server;
using Warhead = Exiled.Events.Handlers.Warhead;
using System.Security.Policy;
using System.Collections.Specialized;

namespace Webhook_Logger
{
    public class Plugin : Plugin<Config>
    {
        private static readonly Lazy<Plugin> LazyInstance = new Lazy<Plugin>(valueFactory: () => new Plugin());
        public static Plugin Instance => LazyInstance.Value;

        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        private Handlers.Map map;
        private Handlers.Player player;
        private Handlers.Scp049 scp049;
        private Handlers.Scp079 scp079;
        private Handlers.Scp096 scp096;
        private Handlers.Scp106 scp106;
        private Handlers.Scp914 scp914;
        private Handlers.Server server;
        private Handlers.Warhead warhead;

        private Plugin()
        {
        }

        public override void OnEnabled()
        {
            RegisterEvents();
        }

        public override void OnDisabled()
        {
            UnRegisterEvents();
        }

        public void RegisterEvents()
        {
            map = new Handlers.Map();
            player = new Handlers.Player(); //TODO: Beginn, i like it it will take some time, but it's fine
            scp049 = new Handlers.Scp049();
            scp079 = new Handlers.Scp079();
            scp096 = new Handlers.Scp096();
            scp106 = new Handlers.Scp106();
            scp914 = new Handlers.Scp914();
            server = new Handlers.Server();
            warhead = new Handlers.Warhead();

            Map.AnnouncingDecontamination += map.AnnouncingDecontamination;
            Map.AnnouncingNtfEntrance += map.AnnouncingNtfEntrance;
            Map.AnnouncingScpTermination += map.AnnouncingScpTermination;
            Map.Decontaminating += map.Decontaminating;
            Map.ExplodingGrenade += map.ExplodingGrenade;
            Map.GeneratorActivated += map.GeneratorActivated;

            Player.PreAuthenticating += player.PreAuthenticating;
            //Player.Kicking += player.Kicking;
            Player.Kicked += player.Kicked;
            //Player.Banning += player.Banning;
            Player.Banned += player.Banned;
            Player.MedicalItemUsed += player.MedicalItemUsed;
            Player.StoppingMedicalItem += player.StoppingMedicalItem;
            //Player.Interacted += player.Interacted;
            //Player.SpawningRagdoll += player.SpawningRagdoll;
            Player.ActivatingWarheadPanel += player.ActivatingWarheadPanel;
            //Player.UsingMedicalItem += player.UsingMedicalItem;
            Player.Joined += player.Joined;
            Player.Left += player.Left;
            Player.Hurting += player.Hurting;
            //Player.Dying += Player.Dying;
            Player.Died += player.Died;
            Player.ChangingRole += player.ChangingRole;
            Player.ThrowingGrenade += player.ThrowingGrenade;
            Player.DroppingItem += player.DroppingItem;
            Player.PickingUpItem += player.PickingUpItem;
            Player.Handcuffing += player.Handcuffing;
            Player.RemovingHandcuffs += player.RemovingHandcuffs;
            Player.Escaping += player.Escaping;
            Player.IntercomSpeaking += player.IntercomSpeaking;
            Player.Shot += player.Shot;
            //Player.Shooting += player.Shooting;
            Player.EnteringPocketDimension += player.EnteringPocketDimension;
            Player.EscapingPocketDimension += player.EscapingPocketDimension;
            Player.FailingEscapePocketDimension += player.FailingEscapePocketDimension;
            Player.ReloadingWeapon += player.ReloadingWeapon;
            Player.Spawning += player.Spawning;
            Player.EnteringFemurBreaker += player.EnteringFemurBreaker;
            //Player.SyncingData += player.SyncingData;
            Player.ChangingItem += player.ChangingItem;
            //Player.ChangingGroup += player.ChangingGroup;
            Player.InteractingDoor += player.InteractingDoor;
            Player.InteractingElevator += player.InteractingElevator;
            Player.InteractingLocker += player.InteractingLocker;
            Player.TriggeringTesla += player.TriggeringTesla;
            Player.UnlockingGenerator += player.UnlockingGenerator;
            Player.OpeningGenerator += player.OpeningGenerator;
            Player.ClosingGenerator += player.ClosingGenerator;
            Player.InsertingGeneratorTablet += player.InsertingGeneratorTablet;
            Player.EjectingGeneratorTablet += player.EjectingGeneratorTablet;

            Scp049.StartingRecall += scp049.StartingRecall;
            Scp049.FinishingRecall += scp049.FinishingRecall;

            Scp079.GainingExperience += scp079.GainingExperience;
            Scp079.GainingLevel += scp079.GainingLevel;
            Scp079.InteractingDoor += scp079.InteractingDoor;
            Scp079.InteractingTesla += scp079.InteractingTesla;

            Scp096.Enraging += scp096.Enraging;
            Scp096.CalmingDown += scp096.CalmingDown;

            Scp106.Containing += scp106.Containing;
            Scp106.CreatingPortal += scp106.CreatingPortal;
            Scp106.Teleporting += scp106.Teleporting;

            Scp914_light.UpgradingItems += scp914.UpgradingItems;
            Scp914_light.Activating += scp914.Activating;
            Scp914_light.ChangingKnobSetting += scp914.ChangingKnobSetting;

            Server.WaitingForPlayers += server.WaitingForPlayers;
            Server.RoundStarted += server.RoundStarted;
            Server.RoundEnded += server.RoundEnded;
            Server.RestartingRound += server.RestartingRound;
            Server.ReportingCheater += server.ReportingCheater;
            Server.RespawningTeam += server.RespawningTeam;
            Server.SendingConsoleCommand += server.SendingConsoleCommand;
            Server.SendingRemoteAdminCommand += server.SendingRemoteAdminCommand;
            Server.LocalReporting += server.LocalReporting;
            Server.ReloadedConfigs += server.ReloadedConfigs;
            Server.ReloadedGameplay += server.ReloadedGameplay;
            Server.ReloadedRA += server.ReloadedRA;

            Warhead.Starting += warhead.Starting;
            Warhead.Stopping += warhead.Stopping;
            Warhead.Detonated += warhead.Detonated;
        }

        public void UnRegisterEvents()
        {
            Map.AnnouncingDecontamination -= map.AnnouncingDecontamination;
            Map.AnnouncingNtfEntrance -= map.AnnouncingNtfEntrance;
            Map.AnnouncingScpTermination -= map.AnnouncingScpTermination;
            Map.Decontaminating -= map.Decontaminating;
            Map.ExplodingGrenade -= map.ExplodingGrenade;
            Map.GeneratorActivated -= map.GeneratorActivated;

            Player.PreAuthenticating -= player.PreAuthenticating;
            //Player.Kicking -= player.Kicking;
            Player.Kicked -= player.Kicked;
            //Player.Banning -= player.Banning;
            Player.Banned -= player.Banned;
            Player.MedicalItemUsed -= player.MedicalItemUsed;
            Player.StoppingMedicalItem -= player.StoppingMedicalItem;
            //Player.Interacted -= player.Interacted;
            //Player.SpawningRagdoll -= player.SpawningRagdoll;
            Player.ActivatingWarheadPanel -= player.ActivatingWarheadPanel;
            //Player.UsingMedicalItem -= player.UsingMedicalItem;
            Player.Joined -= player.Joined;
            Player.Left -= player.Left;
            Player.Hurting -= player.Hurting;
            //Player.Dying -= Player.Dying;
            Player.Died -= player.Died;
            Player.ChangingRole -= player.ChangingRole;
            Player.ThrowingGrenade -= player.ThrowingGrenade;
            Player.DroppingItem -= player.DroppingItem;
            Player.PickingUpItem -= player.PickingUpItem;
            Player.Handcuffing -= player.Handcuffing;
            Player.RemovingHandcuffs -= player.RemovingHandcuffs;
            Player.Escaping -= player.Escaping;
            Player.IntercomSpeaking -= player.IntercomSpeaking;
            Player.Shot -= player.Shot;
            //Player.Shooting -= player.Shooting;
            Player.EnteringPocketDimension -= player.EnteringPocketDimension;
            Player.EscapingPocketDimension -= player.EscapingPocketDimension;
            Player.FailingEscapePocketDimension -= player.FailingEscapePocketDimension;
            Player.ReloadingWeapon -= player.ReloadingWeapon;
            Player.Spawning -= player.Spawning;
            Player.EnteringFemurBreaker -= player.EnteringFemurBreaker;
            //Player.SyncingData -= player.SyncingData;
            Player.ChangingItem -= player.ChangingItem;
            //Player.ChangingGroup -= player.ChangingGroup;
            Player.InteractingDoor -= player.InteractingDoor;
            Player.InteractingElevator -= player.InteractingElevator;
            Player.InteractingLocker -= player.InteractingLocker;
            Player.TriggeringTesla -= player.TriggeringTesla;
            Player.UnlockingGenerator -= player.UnlockingGenerator;
            Player.OpeningGenerator -= player.OpeningGenerator;
            Player.ClosingGenerator -= player.ClosingGenerator;
            Player.InsertingGeneratorTablet -= player.InsertingGeneratorTablet;
            Player.EjectingGeneratorTablet -= player.EjectingGeneratorTablet;

            Scp049.StartingRecall -= scp049.StartingRecall;
            Scp049.FinishingRecall -= scp049.FinishingRecall;

            Scp079.GainingExperience -= scp079.GainingExperience;
            Scp079.GainingLevel -= scp079.GainingLevel;
            Scp079.InteractingDoor -= scp079.InteractingDoor;
            Scp079.InteractingTesla -= scp079.InteractingTesla;

            Scp096.Enraging -= scp096.Enraging;
            Scp096.CalmingDown -= scp096.CalmingDown;

            Scp106.Containing -= scp106.Containing;
            Scp106.CreatingPortal -= scp106.CreatingPortal;
            Scp106.Teleporting -= scp106.Teleporting;

            Scp914_light.UpgradingItems -= scp914.UpgradingItems;
            Scp914_light.Activating -= scp914.Activating;
            Scp914_light.ChangingKnobSetting -= scp914.ChangingKnobSetting;

            Server.WaitingForPlayers -= server.WaitingForPlayers;
            Server.RoundStarted -= server.RoundStarted;
            Server.RoundEnded -= server.RoundEnded;
            Server.RestartingRound -= server.RestartingRound;
            Server.ReportingCheater -= server.ReportingCheater;
            Server.RespawningTeam -= server.RespawningTeam;
            Server.SendingConsoleCommand -= server.SendingConsoleCommand;
            Server.SendingRemoteAdminCommand -= server.SendingRemoteAdminCommand;
            Server.LocalReporting -= server.LocalReporting;
            Server.ReloadedConfigs -= server.ReloadedConfigs;
            Server.ReloadedGameplay -= server.ReloadedGameplay;
            Server.ReloadedRA -= server.ReloadedRA;

            Warhead.Starting -= warhead.Starting;
            Warhead.Stopping -= warhead.Stopping;
            Warhead.Detonated -= warhead.Detonated;

            map = null;
            player = null;
            scp049 = null;
            scp079 = null;
            scp096 = null;
            scp106 = null;
            scp914 = null;
            server = null;
            warhead = null;
        }

        public static void sendWebHook(string Url, string msg, string Username)
        {
            if (Plugin.Instance.Config.addDate)
            {

                Http.Post(Url, new System.Collections.Specialized.NameValueCollection()
                {
                    {
                       "username",
                        Username
                    },
                    {
                       "content",
                      "`" + DateTime.Now.ToString(System.Globalization.CultureInfo.CreateSpecificCulture(Plugin.Instance.Config.localisation)) + "` " + msg
                    }
                });
            }
            else
            {
                Http.Post(Url, new System.Collections.Specialized.NameValueCollection()
                {
                    {
                       "username",
                        Username
                    },
                    {
                       "content",
                        msg
                    }
                });

            }
        }
    }
}
