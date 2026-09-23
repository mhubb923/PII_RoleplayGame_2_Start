using System;
using NUnit.Framework;
using Ucu.Poo.RolePlayGame;

namespace Ucu.Poo.RolePlayGame.Tests
{
    [TestFixture]
    public class LibroDeHechizosTests
    {
        [Test]
        public void ObtenerAtaque_LibroSinHechizos_DevuelveCero()
        {
            LibroDeHechizos libro = new LibroDeHechizos("Grimorio");

            Assert.That(libro.ObtenerAtaque(), Is.EqualTo(0));
        }

        [Test]
        public void ObtenerDefensa_LibroSinHechizos_DevuelveCero()
        {
            LibroDeHechizos libro = new LibroDeHechizos("Grimorio");

            Assert.That(libro.ObtenerDefensa(), Is.EqualTo(0));
        }

        [Test]
        public void ObtenerAtaque_LibroConVariosHechizos_DevuelveSuma()
        {
            LibroDeHechizos libro = new LibroDeHechizos("Grimorio");
            libro.AgregarHechizo(new HechizoAtaque("Fuego", 10));
            libro.AgregarHechizo(new HechizoAtaque("Rayo", 15));

            Assert.That(libro.ObtenerAtaque(), Is.EqualTo(25));
        }

        [Test]
        public void ObtenerDefensa_LibroConVariosHechizos_DevuelveSuma()
        {
            LibroDeHechizos libro = new LibroDeHechizos("Grimorio");
            libro.AgregarHechizo(new HechizoDefensa("Escudo", 8));
            libro.AgregarHechizo(new HechizoDefensa("Barrera", 12));

            Assert.That(libro.ObtenerDefensa(), Is.EqualTo(20));
        }

        [Test]
        public void QuitarHechizo_HechizoExistente_RestaAtaque()
        {
            HechizoAtaque h1 = new HechizoAtaque("Fuego", 20);
            HechizoAtaque h2 = new HechizoAtaque("Rayo", 10);

            LibroDeHechizos libro = new LibroDeHechizos("Grimorio");
            libro.AgregarHechizo(h1);
            libro.AgregarHechizo(h2);

            libro.QuitarHechizo(h1);

            Assert.That(libro.ObtenerAtaque(), Is.EqualTo(10));
        }
    }
}