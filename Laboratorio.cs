using System;

namespace Practica_supervisada
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nonumeros = 0;
            int m = 0;
            int suma = 0;
            char mine = 'n';

            Console.Write("Cuantos numeros solicitara:");
            Nonumeros = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            while (mine != 's')
            {

                for (m = 1; m <= Nonumeros; m++)
                {
                    int a = 0, j, c;
                    Console.WriteLine("Ingrese numero:");
                    c = int.Parse(Console.ReadLine());

                    for (j = 1; j < (c + 1); j++)
                    {
                        if (c % j == 0)
                        {
                            a++;

                        }
                    }
                    if (a != 2)
                    {

                        Console.WriteLine("No es Primo, no se puede realizar la suma");
                    }
                    if (a == 2)
                    {

                        Console.WriteLine("Si es Primo, se realizara la suma correctamente");
                        suma = suma + c;

                    }
                }
                Console.WriteLine("La Suma es:" + suma);
                mine = menu();


            }

        }

        static char menu()
        {
            Console.WriteLine("Desea salir[s/n]:");
            return (char.Parse(Console.ReadLine()));
        }
    }
}