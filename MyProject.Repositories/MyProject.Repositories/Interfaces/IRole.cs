using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IRole

    {
        Role GetRoleById(int id);   
        List<Role> GetAllRoles();
        Role AddRole(int id, string name, string description);
        Role UpdateRole(int id, string name, string description); 
        void DeleteRole(int id);    


    }
}
