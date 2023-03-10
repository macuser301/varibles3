using System;

namespace Varibles3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 42;
            string firstName = "Rob";
            bool isAlive = true;

            var fullName = "Rob Davis";
            int houseNumber = 130;
            decimal exactBalance = 22500.00m;
            decimal walletBalance = 10000.00m;
            double homeSize = 2400;
            int treeHeight = 10;
            string Present1 = "Lamborghini Hurcan Performante Spyder";
            string Present2 = "Lamborghini Aventador SVJ Roadster";
            string Present3 = "Software Engineering Job";
            string christmasPresents = "tie, PS5, new PC";


            Console.WriteLine("Hello World!");
            Console.WriteLine($"Hi,im {firstName} it is {isAlive} that i'am {age} years old.");
            Console.WriteLine($"My full name is {fullName} and I have ${walletBalance}");
            Console.WriteLine($"My {isAlive} bank account balance is ${exactBalance} and My house number is {houseNumber}");
            Console.WriteLine($"My homes square footage is {homeSize}");
            Console.WriteLine($"Its big enough for a {treeHeight}' tall tree");
            Console.WriteLine($"Here are 3 presents I dream of for Christmas. A {Present1},{Present2} and a {Present3}.");
            Console.WriteLine($"A little much I know. But,{firstName} can still dream lol.");
            Console.WriteLine($"I also want a {christmasPresents}");



        }
    }
}
