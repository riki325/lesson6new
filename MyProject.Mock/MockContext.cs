using MyProject.Repositories;
using MyProject.Repositories.Entities;

namespace MyProject.Mock
{
    public class MockContext : IMockContext
    {
        public MockContext()
        {
            Roles = new List<Role>() {
                new Role (1, "manager","the highest level of all the hierarchy"),
                new Role (2,"secretary","allowed view all documents")
            };
            permissions = new List<Permission>() {
                new Permission (1, "Look at the marks","Look at the marks "),
                new Permission (2,"Entering marks","Entering marks")
            };
            Claims = new List<Claim>() {
                new Claim(1, 1, 1, Policy.ALLOW),
                new Claim(2, 2, 2, Policy.ALLOW),
                   new Claim(3, 2, 1, Policy.DENY)
            };

        }
        public List<Role> Roles { get; set; }
        public List<Claim> Claims { get  ; set ; }
        public List<Permission> permissions { get ; set ; }
    }
}