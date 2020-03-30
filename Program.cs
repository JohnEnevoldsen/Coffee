using System;
using System.Collections.Generic;

namespace Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Coffee blackCoffee = new BlackCoffee();
            Console.WriteLine("Prisen for Sort Kaffe er " + blackCoffee.Price());
            Coffee latte = new Latte();
            Coffee cortado = new Cortado();
            Console.WriteLine("Prisen for Latte er " + latte.Price());
            Console.WriteLine("Prisen for Cortado er " + cortado.Price());
            Console.WriteLine(blackCoffee);
            Console.WriteLine(latte);
            Console.WriteLine(cortado);
            List<Coffee> listOfCoffee = new List<Coffee>();
            listOfCoffee.Add(blackCoffee);
            listOfCoffee.Add(latte);
            listOfCoffee.Add(cortado);
            Console.WriteLine();
            foreach(var hej in listOfCoffee){
                Console.WriteLine(hej.Price());
                Console.WriteLine(hej.ToString());
            }
        }
    }
}
