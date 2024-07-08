using System;

namespace HelloWorldApp {

    class App {
        static void Main(string[] args){
            Console.WriteLine("Hey, what's your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Nice to meet you");

            Console.WriteLine("How old are you?");
            Console.Write("I'm ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(age);

            Other.Goodbye();
        }
    }
}