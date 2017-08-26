using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Cancion
    {
       public String Nombre;
       public  String Tiempo;
        public string Artista;
       public Cancion(string NombreCancion, string TiempoCancion, string ArtistaCancion)
        {
            Nombre = NombreCancion;
            Tiempo = TiempoCancion;
            Artista = ArtistaCancion;
        }
    }
}
