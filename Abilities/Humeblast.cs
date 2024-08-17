using System;
using System.Collections.Generic;
using System.Linq;
using Exiled.API.Features;
using Exiled.CustomRoles.API;
using Exiled.CustomRoles.API.Features;
using System.Text;
using System.ComponentModel;
using Exiled.API.Enums;
using Exiled.API.Features.Attributes;
using InventorySystem.Items.Firearms.Modules;
using MEC;
using Exiled.Events.Handlers;
using UnityEngine;
using Exiled.API.Features.Items;
using Exiled.Events.EventArgs.Player;

namespace Tank173.Abilities
{
    public class Humeblast : ActiveAbility
    {
        public override string Description { get; set; } = "Blast off a part of your hume shield";
        public override string Name { get; set; } = "Hume Blast";
        public override float Duration { get; set; } = 0f;
        public override float Cooldown { get; set; } = 240f;

        [Description("How long the ensnare effect lasts.")]
        public float EnsnareDuration { get; set; } = 5f;

        [Description("How long the burned effect lasts.")]
        public float burnedDuration { get; set; } = 10f;
        public float GrenadeFuseTime { get; set; } = 0.1f;
        protected override void AbilityUsed(Exiled.API.Features.Player player)
        {



            void AbilityUsed(DyingEventArgs ev)
            {
                if (Check(ev.Player))
                {
                    ExplosiveGrenade grenade = (ExplosiveGrenade)Exiled.API.Features.Items.Item.Create(ItemType.GrenadeHE);
                    grenade.FuseTime = GrenadeFuseTime;
                    grenade.SpawnActive(ev.Player.Position, ev.Player);
                }
            }        
                    player.ShowHint("Hume Blast Activated", 5f);
                    Log.Debug("Hume Blast Activated.");
                    Vector3 target = Vector3.zero;
                    if (RunRaycast(player, out RaycastHit hit))
                    {
                        Log.Debug("Hume Blast hits");
                        if ((player.Position - hit.point).sqrMagnitude > 400)
                        {
                            Log.Debug("Hume Blast over max distance");
                            target = Vector3.MoveTowards(player.Position, hit.point, 20f);

                            if (Physics.Linecast(target, Vector3.down * 20f, out RaycastHit lineHit))
                            {
                                Log.Debug("Max distance linecast");
                                target = lineHit.point;
                            }
                        }
                        else
                        {
                            target = hit.point;
                        };
                    }
                    








                    bool RunRaycast(Exiled.API.Features.Player player, out RaycastHit hit)
                    {
                        Vector3 forward = player.CameraTransform.forward;
                        return Physics.Raycast(player.Position + forward, forward, out hit, 200f, StandardHitregBase.HitregMask);
                    }


                
        
        }
    }
}
                
    
