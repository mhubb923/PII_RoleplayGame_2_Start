classDiagram

    Personaje <|-- Mago
    Personaje <|-- Elfo
    Personaje <|-- Enano

    Item <|-- Arma
    Item <|-- Ropaje
    Item <|-- ElementoMagico
    Item <|-- LibroDeHechizos

    Arma ..|> IAtacable
    Ropaje ..|> IDefendible

    ElementoMagico ..|> IAtacable
    ElementoMagico ..|> IDefendible
    ElementoMagico ..|> IItemMagico

    LibroDeHechizos ..|> IAtacable
    LibroDeHechizos ..|> IDefendible
    LibroDeHechizos ..|> IItemMagico

    Personaje "1" o-- "*" Item : tiene
    LibroDeHechizos "1" *-- "*" Hechizo : contiene

    class Personaje {
        <<abstract>>
        -string nombre
        -int vida
        -int vidaMaxima
        -int ataqueBase
        -int defensaBase
        -List~Item~ items
        #Personaje(string nombre, int vida, int ataqueBase, int defensaBase)
        +AgregarItem(Item item) bool
        +QuitarItem(Item item)
        +ObtenerAtaqueTotal() int
        +ObtenerDefensaTotal() int
        +RecibirAtaque(int poder)
        +Curar()
        +RealizarAtaque(Personaje objetivo)
        +ObtenerVida() int
        #AumentarAtaqueBase(int cantidad)
        #AumentarDefensaBase(int cantidad)
        #PuedeUsarItemsMagicos() bool
    }

    class Mago {
        +Mago(string nombre)
        +Estudiar()
        #PuedeUsarItemsMagicos() bool
    }

    class Elfo {
        +Elfo(string nombre)
        +CurarA(Personaje objetivo)
        #PuedeUsarItemsMagicos() bool
    }

    class Enano {
        +Enano(string nombre)
        #PuedeUsarItemsMagicos() bool
    }

    class Item {
        <<abstract>>
        -string nombre
    }

    class IAtacable {
        <<interface>>
        +ObtenerAtaque() int
    }

    class IDefendible {
        <<interface>>
        +ObtenerDefensa() int
    }

    class IItemMagico {
        <<interface>>
    }

    class Arma {
        -int valorAtaque
        +Arma(string nombre, int valorAtaque)
        +ObtenerAtaque() int
    }

    class Ropaje {
        -int valorDefensa
        +Ropaje(string nombre, int valorDefensa)
        +ObtenerDefensa() int
    }

    class ElementoMagico {
        -int valorAtaque
        -int valorDefensa
        +ElementoMagico(string nombre, int valorAtaque, int valorDefensa)
        +ObtenerAtaque() int
        +ObtenerDefensa() int
    }

    class LibroDeHechizos {
        -List~Hechizo~ hechizos
        +LibroDeHechizos(string nombre)
        +AgregarHechizo(Hechizo h)
        +QuitarHechizo(Hechizo h)
        +ObtenerAtaque() int
        +ObtenerDefensa() int
    }

    class Hechizo {
        <<abstract>>
        -string nombre
    }

    Hechizo <|-- HechizoAtaque
    Hechizo <|-- HechizoDefensa
    HechizoAtaque ..|> IAtacable
    HechizoDefensa ..|> IDefendible

    class HechizoAtaque {
        -int valorAtaque
        +HechizoAtaque(string nombre, int valorAtaque)
        +ObtenerAtaque() int
    }

    class HechizoDefensa {
        -int valorDefensa
        +HechizoDefensa(string nombre, int valorDefensa)
        +ObtenerDefensa() int
    }
