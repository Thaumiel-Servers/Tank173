using CommandSystem;
using Exiled.Permissions.Extensions;
using Exiled.API.Features;
using Exiled.API.Enums;
using PlayerRoles;
using System;

namespace Tank173
{
     [CommandHandler(typeof(RemoteAdminCommandHandler))]
     internal class ForceSpawnCommand : ICommand
     {
          public string Command { get; set; } = "ForceTank";
          public string Description { get; set; } = "Forces Tank SCP173!";
          public string[] Aliases { get; set; } = new string[] { };
          public bool Execute(ArraySegment<string> args, ICommandSender sender, out string response)
          {
               if (!sender.CheckPermission(PlayerPermissions.RoundEvents))
               {
                    response = "You do not have permission to use this command!";
                    return false;
               }
               
               Tank173.Instance.IsSpawnable = true;

               response = "%Player% has been made Tank SCP173!";
               return true;
          }
     }
}
