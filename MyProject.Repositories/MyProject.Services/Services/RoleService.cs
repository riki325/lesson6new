using MyProject.Common.DTOs;
using MyProject.Repositories.Repositories;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class RoleService : IRoleService
    {
        public RoleService()
        {

        }
        public RoleDto AddRole(int id, string name, string description)
        {
            RoleRepository rolerepository = new RoleRepository();
            rolerepository.AddRole(id, name, description);
            return  new RoleDto( );
        }

        public void DeleteRole(int id)
        {
            throw new NotImplementedException();
        }

        public RoleDto GetRole(int id)
        {
            throw new NotImplementedException();
        }

        public List<RoleDto> GetRoles()
        {
            throw new NotImplementedException();
        }

        public RoleDto UpdateRole(int id, string name, string description)
        {
            throw new NotImplementedException();
        }
    }
}
