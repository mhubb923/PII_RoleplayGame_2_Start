using NUnit.Framework;
using Ucu.Poo.RolePlayGame;

namespace Ucu.Poo.RolePlayGame.Tests
{
    [TestFixture]
    public class ElfoTests
    {
        // Prueba que Elfo, su vida inicial sea de 100.
        [Test]
        public void Constructor_Elfo_InicializaVidaEn100()
        {
            Elfo elfo = new Elfo("Legolas");

            Assert.That(elfo.ObtenerVida(), Is.EqualTo(100));
        }

        // Prueba que al invocar CurarA sobre un personaje dañado, este recupere su vida total.
        [Test]
        public void CurarA_PersonajeConDano_RestauraVidaAlMaximo()
        {
            Elfo elfo = new Elfo("Legolas");
            Enano coco = new Enano("COCO");
            Mago mimi = new Mago("MIMI");
            mimi.RealizarAtaque(coco);

            elfo.CurarA(coco);

            Assert.That(coco.ObtenerVida(), Is.EqualTo(100));
        }
    }
}