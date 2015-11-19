using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euromilhoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int chaves;
            int inum;

            do {
                Console.WriteLine("Quantas chaves queres (1-5)? ");
                chaves = Convert.ToInt32(Console.ReadLine());
            } while (chaves > 5 || chaves < 1);

            Random num = new Random();

            for (int i = 0; i < chaves; i++)
            {
                //gera numeros
                int[] numbers = new int[5];

                /*numbers[0] = num.Next(1, 50);
                numbers[1] = num.Next(1, 50);
                numbers[2] = num.Next(1, 50);
                numbers[3] = num.Next(1, 50);
                numbers[4] = num.Next(1, 50);*/
                for (inum = 0; inum < numbers.Length; inum++)
                {
                    numbers[inum] = num.Next(1, 50);
                }

                //gera estrelas
                int[] stars = new int[2];
                for (int istar = 0; istar < stars.Length; istar++)
                {
                    stars[istar] = num.Next(1, 11);
                }

                //escrever os numeros e estrelas
                Console.WriteLine("Os numeros para a {0} chave são:", i + 1);
                foreach (int number in numbers)
                {
                    Console.Write(" {0} ", number); 
                }
                Console.Write("-");
                foreach (int star in stars)
                {
                    Console.Write(" {0} ", star);
                }
                Console.WriteLine();
                //for (int inc = 1; inc < 6; inc++) {

                //number[inc] = num.Next(1, 50);
                //Console.WriteLine("{0} chave ", i + 1);
                //Console.WriteLine("{0} {1} {2} {3} {4} - {5} {6}", numb1, numb2, numb3, numb4, numb5, est1, est2);
                //}
            }
        }
    }
}
