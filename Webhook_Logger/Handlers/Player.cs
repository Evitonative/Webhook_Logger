using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace Webhook_Logger.Handlers
{
    class Player
    {
        internal void PreAuthenticating(PreAuthenticatingEventArgs ev)
        {
            if (Plugin.Instance.Config.PreAuthenticating == "") return;
            string message = Plugin.Instance.Config.PreAuthenticating.Replace("%country%", ev.Country.ToString());
            message = message.Replace("%id%", ev.UserId.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void Kicked(KickedEventArgs ev)
        {
            if (Plugin.Instance.Config.Kicked == "") return;
            string message = Plugin.Instance.Config.Kicked.Replace("%player%", ev.Player.ToString());
            message = message.Replace("%reason%", ev.Reason.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void Banned(BannedEventArgs ev)
        {
            if (Plugin.Instance.Config.Banned == "") return;
            string message = Plugin.Instance.Config.Banned.Replace("%player%", ev.Player.ToString());
            message = message.Replace("%reason%", ev.Details.Reason.ToString());
            message = message.Replace("%expires%", ev.Details.Expires.ToString());
            message = message.Replace("%issuer%", ev.Details.Issuer.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void MedicalItemUsed(UsedMedicalItemEventArgs ev)
        {
            if (Plugin.Instance.Config.MedicalItemUsed == "") return;
            string message = Plugin.Instance.Config.MedicalItemUsed.Replace("%player%", ev.Player.ToString());
            message = message.Replace("%item%", ev.Item.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void StoppingMedicalItem(StoppingMedicalItemEventArgs ev)
        {
            if (Plugin.Instance.Config.StoppingMedicalItem == "") return;
            string message = Plugin.Instance.Config.StoppingMedicalItem.Replace("%player%", ev.Player.ToString());
            message = message.Replace("%item%", ev.Item.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        /*internal void Interacted(InteractedEventArgs ev)
        {
            //I don't know why this is a thing. If somethin is missing I will implement this
        }*/

        /*internal void SpawningRagdoll(SpawningRagdollEventArgs ev)
        {
            //It's not needed because there is Died
        }*/

        internal void ActivatingWarheadPanel(ActivatingWarheadPanelEventArgs ev)
        {
            if (Plugin.Instance.Config.ActivatingWarheadPanel == "") return;
            string message = Plugin.Instance.Config.ActivatingWarheadPanel.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void Joined(JoinedEventArgs ev)
        {
            if (Plugin.Instance.Config.Joined == "") return;
            string message = Plugin.Instance.Config.Joined.Replace("%player%", ev.Player.ToString());
            message = message.Replace("%ip%", ev.Player.IPAddress);


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void Left(LeftEventArgs ev)
        {
            if (Plugin.Instance.Config.Left == "") return;
            string message = Plugin.Instance.Config.Left.Replace("%player%", ev.Player.ToString());
            message = message.Replace("%ip%", ev.Player.IPAddress);
            message = message.Replace("%role%", ev.Player.Role.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void Hurting(HurtingEventArgs ev)
        {
            if (Plugin.Instance.Config.Hurting == "") return;
            string message = Plugin.Instance.Config.Hurting.Replace("%player%", ev.Target.ToString());
            message = message.Replace("%attacker%", ev.Attacker.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void Died(DiedEventArgs ev)
        {
            if (Plugin.Instance.Config.Died == "") return;
            string message = Plugin.Instance.Config.Died.Replace("%player%", ev.Target.ToString());
            message = message.Replace("%attacker%", ev.Killer.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void ChangingRole(ChangingRoleEventArgs ev)
        {
            if (Plugin.Instance.Config.ChangingRole == "") return;
            string message = Plugin.Instance.Config.ChangingRole.Replace("%player%", ev.Player.ToString());
            message = message.Replace("%role%", ev.NewRole.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void ThrowingGrenade(ThrowingGrenadeEventArgs ev)
        {
            if (Plugin.Instance.Config.ThrowingGrenade == "") return;
            string message = Plugin.Instance.Config.ThrowingGrenade.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void DroppingItem(DroppingItemEventArgs ev)
        {
            if (Plugin.Instance.Config.DroppingItem == "") return;
            string message = Plugin.Instance.Config.DroppingItem.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void PickingUpItem(PickingUpItemEventArgs ev)
        {
            if (Plugin.Instance.Config.PickingUpItem == "") return;
            string message = Plugin.Instance.Config.PickingUpItem.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void Handcuffing(HandcuffingEventArgs ev)
        {
            if (Plugin.Instance.Config.Handcuffing == "") return;
            string message = Plugin.Instance.Config.Handcuffing.Replace("%player%", ev.Target.ToString());
            message = message.Replace("%team%", ev.Target.Team.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void RemovingHandcuffs(RemovingHandcuffsEventArgs ev)
        {
            if (Plugin.Instance.Config.RemovingHandcuffs == "") return;
            string message = Plugin.Instance.Config.RemovingHandcuffs.Replace("%player%", ev.Target.ToString());
            message = message.Replace("%team%", ev.Target.Team.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void Escaping(EscapingEventArgs ev)
        {
            if (Plugin.Instance.Config.Escaping == "") return;
            string message = Plugin.Instance.Config.Escaping.Replace("%player%", ev.Player.ToString());
            message = message.Replace("%role%", ev.NewRole.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void IntercomSpeaking(IntercomSpeakingEventArgs ev)
        {
            if (Plugin.Instance.Config.IntercomSpeaking == "") return;
            string message = Plugin.Instance.Config.IntercomSpeaking.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void Shot(ShotEventArgs ev)
        {
            if (Plugin.Instance.Config.Shot == "") return;
            string message = Plugin.Instance.Config.Shot.Replace("%player%", ev.Shooter.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void EnteringPocketDimension(EnteringPocketDimensionEventArgs ev)
        {
            if (Plugin.Instance.Config.EnteringPocketDimension == "") return;
            string message = Plugin.Instance.Config.EnteringPocketDimension.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void EscapingPocketDimension(EscapingPocketDimensionEventArgs ev)
        {
            if (Plugin.Instance.Config.EscapingPocketDimension == "") return;
            string message = Plugin.Instance.Config.EscapingPocketDimension.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void FailingEscapePocketDimension(FailingEscapePocketDimensionEventArgs ev)
        {
            if (Plugin.Instance.Config.FailingEscapePocketDimension == "") return;
            string message = Plugin.Instance.Config.FailingEscapePocketDimension.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void ReloadingWeapon(ReloadingWeaponEventArgs ev)
        {
            if (Plugin.Instance.Config.ReloadingWeapon == "") return;
            string message = Plugin.Instance.Config.ReloadingWeapon.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void Spawning(SpawningEventArgs ev)
        {
            if (Plugin.Instance.Config.Spawning == "") return;
            string message = Plugin.Instance.Config.Spawning.Replace("%player%", ev.Player.ToString());
            message = message.Replace("%role%", ev.Player.Role.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void EnteringFemurBreaker(EnteringFemurBreakerEventArgs ev)
        {
            if (Plugin.Instance.Config.EnteringFemurBreaker == "") return;
            string message = Plugin.Instance.Config.EnteringFemurBreaker.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        /*internal void SyncingData(SyncingDataEventArgs ev)
        {
        }*/

        internal void InteractingDoor(InteractingDoorEventArgs ev)
        {
            if (Plugin.Instance.Config.InteractingDoor == "") return;
            string message = Plugin.Instance.Config.InteractingDoor.Replace("%player%", ev.Player.ToString());
            message = message.Replace("%door%", ev.Door.name.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void InteractingLocker(InteractingLockerEventArgs ev)
        {
            if (Plugin.Instance.Config.InteractingLocker == "") return;
            string message = Plugin.Instance.Config.InteractingLocker.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void UnlockingGenerator(UnlockingGeneratorEventArgs ev)
        {
            if (Plugin.Instance.Config.UnlockingGenerator == "") return;
            string message = Plugin.Instance.Config.UnlockingGenerator.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void ClosingGenerator(ClosingGeneratorEventArgs ev)
        {
            if (Plugin.Instance.Config.ClosingGenerator == "") return;
            string message = Plugin.Instance.Config.ClosingGenerator.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);

        }

        internal void EjectingGeneratorTablet(EjectingGeneratorTabletEventArgs ev)
        {
            if (Plugin.Instance.Config.EjectingGeneratorTablet == "") return;
            string message = Plugin.Instance.Config.EjectingGeneratorTablet.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void InsertingGeneratorTablet(InsertingGeneratorTabletEventArgs ev)
        {
            if (Plugin.Instance.Config.InsertingGeneratorTablet == "") return;
            string message = Plugin.Instance.Config.InsertingGeneratorTablet.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void OpeningGenerator(OpeningGeneratorEventArgs ev)
        {
            if (Plugin.Instance.Config.OpeningGenerator == "") return;
            string message = Plugin.Instance.Config.OpeningGenerator.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void TriggeringTesla(TriggeringTeslaEventArgs ev)
        {
            if (Plugin.Instance.Config.TriggeringTesla == "") return;
            string message = Plugin.Instance.Config.TriggeringTesla.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        internal void InteractingElevator(InteractingElevatorEventArgs ev)
        {
            if (Plugin.Instance.Config.InteractingElevator == "") return;
            string message = Plugin.Instance.Config.InteractingElevator.Replace("%player%", ev.Player.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }

        /*internal void ChangingGroup(ChangingGroupEventArgs ev)
        {
        }*/

        internal void ChangingItem(ChangingItemEventArgs ev)
        {
            if (Plugin.Instance.Config.ChangingItem == "") return;
            string message = Plugin.Instance.Config.ChangingItem.Replace("%player%", ev.Player.ToString());
            message = message.Replace("%newitem%", ev.NewItem.id.ToString());
            message = message.Replace("%olditem%", ev.OldItem.id.ToString());


            if (Plugin.Instance.Config.debug_to_console)
                Log.Debug(message: "[ " + Plugin.Instance.Config.player_name + "] " + message);
            Plugin.sendWebHook(Plugin.Instance.Config.player_url, message, Plugin.Instance.Config.player_name);
        }
    }
}
