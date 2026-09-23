using System;

namespace Ucu.Poo.RolePlayGame
{
    public abstract class Item
    {
        private string nombre;

        protected Item(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del ítem no puede estar vacío.", nameof(nombre));

            this.nombre = nombre;
        }

        public string Nombre => this.nombre;
    }
}