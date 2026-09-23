using System;

namespace Ucu.Poo.RolePlayGame
{
    public class Ropaje : Item, IDefendible
    {
        private readonly int valorDefensa;

        public Ropaje(string nombre, int valorDefensa) : base(nombre)
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