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

          public void OnRoundStarted() => Plugin.Instance.IsSpawnable = true;
     

     }
}
