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

        [Description("Options for Tank SCP-173:")]
        public TankSCP173.Roles.TankSCP173 TankScp173 { get; private set; } = new TankSCP173.Roles.TankSCP173();

    }
}