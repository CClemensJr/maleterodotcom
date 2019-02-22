using Maletero.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Maletero.Models.Handler
{
    public class StateRequirement : AuthorizationHandler<StateRequirement>, IAuthorizationRequirement
    {
        private string _preferredState;

        //allows you to select a preferred state to apply similiar to minimum age req
        public StateRequirement(string preferredState)
        {
            _preferredState = preferredState;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, StateRequirement requirement)
        {
            //req is based on state claim
            //if the user does not have a state attached, complete the task
            if(!context.User.HasClaim(c => c.Type == ClaimTypes.StateOrProvince.ToString()))
            {
                return Task.CompletedTask;
            }

            var state = context.User.FindFirst(u => u.Type == ClaimTypes.StateOrProvince);
            string selectedState = "WA";

            if(state.Value == selectedState)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
