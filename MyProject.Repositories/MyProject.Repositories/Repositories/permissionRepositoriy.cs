using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class permissionRepositoriy:IPermission
    {
        IMockContext context;
        public permissionRepositoriy(IMockContext contextt)
        {
            context = contextt;
        }

        public Permission AddPermission(int id, string name, string description)
        {
            throw new NotImplementedException();
        }

        public void DeletePermission(int id)
        {
            throw new NotImplementedException();
        }

        public List<Permission> GetAllPermissions()
        {
            throw new NotImplementedException();
        }

        public Permission GetPermissionById(int id)
        {
            throw new NotImplementedException();
        }

        public Permission UpdatePermission(int id, string name, string description)
        {
            throw new NotImplementedException();
        }
    }
}
