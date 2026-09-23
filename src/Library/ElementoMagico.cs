namespace Ucu.Poo.RolePlayGame
{
   public class ElementoMagico : Item, IAtacable, IDefendible, IItemMagico{
        private int valorAtaque;
        private int valorDefensa;

        public ElementoMagico(string nombre, int valorAtaque, int valorDefensa) 
            : base(nombre)
        {
            this.valorAtaque = valorAtaque;
            this.valorDefensa = valorDefensa;
        }

        public int ObtenerAtaque()
        {
            return this.valorAtaque;
        }

        public int ObtenerDefensa()
        {
            return this.valorDefensa;
        } 
   }
}