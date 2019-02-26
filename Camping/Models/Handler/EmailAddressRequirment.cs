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
        private string _userEmail;

        public EmailAddressRequirment(string userEmail)
        {
            _userEmail = userEmail;

           
        }
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, EmailAddressRequirment requirement)
        {
            if (!context.User.HasClaim(c => c.Type == ClaimTypes.Email))

            {
                return Task.CompletedTask;

            }

            List<string> _allowedEmailDomains = new List<string> { "outlook.com", "hotmail.com", "gmail.com", "yahoo.com" };
            //IdentityResult result = await base.ValidateAsync(user);
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

