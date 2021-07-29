using System;

namespace Parâmetros_Opcionais
{
    class Program
    {
        static int Metodo(int x, int y = 10, int z = 0)
        {

            return x + y + z;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Parametros opcionais
            //Sempre o primeiro parametro é obrigatorio!
            Console.WriteLine(Metodo(1));
            Console.WriteLine(Metodo(1, 2));
            //Passando parametro com argumentos nomeados, lembrando sempre que o primeiro é obrigatorio
            Console.WriteLine(Metodo(x:1,z:50));


        }

    }
}
