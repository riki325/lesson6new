using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Description { get; set; }

        public Role(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
        public Role()
        {

        }

        public override string? ToString()
        {
            return $"Id:{Id} Name:{Name} Description:{Description} ";
        }

    }
}
