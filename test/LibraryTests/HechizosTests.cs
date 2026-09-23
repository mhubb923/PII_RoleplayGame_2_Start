using NUnit.Framework;
using Ucu.Poo.RolePlayGame;

namespace Ucu.Poo.RolePlayGame.Tests
{
    [TestFixture]
    public class HechizoTests
    {
        [Test]
        public void ObtenerAtaque_HechizoAtaque_DevuelveValorCorrecto()
        {
            HechizoAtaque hechizo = new HechizoAtaque("Fuego", 15);

            Assert.That(hechizo.ObtenerAtaque(), Is.EqualTo(15));
        }

        [Test]
        public void ObtenerDefensa_HechizoDefensa_DevuelveValorCorrecto()
        {
            HechizoDefensa hechizo = new HechizoDefensa("Escudo", 5);

            Assert.That(hechizo.ObtenerDefensa(), Is.EqualTo(5));
        }
    }
}