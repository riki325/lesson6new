using MyProject.Mock;
using MyProject.Repositories;
using MyProject.Repositories.Repositories;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MockContext context = new MockContext();
            RoleRepository roleRepository = new RoleRepository(context);
            roleRepository.AddRole(3, "customer", "view orders and edit orders");
            Console.WriteLine("====================GetRoles============================");
            foreach (var item in roleRepository.GetAllRoles())
            {
                Console.WriteLine(item);
            }
            ClameRopository clameRopository = new ClameRopository(context);
            clameRopository.DeleteClaim(1);
            foreach (var item in clameRopository.GetAllClaims())
            {
                Console.WriteLine(item);
            }
        }
    }
}