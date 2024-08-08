using System;
using Exiled.API.Features;
using Exiled.CustomRoles.API;
using Exiled.CustomRoles.API.Features;
using MapEvent = Exiled.Events.Handlers.Map;
using ServerEvent = Exiled.Events.Handlers.Server;

namespace Tank173
{
     public class Tank173 : Plugin<Configs.Config>
     {

          public override string Name { get; } = "Tank173";
          public override string Author { get; } = "Mr. Baguetter";
          public override string Prefix { get; } = "Tank173";
          public override Version Version { get; } = new Version(1, 0, 0);
          public override Version RequiredExiledVersion => new Version(8, 11, 0);
          
          public static Tank173 Instance;

          public bool IsSpawnable = false;

          private EventHandlers eventHandlers;

          public override void OnEnabled()
          {
               Instance = this;
               Config.TankScp173.Register();
               

               ServerEvent.RoundStarted += eventHandlers.OnRoundStarted;

               base.OnEnabled();
          }

          public override void OnDisabled()
          {
               CustomRole.UnregisterRoles();

               ServerEvent.RoundStarted -= eventHandlers.OnRoundStarted;

               eventHandlers = null;
               Instance = null!;
               base.OnDisabled();
          }
     }
}
