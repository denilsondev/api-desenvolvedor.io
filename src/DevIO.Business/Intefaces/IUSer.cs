using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace DevIO.Business.Intefaces
{
    public interface IUSer
    {
        string Name { get; }
        Guid GetUserId();
        string GetUserEmail();
        bool IsAuthenticated();
        bool IsInRole(string role);
        IEnumerable<Claim> GetClaimsIdentity();
    }
}
