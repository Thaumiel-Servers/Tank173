using System.ComponentModel;
using Exiled.API.Interfaces;
using TankSCP173.Roles;

namespace Tank173
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Should debug messages be shown in a server console.")]
        public bool Debug { get; set; } = false;

        [Description("Enable Hume Blast?. Default true")]
        public bool Humeblastenable { get; set; } = true;

        [Description("Options for Tank SCP-173:")]
        public TankSCP173.Roles.TankSCP173 TankScp173 { get; private set; } = new TankSCP173.Roles.TankSCP173();

        [Description("Spawnchance")]
        public float SpawnChance { get; set; } = 100;
    }
}