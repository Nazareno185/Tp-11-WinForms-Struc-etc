
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TP11
{
    public class Personas
    {
        public String? PrimerNombre { get; set; }
        public String? SegundoNombre { get; set; }
        public String? TercerNombre { get; set; }
        public String? Apellido { get; set; }
        public int Dni { get; set; }
        public DateOnly FechaDeNacimiento { get; set; }
        public Genero Genero { get; set; }
        public bool Activo { get; set; }
        public int MyProperty { get; set; }
        public string NombreCompleto()
        {
            return $"{Apellido!.ToUpper()},{PrimerNombre}, {SegundoNombre}, {TercerNombre![0]}";
        }
    }
}
