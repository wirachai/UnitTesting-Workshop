using System;

namespace FirstUnitTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var helloWorld = new HelloWorld();
            Console.WriteLine(helloWorld.Print());
        }
    }
}