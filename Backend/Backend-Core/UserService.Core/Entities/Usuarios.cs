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
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty!;

        public string Email { get; set; } = string.Empty!;

        public string Password { get; set; } = string.Empty!;

        public string? LanguagePreference { get; set; }

        public TiposUsuarios UserType { get; set; } 
    }
}
