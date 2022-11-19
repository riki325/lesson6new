using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IClaim
    {
        Claim GetClaimById(int id);
        List<Claim> GetAllClaims();
        Claim AddClaim(int id, int RoleId, int PermissionId, Policy policyStatus);
        Claim UpdateClaim(int id, int RoleId, int PermissionId, Policy policyStatus);
        void DeleteClaim(int id);
    }
}
