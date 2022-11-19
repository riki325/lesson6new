using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories
{
    public interface IMockContext
    {
        List<Role> Roles { get; set; }
        List<Claim> Claims { get; set; }    
        List<Permission>permissions { get; set; }   
    }
}
