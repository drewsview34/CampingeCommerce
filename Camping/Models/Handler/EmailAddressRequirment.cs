using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Camping.Models.Handler
{
    public class EmailAddressRequirment : AuthorizationHandler<EmailAddressRequirment>, IAuthorizationRequirement
    {
        
        
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, EmailAddressRequirment requirement)
        {
            if (!context.User.HasClaim(c => c.Type == ClaimTypes.Email))

            {
                return Task.CompletedTask;

            }

            List<string> allowedEmailDomains = new List<string> { "hotmail.com", "gmail.com", "yahoo.com" };

            var emailDomain = context.User.FindFirst(email => email.Type == ClaimTypes.Email).Value;
            foreach(var email in allowedEmailDomains)
            {
                if (emailDomain.Contains(email))

                {
                    context.Succeed(requirement);
                }

            }
                

           

                return Task.CompletedTask;
        }

    }
}

