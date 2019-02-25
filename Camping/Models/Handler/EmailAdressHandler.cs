using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Camping.Models.Handler
{
    public class MinAgeHandler: AuthorizationHandler<MinAge>,IAuthorizationRequirement
    
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, EmailAddress requirement)

        {

            if (!context.User.HasClaim(c => c.Type == ClaimTypes.EmailAddress))

            {
                return Task.CompletedTask;
            }

      EmailAddress emailAddress = context.User.FindFirst(u => u.Type == ClaimTypes.EmailAddress);

            bool EmailAddress(string email)
            {
                try {  var address = new System.Net.Mail.MailAddress(email);
                    return address.Address == email;
                }
                catch
                {
                    return false;
                }
            }

            
        }
    }
}
