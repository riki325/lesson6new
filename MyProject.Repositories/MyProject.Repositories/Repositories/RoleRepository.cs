using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    
    public class RoleRepository : IRole
    {
        IMockContext context;

        public RoleRepository()
        {
        }

        public RoleRepository(IMockContext contextt)
        {
             context = contextt;
        }
        public Role AddRole(int id, string name, string description)
        {
            Role r = new Role(id,name,description);
            context.Roles.Add(r);
                return r;
        }

        public void DeleteRole(int id)
        {
            Role r = context.Roles.Single(r => r.Id == id);
            context.Roles.Remove(r);    

        }

        public List<Role> GetAllRoles()
        {
           return context.Roles;    
        }

        public Role GetRoleById(int id)
        {
            Role r = context.Roles.Single(r => r.Id == id);
            return r;
        }

        public Role UpdateRole(int id, string name, string description)
        {
            Role updr = context.Roles.Single(r => r.Id == id);
            updr.Name = name;   
            updr.Description = description; 
            return updr;
           
        }
    }
}
