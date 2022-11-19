using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
   public enum Policy
    {
        ALLOW,DENY
    }
    public class Claim
    {
        public int Id { get; set; }
        public int RoleId{ get; set; }
        public int PermissionId { get; set; }
        public Policy PolicyStatus { get; set; }

        public Claim(int id, int roleId, int permissionId, Policy policyStatus)
        {
            Id = id;
            RoleId = roleId;
            PermissionId = permissionId;
            PolicyStatus = policyStatus;
        }
        public Claim()
        {

        }

        public override string? ToString()
        {
            return $"Id:{Id} RoleId:{RoleId} PermissionId:{PermissionId} PolicyStatus:{PolicyStatus}";
        }
    }
}
