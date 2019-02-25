using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Camping.Models.Handler
{
    public class EmailAddressRequirment : AuthorizationHandler<EmailAddressRequirment>, IAuthorizationRequirement
    {
        private string _Email;
        public EmailAddressRequirment(string Email)
        {
            _Email = Email;
        }
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, EmailAddressRequirment requirement)
        {
            if(!context.User.HasClaim(c => c.Type == ClaimTypes.Email))
            {
                return Task.CompletedTask;
            }
            ValidEmail Email = Equals(context.User.FindFirst(e => e.Type == ClaimTypes.Email));
            string email =
        }
    }
}
