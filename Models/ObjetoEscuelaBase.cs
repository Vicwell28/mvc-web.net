using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_web.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public string UniqueId { get; set; } = String.Empty;
        public string Nombre { get; set; } = String.Empty;

        public override string ToString()
        {
            return $"{Nombre},{UniqueId}";
        }
    }
}