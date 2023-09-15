using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateExample
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Patronymic { get; set; } = null!;
        public string Email { get; set; } = null!;

        public override string ToString()
        {
            return $"{Id}. {Surname} {Name} {Patronymic} - {Email}";
        }
    }
}
