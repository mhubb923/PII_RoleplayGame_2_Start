using System;
using Ucu.Poo.RolePlayGame;

LibroDeHechizos libro = new LibroDeHechizos("Grimorio");
libro.AgregarHechizo(new HechizoAtaque("Bola de Fuego", 70));

Mago gandalf = new Mago("Gandalf");
gandalf.AgregarItem(new Staff("Baculo", 100, 100));
gandalf.AgregarItem(libro);

Enano gimli = new Enano("Gimli");
gimli.AgregarItem(new Arma("Hacha", 25));
gimli.AgregarItem(new Ropaje("Escudo", 14));
gimli.AgregarItem(new Ropaje("Casco", 10));

Console.WriteLine($"{gimli.Nombre} tiene ❤️ {gimli.ObtenerVida()} de vida.");
Console.WriteLine($"{gandalf.Nombre} ataca a {gimli.Nombre} con ⚔️ {gandalf.ObtenerAtaqueTotal()} de poder.");

gimli.RecibirAtaque(gandalf.ObtenerAtaqueTotal());

Console.WriteLine($"{gimli.Nombre} recibió el impacto y ahora tiene ❤️ {gimli.ObtenerVida()} de vida.");

gimli.Curar();

Console.WriteLine($"{gimli.Nombre} ha sido curado y su vida volvió a ❤️ {gimli.ObtenerVida()}.");
