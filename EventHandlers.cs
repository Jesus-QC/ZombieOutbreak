using Exiled.API.Features;
using MEC;
using System.Collections.Generic;
using UnityEngine;

namespace ZombieOutbreak.Handlers
{
    public class EventHandlers
    {
        public ZombieOutbreak plugin;
        public EventHandlers(ZombieOutbreak plugin) => this.plugin = plugin;

        private int zombieplayers = 0;
        private bool entranceannouncmentsShitFix = true;

        private static readonly System.Random random = new System.Random();

        private static double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }

        public void OnRoundStarted()
        {
            zombieplayers = 0;
            entranceannouncmentsShitFix = true;

        double zombiespawns = RandomNumberBetween(1, 100);
            if(zombiespawns < plugin.Config.SpawnProbability)
            {
                double firstspawn = RandomNumberBetween(plugin.Config.MinTimeFirstSpawn, plugin.Config.MaxTimeFirstSpawn);
                Timing.CallDelayed((float)firstspawn, () => { Timing.RunCoroutine(doZombieOutbreak()); });
            }
        }
        public IEnumerator<float> doZombieOutbreak()
        {
            for (; ; )
            {
                double ramdomtime = RandomNumberBetween(plugin.Config.MinTimeBetweenOutbreak, plugin.Config.MaxTimeBetweenOutbreak);
                foreach (Player player in Player.List)
                {
                    if (player.IsDead && plugin.Config.MaxZombies > zombieplayers)
                    {
                        zombieplayers = zombieplayers + 1;
                        player.SetRole(RoleType.Scp0492);
                        player.Position = Map.GetRandomSpawnPoint(RoleType.Scp049);
                        Timing.CallDelayed((float)0.5, () => { player.Position = Map.GetRandomSpawnPoint(RoleType.Scp049); player.Health = plugin.Config.ZombiesHP; });
                        Timing.CallDelayed(2, () => { zombieplayers = zombieplayers - 1; });
                        if (entranceannouncmentsShitFix)
                        {
                            entranceannouncmentsShitFix = false;
                            if (plugin.Config.EntryCassie != string.Empty) { Cassie.Message(plugin.Config.EntryCassie, false, false); }
                            if (plugin.Config.EntryBroadcast != string.Empty) { Map.Broadcast(7, plugin.Config.EntryBroadcast); }
                            Timing.CallDelayed(2, () => { entranceannouncmentsShitFix = true; });
                        }
                    }
                }
                if (zombieplayers > 0 && zombieplayers < 2)
                {

                }
                yield return Timing.WaitForSeconds((float)ramdomtime);
            }
        }
    }
}