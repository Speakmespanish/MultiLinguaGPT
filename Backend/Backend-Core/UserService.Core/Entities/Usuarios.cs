using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Core.Enums;

namespace UserService.Core.Entities
{
    public class Usuarios
    {
        public int ID { get; set; }

        public string Name { get; set; } = string.Empty!;

        public string Mail { get; set; } = string.Empty!;

        public string Password { get; set; } = string.Empty!;

        public string? LanguajePreference { get; set; }

        public TiposUsuarios UserType { get; set; } 
    }
}
