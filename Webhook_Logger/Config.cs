using Exiled.API.Features;
using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace Webhook_Logger
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("Send all Messages to the Console")]
        public bool debug_to_console { get; set; } = false;

        [Description("Add the current Date and Time to the Discord messages.")]
        public bool addDate { get; set; } = true;

        [Description("Localisation for the Date and Time (e.g. de-DE, fr-FR, en-US)")]
        public string localisation { get; set; } = "de-DE";

        [Description("Webhook for Map Events")]
        public string map_url { get; set; } = "https://ptb.discordapp.com/api/webhooks/737970157502070785/HJMeOa-cGyGlKAlHOduJMmELV0XPvE4xnFyMi6SQeqW_fBLMMrACB1LjO5IQMKBfw9Rr";
        public string map_name { get; set; } = "Map Logger";

        [Description("Webhook for Player Events")]
        public string player_url { get; set; } = "https://ptb.discordapp.com/api/webhooks/737970157502070785/HJMeOa-cGyGlKAlHOduJMmELV0XPvE4xnFyMi6SQeqW_fBLMMrACB1LjO5IQMKBfw9Rr";
        public string player_name { get; set; } = "Player Logger";

        [Description("Webhook for Round Events")]
        public string round_url { get; set; } = "https://ptb.discordapp.com/api/webhooks/737970157502070785/HJMeOa-cGyGlKAlHOduJMmELV0XPvE4xnFyMi6SQeqW_fBLMMrACB1LjO5IQMKBfw9Rr";
        public string round_name { get; set; } = "Round Logger";

        [Description("Webhook for Scp106 Events")]
        public string scp049_url { get; set; } = "https://ptb.discordapp.com/api/webhooks/737970157502070785/HJMeOa-cGyGlKAlHOduJMmELV0XPvE4xnFyMi6SQeqW_fBLMMrACB1LjO5IQMKBfw9Rr";
        public string scp049_name { get; set; } = "Scp049 Logger";

        [Description("Webhook for Scp106 Events")]
        public string scp079_url { get; set; } = "https://ptb.discordapp.com/api/webhooks/737970157502070785/HJMeOa-cGyGlKAlHOduJMmELV0XPvE4xnFyMi6SQeqW_fBLMMrACB1LjO5IQMKBfw9Rr";
        public string scp079_name { get; set; } = "Scp079 Logger";

        [Description("Webhook for Scp106 Events")]
        public string scp096_url { get; set; } = "https://ptb.discordapp.com/api/webhooks/737970157502070785/HJMeOa-cGyGlKAlHOduJMmELV0XPvE4xnFyMi6SQeqW_fBLMMrACB1LjO5IQMKBfw9Rr";
        public string scp096_name { get; set; } = "Scp096 Logger";

        [Description("Webhook for Scp106 Events")]
        public string scp106_url { get; set; } = "https://ptb.discordapp.com/api/webhooks/737970157502070785/HJMeOa-cGyGlKAlHOduJMmELV0XPvE4xnFyMi6SQeqW_fBLMMrACB1LjO5IQMKBfw9Rr";
        public string scp106_name { get; set; } = "Scp106 Logger";

        [Description("Webhook for Scp914 Events")]
        public string scp914_url { get; set; } = "https://ptb.discordapp.com/api/webhooks/737970157502070785/HJMeOa-cGyGlKAlHOduJMmELV0XPvE4xnFyMi6SQeqW_fBLMMrACB1LjO5IQMKBfw9Rr";
        public string scp914_name { get; set; } = "Scp914 Logger";

        [Description("Webhook for Server Events")]
        public string server_url { get; set; } = "https://ptb.discordapp.com/api/webhooks/737970157502070785/HJMeOa-cGyGlKAlHOduJMmELV0XPvE4xnFyMi6SQeqW_fBLMMrACB1LjO5IQMKBfw9Rr";
        public string server_name { get; set; } = "Server Logger";

        [Description("Webhook for Warhead Events")]
        public string warhead_url { get; set; } = "https://ptb.discordapp.com/api/webhooks/737970157502070785/HJMeOa-cGyGlKAlHOduJMmELV0XPvE4xnFyMi6SQeqW_fBLMMrACB1LjO5IQMKBfw9Rr";
        public string warhead_name { get; set; } = "Warhead Logger";

        /// <summary>
        /// Map
        /// </summary>
        [Description("When the Decontamination is announced")]
        public string AnnouncingDecontamination { get; set; } = ":speaker: Decontamination is being announced.";
        
        [Description("When Cassie announces Ntf enters the facility %name% = NTF unit name, %number% = NTF unit number, %scps% = remaining SCPs")]
        public string AnnouncingNtfEntrance { get; set; } = ":speaker: Mobile Task Force Unit, Epsilon-11, %name% %number%, has entered the facility. All remaining personnel are advised to proceed with standard evacuation protocols until an MTF squad reaches your destination. Awaiting re-containment of: %scps% SCP subject(s)";
        
        [Description("When Cassie announces that an Scp has died. %cause% = The reason the SCP died, %killer% = The player how killed the SCP, %role% the role the SCP was.")]
        public string AnnouncingScpTermination { get; set; } = ":speaker: %role% contained successfully, killed by %cause%(%killer%)";
        
        [Description("When the Decontamination is started")]
        public string Decontaminating { get; set; } = ":biohazard: Decontamination started";
        
        [Description("When a Grenade explodes. %targets% = The targets of the grenade, %frag% if it is a Frag Grenade (bool)")]
        public string ExplodingGrenade { get; set; } = ":bomb: Grenade Targets: %targets%, Is a Frag Grenade: %frag%";
        
        [Description("When a Generator is activated. %room% the room the generator is in.")]
        public string GeneratorActivated { get; set; } = ":warning: Generator in room %room% was activated.";

        /// <summary>
        /// Player
        /// </summary>
        [Description("When a player preauthenticates. %country% = Country of the player, %id% = the id of the player")]
        public string PreAuthenticating { get; set; } = ":regional_indicator_p: Player preauthenticatinc: Player is from %country% and has the id %id%";
        
        [Description("When a player is kicked. %player% = The player being kicked, %reason% = The reason the player is being kicked")]
        public string Kicked { get; set; } = ":door: %player% has been kicked for `%reason%`.";
        
        [Description("When a player is banned. %player% = The banned player, %reason% = The reason the Player was banned for, %expires% = The Date the ban expires, %issuer% = The Person who banned the player")]
        public string Banned { get; set; } = ":lock: %player% has been banned until %expires% by %issuer% for %reason%";
        
        [Description("When a players uses a medical item. %player% = The player using the item, %item% the item")]
        public string MedicalItemUsed { get; set; } = ":medical_symbol: %player% used the medical item %item%";
        
        [Description("When a player stops using a medical item. %player% = The player using the item, %item% the item")]
        public string StoppingMedicalItem { get; set; } = ":no_entry_sign: %player% stopped using the medical item %item%";
        
        /*[Description("")]
        public string Interacted { get; set; } = "";*/
        
        /*[Description("")]
        public string SpawningRagdoll { get; set; } = "";*/
        
        [Description("When a player activates the warhead pannel. ")]
        public string ActivatingWarheadPanel { get; set; } = ":unlock: %player% activated the Warhead Pannel";
        
        [Description("When a player joins the Server. %player% = Player + ID + Steam/DiscordId, %ip% = The Ip of the player joining, you might remove this if this log is public.")]
        public string Joined { get; set; } = ":door: %player% joined the Server using the IP Adress %ip%";
        
        [Description("When a player leaves the Server. %role% = The Role the player was. %player% = Player + ID + Steam/DiscordId, %ip% = The Ip of the player joining, you might remove this if this log is public.")]
        public string Left { get; set; } = ":door: %player% left the Server while playing as %role%. The player had the IP %ip%.";
        
        [Description("When a player takes damage. %player% = The player taking damage, %attacker% = the player attacking the player")]
        public string Hurting { get; set; } = ":drop_of_blood: %player% took damage. The damage was made by the player %attacker%";
        
        [Description("When a player dies. %player% = The player who died, %attacker% = The player who killed the player")]
        public string Died { get; set; } = ":coffin: %player% died . The attacker was %attacker%.";
        
        [Description("When a player Changes Role. %player% the Player changing role, %role% the role the Player now has, %items% the items the player had white changing roles")]
        public string ChangingRole { get; set; } = ":left_right_arrow: %player% changed role to %role%.";
        
        [Description("When someone throws a grenade. %player% = The player")]
        public string ThrowingGrenade { get; set; } = ":bomb: %player% used a grenade";
        
        [Description("When someone drops an Item. %player% = Player dropping the Item")]
        public string DroppingItem { get; set; } = ":paperclip: %player% dropped an Item";
        
        [Description("When someone picked up an Item. %player% = Player dropping the Item")]
        public string PickingUpItem { get; set; } = ":paperclip: %player% picked up an item.";
        
        [Description("When someone is being handcuffed. %player% the player being handcuffed, %team% the team the player is in.")]
        public string Handcuffing { get; set; } = ":chains: %player% playing as %team% has been handcuffed";
        
        [Description("When someones Handcuff is removed. %player% the player being handcuffed, %team% the team the player is in.")]
        public string RemovingHandcuffs { get; set; } = ":chains: %player% playing as %team% Handcuffs have been removed";
        
        [Description("When a player escapes. %player% the player, %role% = new role")]
        public string Escaping { get; set; } = ":woman_running: %player% escaped and is now %role%";
        
        [Description("When a player talk with the intercom. %player% = player using the intercom")]
        public string IntercomSpeaking { get; set; } = ":microphone2: %player% uses the intercom";
        
        [Description("When a player shoots. %player% = player shooting [THIS WILL SPAM THE CHAT]")]
        public string Shot { get; set; } = ":gun: %player% shot";
        
        [Description("When someone enters the pocket dimenson. %player% = player entering the pocket dimension")]
        public string EnteringPocketDimension { get; set; } = ":detective: %player% entered the Pocket Dimension.";
        
        [Description("When someone escapes the pocket dimenson. %player% = player entering the pocket dimension")]
        public string EscapingPocketDimension { get; set; } = ":detective: %player% left the Pocket Dimension.";
        
        [Description("When someone dies the pocket dimenson. %player% = player not surviving the pocket dimension")]
        public string FailingEscapePocketDimension { get; set; } = ":detective: %player% Failled to find the exit of the pocket dimension.";
        
        [Description("When someone reload their wapon. %player% = the player reloading")]
        public string ReloadingWeapon { get; set; } = ":gun: %player% reloading their wappon.";
        
        [Description("When someone spawns. %player% = is the Player, %role% = is the role")]
        public string Spawning { get; set; } = ":new: %player% spawned as %role%";
        
        [Description("When someone enters the Femur Breaker. %player% = the player")]
        public string EnteringFemurBreaker { get; set; } = ":dagger: %player% entered the FemurBreaker";
        
        /*[Description("")]
        public string SyncingData { get; set; } = "";*/
        
        [Description("When someone uses a door. %player% = is the player using the door, %door% = the door used")]
        public string InteractingDoor { get; set; } = ":door: %player% used the door %door%";
        
        [Description("When someone opens a locker. %player% = player")]
        public string InteractingLocker { get; set; } = ":lock_with_ink_pen: %player% used an Locker.";
        
        [Description("When a Player unlock a Generator. %player% = The Player unlocking a generator.")]
        public string UnlockingGenerator { get; set; } = ":unlock: %player% unlocked a generator";
        
        [Description("When a player Closes a Generator. %player% = Player closing the generator.")]
        public string ClosingGenerator { get; set; } = ":mailbox_closed: %player% closed a generator";
        
        [Description("When a player remove the tablet from the generator. %player% = The player ejecting the tablet")]
        public string EjectingGeneratorTablet { get; set; } = ":iphone: %player% removed a tablet outof a generator";
        
        [Description("When a player adds the tablet to the generator. %player% = The player inserting the tablet")]
        public string InsertingGeneratorTablet { get; set; } = ":iphone: %player% added a tablet to a generator";
        
        [Description("When a player opens a generator. %player% = Player opening the generator")]
        public string OpeningGenerator { get; set; } = ":mailbox_with_no_mail: %player% opened a generator";
        
        [Description("When a player triggers a tesla. %player% is the player trigering it.")]
        public string TriggeringTesla { get; set; } = ":cloud_lightning: %player% triggered a tesla";
        
        [Description("When a player uses an Elevator. %player% is the player using it.")]
        public string InteractingElevator { get; set; } = ":outbox_tray: %player% triggered an elevator.";
        
        /*[Description("")]
        public string ChangingGroup { get; set; } = "";*/
        
        [Description("When someone changes the selected item. %player% is the player, %newitem% is the new item, %olditem% is the old item")]
        public string ChangingItem { get; set; } = ":paperclips: %player% changed the selected item from %olditem% to %newitem%";
        
        /// <summary>
        /// Scp049
        /// </summary>
        [Description("When Scp049 starts respawning someone. %049name% = The name of Scp049, %049hp% = The HP of Scp049, %targetname% = the name of the target, %targetteam% = the team of the target")]
        public string StartingRecall { get; set; } = ":zombie: %049name%(%049hp%HP) is respawning %targetname% as %targetteam%";

        [Description("When Scp049 respawned someone. %049name% = The name of Scp049, %049hp% = The HP of Scp049, %targetname% = the name of the target, %targetteam% = the team of the target")]
        public string FinishingRecall { get; set; } = ":zombie: %049name%(%049hp%HP) respawned %targetname% as %targetteam%";

        /// <summary>
        /// Scp079
        /// </summary>
        [Description("When Scp079 gains Experience, %level% = current level, %experience% = current experience, %energy% = current energy")]
        public string GainingExperience { get; set; } = ":arrow_double_up: Scp079(%player%) gained Experience. It is now level %level% and it has %experience% Experience and has %energy% Energy";

        [Description("When Scp079 gains Experience, %level% = current level, %experience% = current experience, %energy% = current energy")]
        public string GainingLevel { get; set; } = ":arrow_double_up: Scp079(%player%) gained a Level. It is now level %level% and it has %experience% Experience and has %energy% Energy";
        
        [Description("When Scp079 opens a door, %level% = current level, %experience% = current experience, %energy% = current energy, Seems not to work")]
        public string InteractingDoor079 { get; set; } = ":door: Scp079(%player%) opened a door (%door%). It is now level %level% and it has %experience% Experience and has %energy% Energy";
        
        [Description("When Scp079 uses a tesla, %level% = current level, %experience% = current experience, %energy% = current energy, Seems not to work")]
        public string InteractingTesla { get; set; } = ":electric_plug: Scp079(%player%) uses a Tesla (%tesla%). It is now level %level% and it has %experience% Experience and has %energy% Energy";

        /// <summary>
        /// Scp096
        /// </summary>
        [Description("When Scp096 starts enraging")]
        public string Enraging { get; set; } = ":cry: Scp096 played by %player% is enraging.";

        [Description("When Scp096 calms down")]
        public string CalmingDown { get; set; } = ":cry: Scp096 played by %player% is calming down.";

        /// <summary>
        /// Scp106
        /// </summary>
        [Description("When Scp106 is contained")]
        public string Containing { get; set; } = ":control_knobs: Scp106 contained by %player% as %team%";

        [Description("When Scp106 creates a Portal")]
        public string CreatingPortal { get; set; } = ":control_knobs: Scp106 (%player%) created a portal.";

        [Description("When Scp106 teleports")]
        public string Teleporting { get; set; } = ":control_knobs: Scp106 (%player%) teleported to a portal.";

        /// <summary>
        /// Scp914
        /// </summary>
        [Description("When Items and Players are upgraded. %setting% = Knop setting, %players% = players in 914, %items% = item count")]
        public string UpgradingItems { get; set; } = ":heavy_plus_sign: Upgrading %items% Items on %setting%, Players: %players%";

        [Description("When Scp914 is activated. %player% = player")]
        public string Activating { get; set; } = ":on: %player% stated Scp914.";

        [Description(" When Changing the 914 Setting, %player% = Player, %setting% = Knop setting")]
        public string ChangingKnobSetting { get; set; } = ":gear: %player% set Scp914 to %setting%";

        /// <summary>
        /// Server Events
        /// </summary>
        [Description("When waiting for Players.")]
        public string WaitingForPlayers { get; set; } = ":clock1: Waiting for players...";

        [Description("When the Round has started.")]
        public string RoundStarted { get; set; } = ":arrow_forward: Round started...";

        [Description("When the Round is ended. %team% = The Winning Team, %time% = Time -> Restart")]
        public string RoundEnded { get; set; } = ":octagonal_sign: Round ended. Winning Team: %team%, Time remaining: %time%";

        [Description("When the Round is restarting.")]
        public string RestartingRound { get; set; } = ":arrows_counterclockwise: Round restarting...";

        [Description("When someone is reported Cheating. %reporter% = The Person who ")]
        public string ReportingCheater { get; set; } = ":warning: %reporter% reported %reported% for %reason%";

        [Description("Message when NTF or Chaos are respawning. %team% = The team which spawns, %maxRespawn% the maximal amount of players which can respawn, %players% a list of players with with Steam/Discordid, Ingame ID and Nickname")]
        public string RespawningTeam { get; set; } = ":blue_car: Next respawn is %team% with an maxial Playercount of %maxRespawn% with the players %players%";

        [Description("When someone sends an command with the Ingame Console. %encrypted% = Message is encrypted, %name% = Playername, %args% = Command args, %command% = command")]
        public string SendingConsoleCommand { get; set; } = ":desktop: %name% send the command `.%command% %args%`. The command was encrypted: %encrypted%";

        [Description("When someone sends an command with the Ingame Console. %name% = Playername, %args% = Command args, %command% = command")]
        public string SendingRemoteAdminCommand { get; set; } = ":desktop: %name% send the RA command `%command% %args%`.";

        [Description("When the Round has started.")]
        public string ReloadedConfigs { get; set; } = ":arrows_clockwise: Reloaded Configs";

        [Description("When the Round has started.")]
        public string ReloadedRA { get; set; } = ":arrows_clockwise: Reloaded Remote Admin";

        [Description("When the Round has started.")]
        public string ReloadedGameplay { get; set; } = ":arrows_clockwise: Reloaded Gameplay";

        [Description("When a player is localy reported.")]
        public string LocalReporting { get; set; } = ":warning: %reporter% reported %reported% for %reason%";

        /// <summary>
        /// Warhead
        /// </summary>

        [Description("When someone stops the warhead.")]
        public string Stopping { get; set; } = ":bomb: Warhead stoped by %player%";

        [Description("When someone starts the warhead.")]
        public string Starting { get; set; } = ":bomb: Warhead stoped by %player%";

        [Description("When someone starts the warhead.")]
        public string Detonated { get; set; } = ":bomb: Warhead started by %player%";
    }
}
