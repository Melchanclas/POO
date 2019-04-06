# Tarea 3

___

## ¿Qué es la Clase Base?

La clase base es aquella que ya está definida y no "depende" de alguien para que se modifique o cambie, ya tiene sus atributos y metodos fijos.

___

## ¿Qué es la Clase Derivada?

Su nombre lo dice, son las clases que derivan de una clase base, es decir, puede tomar sus atributos y metodos.

___

## UML de la relación entre las clases Figura, Rectangulo y Circulo

![UML](./Tarea 3/uml.jpg)

___

## ¿Qué es la herencia simple y herencia múltiple?

Para ser mas precisos posibles, una herencia simple es cuando solamente se tiene una clase base de la cual varias clases se pueden heredar de ella, y la herencia multiple se utilizan mas de una clase base y la clase derivada heredaría los atributos y metodos de varias clases.

___

## En C#, ¿Se pueden hacer herencia multiple?

No se puede hacer herencia multiple en C#, bueno no de clases pero si de interfaces.

___

## Programa Figuras:

        using System;
        using System.Collections.Generic;

    namespace Figuras
    {
        class Vector2D
        {
            public int x, y;
            public Vector2D(int x, int y)
            {
                this.x = x; this.y = y;
            }
            public override string ToString()
            {
                return string.Format("{0}, {1}", x, y);
            } 
        }

        /* class Color 
            {
            public enum Name { red, blue, white, green, black, none }

            public int R, G, B, I;
            public Color.Name colorName;
            public Color(int r, int g, int b, int i = 1)
            {
                R = r; G = g; B = b; I = i;
            }
            public Color(Color.Name name)
            {
        
            }
            }*/
  
        class Figura 
        {
            public Vector2D position;
            public string border;
            public string fill;
        
            public Figura():this(new Vector2D(100,100))
            {

            }
            public Figura(Vector2D pos)
            {
                position = pos;
                fill = "Rojo";
                border = "Black";
            }
            public virtual void Dibuja()
            {

            }
        }
      
        class Circulo : Figura
        {
        private int radio;
        public Circulo(Vector2D pos, int radio) : base (pos)
        {
            this.radio = radio;
        }   
        public Circulo() : base()
        {
            this.radio = 10;
        }
        public override void Dibuja()
        {
             Console.WriteLine("Se dibuja un circulo en {0} de color {1}", position, fill);
        }
        }

        class Rectangulo : Figura
        {
        public Rectangulo(Vector2D pos) : base (pos)
        {

        }
        public Rectangulo() : base()
        {

        }
        public new void Dibuja()
        {
            Console.WriteLine("Se dibuja un Rectangulo en {0} de color {1}", position, fill);
        }
        }

        class Cuadrado : Figura
        {
            public Cuadrado(Vector2D pos) : base(pos)
            {  

            }
            public Cuadrado() : base()
            {

            }
            public new void Dibuja()
            {
                Console.WriteLine("Se dibuja un Cuadrado en {0} de color {1}", position, fill);
            }

        }

        class Program
        {
            static void Main()
            {
                List<Figura> figuras = new List<Figura>();
                figuras.Add (new Circulo());
                figuras.Add (new Rectangulo(new Vector2D(200,200)));
                figuras.Add (new Cuadrado(new Vector2D(300,300)));
                foreach(Figura f in figuras)
                {
                    f.Dibuja();
                }
            }
        }
    }