using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IS_correcto
{
    class ConexionBD : Iconexion
    {
        Jugador Jugador;

        public ConexionBD(Jugador jugador)
        {
            Jugador = jugador;
        }

        public void ConectarBD()
        {
            Console.WriteLine("conectando a la base de jugadores... ");
        }

        public void GuardarEnBD()
        {
            Console.WriteLine("Guardando jugador " + Jugador.Nombre+" en Baase de Datos ");
        }
    }
}
