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
        

        [Test]
        public void AgregarItem_ArmaNormal_SeEquipaCorrectamente()
        {
            Enano enano = new Enano("Gimli");
            Arma hacha = new Arma("Hacha", 20);


            Assert.That(enano.ObtenerAtaqueTotal(), Is.GreaterThan(0));
        }
    }
}