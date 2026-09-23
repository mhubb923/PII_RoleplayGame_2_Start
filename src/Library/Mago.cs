namespace Ucu.Poo.RolePlayGame
{
    public class Mago : Personaje
    {
        public Mago(string nombre) : base(nombre, 100)
        {
        }

        // Único entre las especies: puede usar items mágicos.
        protected override bool PuedeUsarItemsMagicos => true;
        public void Estudiar()
        {
            //VER
        }
    }
}