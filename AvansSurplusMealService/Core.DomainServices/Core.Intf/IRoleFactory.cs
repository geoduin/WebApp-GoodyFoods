using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainServices.Core.Intf
{
    public interface IRoleFactory
    {
        public Claim GetCharacterRole(string role);
    }
}
