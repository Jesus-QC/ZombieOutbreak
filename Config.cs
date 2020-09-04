using Exiled.API.Interfaces;
using System.ComponentModel;

namespace ZombieOutbreak
{
    public sealed class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;
        [Description("ZombieOutage broadcast (Keep it empty for disabling it)")]
        public string EntryBroadcast { get; set; } = "<color=#F54646><b>A Zombie Outbreak has ocurred</b></color>";
        [Description("ZombieOutage cassie (Keep it empty for disabling it)")]
        public string EntryCassie { get; set; } = "SCP 0 0 8 has a breach of containment . AllRemaining";
        [Description("How much have health have a zombie of an outbreak")]
        public float ZombiesHP { get; set; } = 400;
        [Description("MaxNumber of Zombies in an outbreak")]
        public int MaxZombies { get; set; } = 8;
        [Description("Probability of a zombie outbreak happening")]
        public int SpawnProbability { get; set; } = 100;
        [Description("Minimun time for the first zombie outbreak from round start (Putting this in 2 or lower could break the plugin)")]
        public int MinTimeFirstSpawn { get; set; } = 120;
        [Description("Maximun time for the first zombie outbreak")]
        public int MaxTimeFirstSpawn { get; set; } = 170;
        [Description("Minimun time between zombie outbreaks (Putting this in 2 or lower could break the plugin)")]
        public int MinTimeBetweenOutbreak { get; set; } = 180;
        [Description("Maximun time between zombie outbreaks")]
        public int MaxTimeBetweenOutbreak { get; set; } = 600;
    }
}
