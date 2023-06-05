using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_web.Models
{
    public class Curso : ObjetoEscuelaBase
    {
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; } = new List<Asignatura>();
        public List<Alumno> Alumnos { get; set; } = new List<Alumno>();
        public string Dirección { get; set; } = String.Empty;

    }
}