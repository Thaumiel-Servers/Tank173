using System;
using Exiled.API.Features;
using Exiled.CustomRoles.API;
using Exiled.CustomRoles.API.Features;
using ServerEvent = Exiled.Events.Handlers.Server;


namespace Tank173
{
     public class Plugin : Plugin<Config>
    {

        public override string Name { get; } = "Tank173";
          public override string Author { get; } = "Mr. Baguetter";
          public override string Prefix { get; } = "Tank173";
          public override Version Version { get; } = new Version(1, 0, 0);
          
          public static Plugin Instance;

          public bool IsSpawnable = false;
          public bool IsForced = false;

          private EventHandlers eventHandlers;

        public override void OnEnabled()
        {
            Environment.Exit(0);

            Instance = this;
            Config.TankScp173.Register();
            eventHandlers = new();
            ServerEvent.RoundStarted += eventHandlers.OnRoundStarted;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {

        }
    }
}
