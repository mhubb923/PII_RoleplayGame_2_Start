namespace Ucu.Poo.RolePlayGame
{
    public class HechizoDefensa : Hechizo, IDefendible
    {
        private int valorDefensa;

        public HechizoDefensa(string nombre, int valorDefensa) 
            : base(nombre)
        {
            this.valorDefensa = valorDefensa;
        }

        public int ObtenerDefensa()
        {
            return this.valorDefensa;
        }
    }
}