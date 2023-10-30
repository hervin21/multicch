using System;

namespace TABLA_DE_MULTIPLICAR_CON_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, I, RESUL;
            string linea;

            Console.Write("DIGITE NÚMERO: ");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);

            I = 1;

            while (I <= 12)
            {
                RESUL = NUM * I;
                Console.WriteLine($"{NUM} x {I} = {RESUL}");
                I = I + 1;
            }

            Console.Write("Pulse una Tecla: ");
            Console.ReadLine();
        }
    }
}
