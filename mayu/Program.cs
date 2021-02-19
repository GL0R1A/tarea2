using System;

namespace Mayus
{
    class Mayus
    {
        static void Main(string[] args)
        {
            string let;
            Console.WriteLine("Escriba cualquier letra: \n");
            let = Console.ReadLine();


            if (let == "A" || let == "B" || let == "C" || let == "D" || let == "E" ||
                let == "F" || let == "G" || let == "H" || let == "I" || let == "J" ||
                let == "K" || let == "L" || let == "M" || let == "N" || let == "Ñ" ||
                let == "O" || let == "P" || let == "Q" || let == "R" || let == "S" ||
                let == "T" || let == "U" || let == "V" || let == "W" || let == "X" ||
                let == "Y" || let == "Z") { Console.WriteLine(" SI ES MAYUSCULA "); }
            else
            {
                Console.WriteLine("NO ES MAYUSCULA :");
                Console.WriteLine();
                Console.Write("Presione una tecla para terminar . . . ");
                Console.ReadKey();
            }
        }
    }

