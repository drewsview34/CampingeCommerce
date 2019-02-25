using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camping.Models.Handler
{
    public class EmailAddressHandler : AuthorizationHandler<NewEmailRequirment>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, NewEmailRequirment requirement)
        {
            throw new NotImplementedException();
        }
    }
}
