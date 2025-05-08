using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem07_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //juego sobre adivinar que numero, emitir sonidos 
            int alea, bing;
            Random R = new Random(); 
            alea = R.Next(1,10);
            Console.WriteLine("Numero aleatorio generado " + alea);
            do
            {

                Console.WriteLine("Ingrese un numero");
                bing = int.Parse(Console.ReadLine());
                if (bing == alea)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Adivinaste!");
                    Console.Beep(800, 400);
                    Console.Beep(8001,400);
                    Console.Beep(1300, 500);
                    Console.Beep(8001, 1000);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {//numero ingresado =5      numero aleatorio=6
                    if(bing>alea)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Ingrese un n° mayor al anterior");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ingrese un n° menor al anterior");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
            }
            while (bing != alea); //True, no adivinaste
        }
    }
}
