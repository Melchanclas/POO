﻿using System;
using System.Collections.Generic;

namespace Figura2
{
    class Vector2d
    {
        public int x, y;
        public Vector2d(int x, int y)
        {
            this.x=x; this.y=y;
        }
        public override string ToString()
        {
            return String.Format("{0},{1}", x, y);
        }
    }
    abstract class Figura
    {
        public Vector2d position;
        public string fill ,border;

        //Constructor por defecto 
        public Figura():this( new Vector2d(100, 100))
        {
        
        }
        //constructor de figura
        public Figura(Vector2d pos)
        {
            position = pos;
            fill = "white";
            border = "black";
        }

        public abstract void Dibuja();
    }

    class Circulo : Figura
    {
     private int radio;
     public Circulo(Vector2d pos, int radio):base(pos)
     {
         this.radio = radio;
     }
     public Circulo ():base()
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
     
     public Rectangulo(Vector2d pos):base(pos)
     {
         
     }
     public Rectangulo ():base()
     {
        
     }

     public override void Dibuja() 
     {
         Console.WriteLine("Se dibuja un Rectangulo en {0} de color {1}", position, border);
     }
    }

class Triangulo : Figura
    {
     
     public Triangulo(Vector2d pos):base(pos)
     {
         
     }
     public Triangulo ():base()
     {
        
     }

     public override void Dibuja() 
     {
         Console.WriteLine("Se dibuja un Triangulo en {0} de color {1}", position, fill);
     }

    }

    // 11:07 PM, profesor, me rindo, no se como hacer para sacar el area :c Necesito comer algo :c 

    class Program
    {
        static void Main(string[] args)
        {

            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo());
            figuras.Add(new Rectangulo(new Vector2d(200,200)));
            figuras.Add(new Triangulo(new Vector2d(400,400)));
            foreach(Figura f in figuras)
            {
            f.Dibuja();
            }
        }
    }
}