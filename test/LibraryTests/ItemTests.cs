using NUnit.Framework;
using Ucu.Poo.RolePlayGame;

namespace Ucu.Poo.RolePlayGame.Tests
{
    //Clase de prueba para poder probar item, porque item es una clase abstracta
    public class ItemDePrueba : Item
    {
        public ItemDePrueba(string nombre)
            : base(nombre)
        {
            
        }
    }
    [TestFixture]
    public class ItemTests
    {
        [Test]
        public void CrearItemGuardaNombreCorrecto()
        {
            ItemDePrueba item = new ItemDePrueba("Espada");
            string nombre = item.Nombre;
            Assert.That(nombre, Is.EqualTo("Espada"));
        }
        [Test]
        public void CrearItemConNombreVacioLanzaExcepcion()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new ItemDePrueba("");
            });
        }
        [Test]
        public void CrearItemConNombreNullLanzaExcepcion()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new ItemDePrueba(null);
            });
        }
    }
}