using NUnit.Framework;
using Ucu.Poo.RolePlayGame;

namespace Ucu.Poo.RolePlayGame.Tests
{
    //Clase de prueba que hereda de Personaje
    public class PersonajeDePrueba : Personaje
    {
        public PersonajeDePrueba(string nombre, int vida)
            : base(nombre, vida)
        {
            
        }
    }
    [TestFixture]
    public class PersonajeTests
    {
        [Test]
        public void CrearPersonajeNombreCorrecto()
        {
            PersonajeDePrueba personaje = new PersonajeDePrueba("Gandalf", 100);
            string nombre = personaje.Nombre;
            Assert.That(nombre, Is.EqualTo("Gandalf"));
        }
        [Test]
        public void CrearPersonajeVidaCorrecta()
        {
            PersonajeDePrueba personaje = new PersonajeDePrueba("Gandalf", 100);
            int vida = personaje.ObtenerVida();
            Assert.That(vida, Is.EqualTo(100));
        }
        [Test]
        public void RecibirAtaqueReduceLaVida()
        {
            PersonajeDePrueba personaje = new PersonajeDePrueba("Gandalf", 100);
            personaje.RecibirAtaque(30);
            Assert.That(personaje.ObtenerVida(), Is.EqualTo(70));
        }
        [Test]
        public void CurarDevuelveLaVidaMaxima()
        {
            PersonajeDePrueba personaje = new PersonajeDePrueba("Gandalf", 100);
            personaje.RecibirAtaque(40);
            personaje.Curar();
            Assert.That(personaje.ObtenerVida(), Is.EqualTo(100));
        }
        [Test]
        public void RealizarAtaqueSinAtaqueBaseNoHaceDanio()
        {
            PersonajeDePrueba atacante = new PersonajeDePrueba("Gandalf", 100);
            PersonajeDePrueba objetivo = new PersonajeDePrueba("Orco", 100);
            atacante.RealizarAtaque(objetivo);
    
            Assert.That(objetivo.ObtenerVida(), Is.EqualTo(100));
        }
    }
}