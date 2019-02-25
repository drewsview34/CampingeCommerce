using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Camping.Models.Handler
{
    public class EmailAddressHandler: AuthorizationHandler<MailAddress>,IAuthorizationRequirement
    
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, NewEmailAddressRequirment requirement)

        {

            if (!context.User.HasClaim(c => c.Type == ClaimTypes.emailAddress))

            {
                return Task.CompletedTask;
            }

      //EmailAddress emailAddress = context.User.FindFirst(u => u.Type == ClaimTypes.ValidEmailAddress).Value;

            bool ValidEmailAddress(string email)
            {
                try {  var ValidEmailaddress = new System.Net.Mail.MailAddress(email);
                    return ValidEmailaddress.Address == email;
                }
                catch
                {
                    return false;
                }
            }
            
            
        }
    }
}
