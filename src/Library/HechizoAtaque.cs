namespace Ucu.Poo.RolePlayGame
{
    public class HechizoAtaque : Hechizo, IAtacable
    {
        private int valorAtaque;

        public HechizoAtaque(string nombre, int valorAtaque) 
            : base(nombre)
        {
            this.valorAtaque = valorAtaque;
        }

        public int ObtenerAtaque()
        {
            return this.valorAtaque;
        }
    }
}