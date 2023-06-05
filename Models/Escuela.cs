using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_web.Models
{
    public class Escuela : ObjetoEscuelaBase
    {
        public int Fundacion { get; set; }
        public string Pais { get; set; } = string.Empty;
        public string Ciudad { get; set; } = string.Empty;
        public string Dirección { get; set; } = string.Empty;
        public TiposEscuela TipoEscuela { get; set; } = new TiposEscuela();
        public List<Curso> Cursos { get; set; } = new List<Curso>();
        public Escuela(string nombre, int año) => (Nombre, Fundacion) = (nombre, año);
        public Escuela
        (
                string nombre,
                int año,
                TiposEscuela tipo,
                string pais = "",
                string ciudad = ""
        ) : base()
        {
            (Nombre, Fundacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }
        public Escuela() { }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad:{Ciudad}";
        }
    }
}
