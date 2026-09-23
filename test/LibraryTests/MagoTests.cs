using NUnit.Framework;
using Ucu.Poo.RolePlayGame;

namespace Ucu.Poo.RolePlayGame.Tests
{
    [TestFixture]
    public class MagoTests
    {
        // Prueba que  Mago, este se construya con 100 de vida inicial.
        [Test]
        public void Constructor_Mago_InicializaVidaEn100()
        {
            Mago mago = new Mago("Gandalf");

            Assert.That(mago.ObtenerVida(), Is.EqualTo(100));
        }

        // Prueba que estudiar, el Mago aumente su ataque y defensa base.
        [Test]
        public void Estudiar_ConLibroEquipado_AumentaEstadisticasBase()
        {
            Mago mago = new Mago("Gandalf");
            int ataquePrevio = mago.ObtenerAtaqueTotal();
            mago.Estudiar();
            ataquePrevio += 5;
            Assert.That(mago.ObtenerAtaqueTotal(), Is.EqualTo(ataquePrevio));
        }
    }
}