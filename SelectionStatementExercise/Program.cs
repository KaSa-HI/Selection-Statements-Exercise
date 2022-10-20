using System.Diagnostics;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {


            #region Exercise 1

            var r = new Random();
            var numPick = r.Next(1, 20);
            

            Console.WriteLine("Try to guess a number I've chosen!");
            var userInput = int.Parse(Console.ReadLine());


            if (userInput<numPick)
            {
                //code block to be executecd when if {condition} solution is true
             Console.WriteLine("Try again! You're much too cold! :/");
            }

            else if (userInput>numPick)
            {
                // code block to be executed if {otherCondition} is false
             Console.WriteLine("Close! You're getting Warmer! :)");
            }

            else
            {
                // code block to be executed if {otherConditions} is false
             Console.WriteLine($"Wow, great job! 8D {numPick}");

            }
            #endregion

        }
    }
}


