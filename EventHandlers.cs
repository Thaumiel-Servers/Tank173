using Exiled.API.Features;
using Exiled.Events.EventArgs.Map;
using Exiled.Events.EventArgs.Server;
using Exiled.Loader;
using MEC;
using PlayerRoles;
using Respawning;
using System;
using System.Collections.Generic;

namespace Tank173
{
     internal sealed class EventHandlers
     {
          public EventHandlers(float spawnChance)
          {
               SpawnChance = spawnChance;
          }

          public void OnRoundStarted() => Tank173.Instance.IsSpawnable = true;
          public float SpawnChance { get; set; } = 100;
     }
}
