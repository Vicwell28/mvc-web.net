using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_web.Models
{
    public class Evaluaciones
    {
        public string UniqueId { get; private set; } = String.Empty;
        public string Nombre { get; set; } = String.Empty;
        public Alumno Alumno { get; set; } = new Alumno();
        public Asignatura Asignatura { get; set; } = new Asignatura();
        public float Nota { get; set; }
        public Evaluaciones() => this.UniqueId = Guid.NewGuid().ToString();
    }
}