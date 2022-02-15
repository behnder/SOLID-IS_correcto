using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IS_correcto
{
    class Jugador : IPersonaje
    {
        public string Nombre { get ; set ; }

        public Jugador(string nombre)
        {
            Nombre = nombre;
        }

        public void Atacar(string JugadorParaAtacar)
        {
            Console.WriteLine("Atacando a " + JugadorParaAtacar);
        }

        public void Bloquear()
        {
            Console.WriteLine("Bloqueando!");
        }

        public void CalcularDanio()
        {
            Console.WriteLine("Calculando daño de ataque...");
        }

        public void Saltar()
        {
            Console.WriteLine("Saltando");
        }
    }
}
