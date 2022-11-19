using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IPermission
    {
        Permission GetPermissionById(int id);
        List<Permission> GetAllPermissions();
        Permission AddPermission(int id, string name, string description);
        Permission UpdatePermission(int id, string name, string description);
        void DeletePermission(int id);
    }
}
