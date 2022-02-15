using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IS_correcto
{
    class RenderizarPersonajeCreado : IRenderizar
    {

        Jugador jugador;

        public RenderizarPersonajeCreado(Jugador jugador)
        {
            this.jugador = jugador;
        }
        public void CargarModelo3d()
        {
            Console.WriteLine("Cargando modelo del personaje");
        }

        public void RenderizarEnPantalla()
        {
            Console.WriteLine("Dibujando el modelo en pantalla");
        }
    }
}
