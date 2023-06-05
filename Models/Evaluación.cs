using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_web.Models
{
    public class Evaluación : ObjetoEscuelaBase
    {
        public Alumno Alumno { get; set; } = new Alumno();
        public Asignatura Asignatura { get; set; } = new Asignatura();
        public float Nota { get; set; }

        public override string ToString()
        {
            return $"{Nota}, {Alumno.Nombre}, {Asignatura.Nombre}";
        }
    }
}