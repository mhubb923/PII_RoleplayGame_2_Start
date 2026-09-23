using System;
using System.Collections.Generic;
using System.Linq;

namespace Ucu.Poo.RolePlayGame
{
    public abstract class Personaje
    {
        private string nombre;
        private int vida;
        private readonly int vidaMaxima;
        private int ataqueBase;
        private int defensaBase;
        private readonly List<Item> items = new List<Item>();
        protected Personaje(string nombre, int vida)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.", nameof(nombre));
            if (vida <= 0)
                throw new ArgumentException("La vida debe ser positiva.", nameof(vida));

            this.nombre = nombre;
            this.vida = vida;
            this.vidaMaxima = vida;
            this.ataqueBase = 0;
            this.defensaBase = 0;
        }
        protected virtual bool PuedeUsarItemsMagicos => false;
        public void AgregarItem(Item item)
        {
            if (item is null)
                throw new ArgumentNullException(nameof(item));

            if (item is ItemMagico && !this.PuedeUsarItemsMagicos)  //VEr aca que usa ItemMagico.
            {
                throw new InvalidOperationException(
                    $"{this.nombre} no puede usar items mágicos.");
            }

            this.items.Add(item);
        }

        public void QuitarItem(Item item)
        {
            this.items.Remove(item);
        }

        /* Suma el ataque base más el de cada item que sepa atacar.
        OfType<IAtacable>() filtra la lista, quedándose solo con los items que implementan esa interfaz 
        */
        public int ObtenerAtaqueTotal()
        {
            return this.ataqueBase + this.items.OfType<IAtacable>().Sum(i => i.ObtenerAtaque());
        }

        public int ObtenerDefensaTotal()
        {
            return this.defensaBase + this.items.OfType<IDefendible>().Sum(i => i.ObtenerDefensa());
        }

        public void RecibirAtaque(int poder)
        {
            if (poder < 0)
                throw new ArgumentException("El poder de ataque no puede ser negativo.", nameof(poder));

            int danio = Math.Max(poder - this.ObtenerDefensaTotal(), 0);
            this.vida = Math.Max(this.vida - danio, 0);
        }

        public void Curar()
        {
            this.vida = this.vidaMaxima;
        }

        public void RealizarAtaque(Personaje objetivo)
        {
            if (objetivo is null)
                throw new ArgumentNullException(nameof(objetivo));

            objetivo.RecibirAtaque(this.ObtenerAtaqueTotal());
        }

        public int ObtenerVida()
        {
            return this.vida;
        }

        protected void AumentarAtaqueBase(int cantidad)
        {
            if (cantidad < 0)
                throw new ArgumentException("La cantidad no puede ser negativa.", nameof(cantidad));

            this.ataqueBase += cantidad;
        }

        protected void AumentarDefensaBase(int cantidad)
        {
            if (cantidad < 0)
                throw new ArgumentException("La cantidad no puede ser negativa.", nameof(cantidad));

            this.defensaBase += cantidad;
        }
    }
}