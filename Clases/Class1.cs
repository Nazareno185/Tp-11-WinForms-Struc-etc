using Entidades_TP11;
using System.IO.Pipes;
namespace Clases
{
    public class Repositorio
    {
        private List<Personas>? socios; 
        public Repositorio()
        {
            //instanciar la lista para poder trabajar
            socios = new List<Personas>();
        }
        public void Agregar(Personas personas) 
        {
            socios!.Add(personas);
        }
        public List<Personas> GetSocios() => socios;
    }
}
