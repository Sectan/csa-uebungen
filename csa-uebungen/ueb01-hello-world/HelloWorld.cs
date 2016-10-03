using System;

namespace ueb01_hello_world
{
    class HelloWorld
    {
        private void PrintMessage(string msg, bool upperCase)
        {
            if(upperCase)
            {
                msg = msg.ToUpper();
            }
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
            HelloWorld helloWorld = new HelloWorld();

            helloWorld.PrintMessage("Hello World", false);
            helloWorld.PrintMessage("Hello World", true);

            Console.ReadLine();
        }
    }
}
