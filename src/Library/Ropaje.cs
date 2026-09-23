using System;

namespace Ucu.Poo.RolePlayGame
{
    //Un Ropaje solo defiende - implementa solo IDefendible.
    public class Ropaje : Item, IDefendible
    {
        private readonly int valorDefensa;

        public Ropaje(int valorDefensa)
        {
            if (valorDefensa < 0)
                throw new ArgumentException("El valor de defensa no puede ser negativo.", nameof(valorDefensa));

            this.valorDefensa = valorDefensa;
        }

        public int ObtenerDefensa()
        {
            return this.valorDefensa;
        }
    }
}