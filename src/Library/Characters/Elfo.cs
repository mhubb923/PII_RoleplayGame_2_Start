using System;

namespace Ucu.Poo.RolePlayGame
{
    public class Elfo : Personaje
    {
        public Elfo(string nombre) : base(nombre, 100)
        {
        }

        public void CurarA(Personaje objetivo)
        {
            if (objetivo is null)
                throw new ArgumentNullException(nameof(objetivo));

            objetivo.Curar();
        }
    }
}