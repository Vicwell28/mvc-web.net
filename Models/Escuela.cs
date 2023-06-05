using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_web.Models
{
    public class Escuela
    {
        public string EscuelaId { get; set; } = String.Empty;
        public string Nombre { get; set; } = String.Empty;
        public int Fundacion { get; set; }

    }
}