# Tarea 4

___

## Programa 1:

    using System;
    class A
        {
        public int a;
        public A()
            {
            a = 10;
            }

        public virtual string Display()
        {
        return a.ToString();
        }
        }

    class B:A
    {
    public int b;
    public B():base()
    {
        b = 15;
    }
    public override string Display()
    {
        return b.ToString();
    }
    }

    class Program
    {
        public static void Main()
        {
            A obja = new A();
            B objb = new B();

            Console.WriteLine(a.Display());
            Console.WriteLine(b.Display());
        }
    }

    ___

## ¿Qué valores imprimen las lineas (1) y (2)?

Se imprimen dos veces el 10

___

## Redefine el método Display en el espacio indicado, una vez redefinido el método, ¿Qué valores imprimen las linea (1) y (2)?

El numero 10 y el numero 15 

___

## ¿Qué palabra debes agregar en la linea (public ____ string Display()) al definir A.Display?

Tiene que ser:
public virtual string Display()

___

## Programa 2:

    ________ class Musico

        {

        public string nombre;

        public Musico (string n)
            {

            nombre = n;
            }

    public abstract (A) void Afina();  (B)
    public (C) string Display()
        { 
        return nombre;
        }
    }

    class Bajista: Musico
    {
        public string instrumento;

        public Bajista (string n, string i ) ......
        .........

        public _________ Afina()
        {
        ________________
        }
    }

    class Guitarrista ____________
        {
        public instrumento;
        // Falta el constructor y otras cosas??
        }

    class Program
    {
    public static Main()
    {

    Musico musico = new Musico("Django"); (D)
    Bajista b = new Bajista("Flea");
    Guitarrista g = new Guitarrista("Santana");
    List<Musico> musicos = ____________________
    musicos.Add( b);
    musicos.Add(g);

    foreach ( _____in musicos______)
            ____________________
    // (m as IAfina).Afina()
    Console.ReadKey();
    }
    }

___

## Hay un error en uno de los puntos (A)(B)(C)(D). ¿Cual es y por que?

(C) = es public override string Display()

___

## ¿Que metodo se debe implementar obligatoriamente en ambas clases y por que?

El metodo Afina, en las clases derivadas, se tiene que poner el metodo de la clase base.

___

## ¿Por que no se ponen las llaves en (B)?¿Cuando si se ponen?

Creo que es porque si la clase fuese abstracta ahi si llevaría llaves, de lo contrario no.

___

## ¿Que pasa si el metodo Afina() lo hacemos virtual en lugar de abstract?

En realidad no cambia nada, sigue haciendolo en la clase derivada, no en la clase base.

___

## Implementa el programa utilizando interfaces en lugar de herencia.

        using System;
        using System.Collections.Generic;


        interface IAfina
        {
            void Afina();
        }

        class Musico:IAfina
        {
            public string nombre;
            public Musico (string n)
            {
                 nombre = n;
            }

            public void Afina()
            {
                Console.WriteLine("Afinando");
            }

            public virtual string Display()
            { 
            return string.Format(nombre);
            }
        }

        class Bajista: Musico, IAfina
        {
            public string instrumento;

            public Bajista(string n, string i) : base(n)
            {
                instrumento = i;
            }

            public virtual new void Afina()
            {
                Console.WriteLine("Afinando el bajo");
            }

            public override string Display()
            {
                return string.Format(instrumento);
            }
        }

        class Guitarrista: Musico, IAfina
        {
            public string guitarra;

            public Guitarrista(string n, string g) : base(n)
            {
                guitarra = g;
            }
            public new void Afina()
            {
                Console.WriteLine("Afinando la guitarra");
            }

            public override string Display()
            {
                return string.Format(guitarra);
            }
        }

        class Program
        {
        public static void Main()
        {
                List<Musico> musicos = new List<Musico>();
                Musico m = new Musico("Django"); 
                Bajista b = new Bajista("Flea", "Bajo");
                Guitarrista g = new Guitarrista("Santana", "Guitarra");
                musicos.Add(b);
                musicos.Add(g);
                musicos.Add(m);

                foreach (Musico lo in musicos)
                {
                    (m as IAfina).Afina();
                    (g as IAfina).Afina();
                    (b as IAfina).Afina();
                }
            }
        }