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
    }
}