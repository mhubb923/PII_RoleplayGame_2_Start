using System;

namespace Ucu.Poo.RolePlayGame
{
    // Un Arma solo ataca: implementa únicamente IAtacable, no IDefendible.
    public class Arma : Item, IAtacable
    {
        private readonly int valorAtaque;

        public Arma(int valorAtaque)
        {
            if (valorAtaque < 0)
                throw new ArgumentException("El valor de ataque no puede ser negativo.", nameof(valorAtaque));

            this.valorAtaque = valorAtaque;
        }

        public int ObtenerAtaque()
        {
            return this.valorAtaque;
        }
    }
}