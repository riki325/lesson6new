using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IRoleService
    {
        List<RoleDto> GetRoles();
        RoleDto GetRole(int id);
        RoleDto AddRole(int id, string name, string description);
        RoleDto UpdateRole(int id, string name, string description);
        void DeleteRole(int id);
    }
}
