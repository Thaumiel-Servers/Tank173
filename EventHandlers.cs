using Exiled.API.Features;
using Exiled.API.Features.Roles;
using Exiled.Events.EventArgs.Map;
using Exiled.Events.EventArgs.Server;
using Exiled.Loader;
using MEC;
using PlayerRoles;
using Respawning;
using System;
using System.Collections.Generic;
using Exiled.API.Features.Hazards;
using RelativePositioning;
using UnityEngine;

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

     internal class Program
     {
          public static void Main(string[] args)
          {
               TantrumHazard PlaceTantrum(bool failIfObserved = false, float cooldown = 45)
               {
                    if() public Vector3 Position { get; set; } = public RelativePosition SynchronisedPosition { get; set; }


          
               }
          }
     }
}
