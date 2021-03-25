using System;

namespace RepetitionExampleGrp1 {
    class Program {
        static void Main(string[] args) {
            
            System.Console.Write("Please enter a name: ");
            string input = Console.ReadLine();
            
            System.Console.Write("Please enter number of times to repeat: ");
            string input2 = Console.ReadLine();
            int number = int.Parse(input2);

            int counter = 0;


            while ( counter < number) {
                System.Console.WriteLine(input + " | " + counter);
                
                // counter = counter + 1
                counter++;
            }

            System.Console.WriteLine("Goodbye");
        }
    }
}
