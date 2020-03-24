using System;

namespace laboratorio1diegoriedel
{
    class Program
    {
        static void Main(string[] args)
        {
            person diego = new person();
            Console.WriteLine(diego.lanzar());
            person nombre = new person();
            Console.WriteLine(nombre.Getname());
            Console.WriteLine(nombre.Getlastname());

            
        }
    }
}
