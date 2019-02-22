using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Handler
{
    public class StateRequirement : AuthorizationHandler<StateRequirement>, IAuthorizationRequirement
    {
    }
}
