using Exiled.API.Enums;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using System.Collections.Generic;

namespace TankSCP173.Roles
{
    [CustomRole(RoleTypeId.Scp173)]
    
    public class TankSCP173 : CustomRole
    {
        public override uint Id { get; set; } = 9;
        public override RoleTypeId Role { get; set; } = RoleTypeId.Scp173;
        public override int MaxHealth { get; set; } = 4500;
        public override string Name { get; set; } = "Tank SCP-173";
        public override string Description { get; set; } = "";
        public override string CustomInfo { get; set; } = "Tank SCP-173";
        public override bool IgnoreSpawnSystem { get; set; } = true;

        public override List<string> Inventory { get; set; } = new()
        {
        };
        public override SpawnProperties SpawnProperties { get; set; } = new()
        {
            RoleSpawnPoints = new List<RoleSpawnPoint>
            {
                new()
                {
                    Role = RoleTypeId.Scp173,
                    Chance = 100
                }
            }
        };
    }
}
