using System;

namespace Dado
{
    class Dados
    {
        public int valor;
        public string color;

        public Dados (int v, string color)
        {
            valor = v;
            this.color = color;
        }
        public void imprime()
        {
            Console.WriteLine("Valor dado: {0} \n Color dado: {1}" , valor , color);
        }

        public static bool operator < (Dados a, Dados b)
        {
            return a.valor < b.valor;
        }

        public static bool operator > (Dados a, Dados b)
        {
            return a.valor > b.valor;
        }

        public static bool operator != (Dados a, Dados b)
        {
            return a.valor != b.valor;
        }
        public static bool operator == (Dados a, Dados b)
        {
            return a.valor == b.valor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dados D1 = new Dados (5,"Rojo");
            Dados D2 = new Dados (3,"Azul");
            Dados D3 = new Dados (1,"Verde");
            D1.imprime();
        }
    }
}
