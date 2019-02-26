using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Camping.Models.Handler
{
    public class EmailAddressHandler : AuthorizationHandler<EmailAddressRequirment>
    {       

        protected override  Task HandleRequirementAsync(AuthorizationHandlerContext context, EmailAddressRequirment requirement)
        {
            if (!context.User.HasClaim(c => c.Type == ClaimTypes.Email))

            {
                return Task.CompletedTask;
            }

            List<string> _allowedEmailDomains = new List<string> { "outlook.com", "hotmail.com", "gmail.com", "yahoo.com" };
           
            var emailDomain = _userEmail.Split('@')[1];

            if (_allowedEmailDomains.Contains(_userEmail.ToLower()))

            {
                context.Succeed(requirement);

            }
            if (!_allowedEmailDomains.Contains(_userEmail.ToLower()))

            {

                _allowedEmailDomains.Add(String.Format("Email domain '{0}' is not allowed", emailDomain));

            }


            return Task.CompletedTask;

        }

    }
}


    

