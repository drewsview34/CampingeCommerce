using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Camping.Models.Handler
{
    public class MinimumAge : AuthorizationHandler<MinAgeRequirement>, IAuthorizationRequirment
    {
        private int _minimumAge;
        public MinimumAge(int minimumAge)
        {
            _minimumAge = minimumAge;
        }
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinAgeRequirement requirement)
        {
           if(!context.User.HasClaim(c => c.Type == ClaimTypes.DateOfBirth))
            {
                return Task.CompletedTask;
            }
            DateTime dateOfBirth = Convert.ToDateTime(context.User.FindFirst(u => u.Type == ClaimTypes.DateOfBirth).Value);
            int age = DateTime.Today.Year - dateOfBirth.Year;
            if(dateOfBirth > DateTime.Today.AddYears(-age))
            {
                age--;
            }
            if(age >= _minimumAge)
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
