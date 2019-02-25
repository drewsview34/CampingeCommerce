using Camping.Models.Handler;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlogPostCMS.Models.Handler
{
    public class EmailAddressRequirement : AuthorizationHandler<EmailAddressRequirement>, IAuthorizationRequirement
    {
        private string _emailAddress;
       

        public EmailAddressRequirement(string emailAddress)
        {
            _emailAddress = emailAddress;
        }

      

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, EmailAddressRequirement requirement)
        {
            if (!context.User.HasClaim(A => A.Type == ClaimTypes.EmailAddress))
            {
                return Task.CompletedTask;
            }

          //  Email emailAddress = context.User.FindFirst(u => u.Type == ClaimTypes.EmailAddress);

            bool Email(string emailaddress)
            {
                try
                {
                    var address = new System.Net.Mail.MailAddress(emailaddress);
                    return address.Address == emailaddress;
                }
                catch
                {
                    return false;
                }
            }


        }          

        }

        
    }

