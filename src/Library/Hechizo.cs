namespace Ucu.Poo.RolePlayGame
{
    public abstract class Hechizo
    {
        private string nombre;

        protected Hechizo(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre => this.nombre;
    }
}