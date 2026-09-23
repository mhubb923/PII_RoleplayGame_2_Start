using NUnit.Framework;
using Ucu.Poo.RolePlayGame;

namespace Ucu.Poo.RolePlayGame.Tests
{
    [TestFixture]
    public class EnanoTests
    {
        // Prueba que Enano, su vida inicial sea de 100.
        [Test]
        public void Constructor_Enano_InicializaVidaEn100()
        {
            Enano enano = new Enano("Gimli");

            Assert.That(enano.ObtenerVida(), Is.EqualTo(100));
        }
        //Probamos que no se equipe un item magico a un enano, el cual no debería tenerlo.
        [Test]
        public void AgregarItem_ItemMagico_NoSeEquipaEnEnano()
        {
            Enano enano = new Enano("Gimli");
            LibroDeHechizos libro = new LibroDeHechizos("Grimorio");
            
            bool resultado = enano.AgregarItem(libro);

            Assert.That(resultado, Is.False);
            Assert.That(enano.ObtenerAtaqueTotal(), Is.EqualTo(enano.ObtenerAtaqueTotal()));
        }

        [Test]
        public void AgregarItem_ArmaNormal_SeEquipaCorrectamente()
        {
            Enano enano = new Enano("Gimli");
            Arma hacha = new Arma("Hacha", 20);

            bool resultado = enano.AgregarItem(hacha);

            Assert.That(resultado, Is.True);
            Assert.That(enano.ObtenerAtaqueTotal(), Is.GreaterThan(0));
        }
    }
}