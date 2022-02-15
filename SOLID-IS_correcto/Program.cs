using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IS_correcto
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador("player1");
            ConexionBD conexion = new ConexionBD(jugador);
            RenderizarPersonajeCreado render = new RenderizarPersonajeCreado(jugador);
            Console.WriteLine("============");
            conexion.ConectarBD();
            conexion.GuardarEnBD();
            Console.WriteLine("============");
            render.CargarModelo3d();
            render.RenderizarEnPantalla();
            Console.ReadLine();
            Console.WriteLine("============");
            jugador.Atacar("enemigo");
            jugador.Bloquear();
            jugador.CalcularDanio();
            jugador.Saltar();

        }
    }
}
