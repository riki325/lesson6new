using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class ClameRopository: IClaim
    {
        IMockContext context;
        public ClameRopository(IMockContext contextt)
        {
            context = contextt;
        }

        public Claim AddClaim(int id, int RoleId, int PermissionId, Policy policyStatus)
        {
            throw new NotImplementedException();
        }

        public void DeleteClaim(int id)
        {
            throw new NotImplementedException();
        }

        public List<Claim> GetAllClaims()
        {
            throw new NotImplementedException();
        }

        public Claim GetClaimById(int id)
        {
            throw new NotImplementedException();
        }

        public Claim UpdateClaim(int id, int RoleId, int PermissionId, Policy policyStatus)
        {
            throw new NotImplementedException();
        }
    }
}
