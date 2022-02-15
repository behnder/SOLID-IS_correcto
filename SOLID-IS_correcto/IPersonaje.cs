using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IS_correcto
{
    interface IPersonaje
    {

        string Nombre { get; set; }

        void CalcularDanio();
        void Atacar(string JugadorParaAtacar);
        void Saltar();
        void Bloquear();

    }
}
