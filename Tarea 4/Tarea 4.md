# Tarea 4

___

## Programa:

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
            A a = new A();
            B b = new B();

            Console.WriteLine(a.Display());
            Console.WriteLine(b.Display());
        }
    }