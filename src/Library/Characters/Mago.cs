namespace Ucu.Poo.RolePlayGame
{
    public class Mago : Personaje
    {
        public Mago(string nombre) : base(nombre, 100)
        {
        }

        // Da la capacidad de equipar ítems mágicos (como LibroDeHechizos)
        protected override bool PuedeUsarItemsMagicos => true;

        public void Estudiar()
        {
            this.AumentarAtaqueBase(5);
        }
    }
}