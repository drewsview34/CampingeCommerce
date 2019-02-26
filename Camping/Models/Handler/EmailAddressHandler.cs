﻿using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Camping.Models.Handler
{
    public class EmailAddressHandler : AuthorizationHandler<NewEmailAddressRequirment>
    {
        List<string> _allowedEmailDomains = new List<string> { "outlook.com", "hotmail.com", "gmail.com", "yahoo.com" };

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, NewEmailAddressRequirment requirement)
        {
            IdentityResult result = await base.ValidateAsync(user);

            var emailDomain = user.Email.Split('@')[1];

            if (!_allowedEmailDomains.Contains(emailDomain.ToLower()))

            {

                var errors = result.Errors.ToList();

                errors.Add(String.Format("Email domain '{0}' is not allowed", emailDomain));

                result = new IdentityResult(errors);

            }



            return result;

        }

    }

}
    

