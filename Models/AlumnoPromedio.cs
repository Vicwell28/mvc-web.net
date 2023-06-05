using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_web.Models
{

    public class AlumnoPromedio
    {
        public float promedio;
        public string alumnoid { get; set; } = String.Empty;
        public string alumnoNombre { get; set; } = String.Empty;
    }
}