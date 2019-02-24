using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Camping.Models.Handler
{
    public interface IMinAgeHandler
    {
        bool Equals(object obj);
        int GetHashCode();
        Task HandleAsync(AuthorizationHandlerContext context);
        string ToString();
    }
}