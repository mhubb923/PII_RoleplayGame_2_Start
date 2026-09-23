using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    public class LibroDeHechizos : Item, IAtacable, IDefendible, IItemMagico
    {
        private List<Hechizo> hechizos;

        public LibroDeHechizos(string nombre) : base(nombre)
        {
            this.hechizos = new List<Hechizo>();
        }

        public void AgregarHechizo(Hechizo h)
        {
            if (h == null)
            {
                throw new ArgumentNullException(nameof(h));
            }
            this.hechizos.Add(h);
        }

        public void QuitarHechizo(Hechizo h)
        {
            this.hechizos.Remove(h);
        }

        public int ObtenerAtaque()
        {
            int ataqueTotal = 0;
            foreach (Hechizo h in this.hechizos)
            {
                if (h is IAtacable hechizoAtacable)
                {
                    ataqueTotal += hechizoAtacable.ObtenerAtaque();
                }
            }
            return ataqueTotal;
        }

        public int ObtenerDefensa()
        {
            int defensaTotal = 0;
            foreach (Hechizo h in this.hechizos)
            {
                if (h is IDefendible hechizoDefendible)
                {
                    defensaTotal += hechizoDefendible.ObtenerDefensa();
                }
            }
            return defensaTotal;
        }
    }
}