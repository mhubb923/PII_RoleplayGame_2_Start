classDiagram
    Personaje <|-- Mago
    Personaje <|-- Caballero
    Personaje <|-- Enano

    Item <|-- Arma
    Item <|-- Ropaje
    Item <|-- ItemMagico
    
    ItemMagico <|-- LibroDeHechizos
    Arma ..|> IAtacable
    Ropaje ..|> IDefendible
    ItemMagico ..|> IAtacable
    ItemMagico ..|> IDefendible
    
    Personaje "1" o-- "*" Item : tiene
    LibroDeHechizos "1" *-- "*" Hechizo : contiene
    
    class Personaje{
        <<abstract>>
        -string nombre
        -int vida
        -int vidaMaxima
        -int ataqueBase
        -int defensaBase
        -List~Item~ items
        #Personaje(string nombre, int vida)
        +AgregarItem(Item item)
        +QuitarItem(Item item)
        +ObtenerAtaqueTotal() int
        +ObtenerDefensaTotal() int
        +RecibirAtaque(int poder)
        +Curar()
        +RealizarAtaque(Personaje objetivo)
        +ObtenerVida() int
        #AumentarAtaqueBase(int cantidad)
        #AumentarDefensaBase(int cantidad)
        #PuedeUsarItemsMagicos bool
    }
    
    class Mago{
        +Mago(string nombre)
        +Estudiar()
    }

    class Elfo{
        +Elfo(string nombre)
        +CurarA(Personaje objetivo)
    }
    
    class Enano{
        +Enano(string nombre)
    }

    class Item{
        <<abstract>>
    }
    
    class IAtacable{
        <<interface>>
        +ObtenerAtaque() int
    }
    
    class IDefendible{
        <<interface>>
        +ObtenerDefensa() int
    }
    
    class Arma{
        -int valorAtaque
        +Arma(int valorAtaque)
        +ObtenerAtaque() int
    }
    
    class Ropaje{
        -int valorDefensa
        +Ropaje(int valorDefensa)
        +ObtenerDefensa() int
    }
    
    class ItemMagico{
        <<abstract>>
        -int valorAtaque
        -int valorDefensa
        -bool esMagico
        +ObtenerAtaque() int
        +ObtenerDefensa() int
    }
    
    class LibroDeHechizos{
        -List~Hechizo~ hechizos
        +AgregarHechizo(Hechizo h)
        +QuitarHechizo(Hechizo h)
        +ObtenerAtaque() int
        +ObtenerDefensa() int
    }
    
    class Hechizo{
        -int valorAtaque
        -int valorDefensa
        +Hechizo(int valorAtaque, int valorDefensa)
        +ObtenerAtaque() int
        +ObtenerDefensa() int
    }
