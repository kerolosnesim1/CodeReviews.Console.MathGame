using System;

using System.Linq;


namespace SharpAcademy1
{
    internal class GameEngin
    {
        
        internal void DivisionGame(string message)
        {

            var random = new Random();
            int Score = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                int FirstNumber, SecondNumber;


                do
                {
                    FirstNumber = random.Next(1, 100);
                    SecondNumber = random.Next(1, 10);
                } while (FirstNumber % SecondNumber != 0);


                Console.WriteLine($"{FirstNumber} / {SecondNumber}");
                var Result = Console.ReadLine();

                if (int.Parse(Result) == FirstNumber / SecondNumber)
                {
                    Console.WriteLine("Correct answer! Type any key for the next question");
                    Score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("wrong answer! Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 2)
                {
                    Console.WriteLine($"Game over. your score is {Score}");
                    Console.ReadLine();
                }

            }
             Helpers.AddGameResult($"* Division : Score = {Score}");

        }
       internal void MultiplicationGame(string message)
        {
            var random = new Random();
            int Score = 0;

            for (int i = 0; i < 3; i++)

            {
                Console.Clear();
                Console.WriteLine(message);

                int FirstNumber = random.Next(1, 9);
                int SecondNumber = random.Next(1, 9);

                Console.WriteLine($"{FirstNumber} * {SecondNumber}");
                var Result = Console.ReadLine();

                if (int.Parse(Result) == FirstNumber * SecondNumber)
                {
                    Console.WriteLine("Correct answer! Type any key for the next question");
                    Console.ReadLine();
                    Score++;
                }
                else
                {
                    Console.WriteLine("wrong answer! Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 2)
                {
                    Console.WriteLine($"Game over. your score is {Score}");
                    Console.ReadLine();
                }

            }
            Helpers.AddGameResult($"* Multiplication : Score = {Score}");

        }
       internal void SubtractionGame(string message)
        {
            var random = new Random();
            int Score = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int FirstNumber = random.Next(1, 9);
                int SecondNumber = random.Next(1, 9);

                Console.WriteLine($"{FirstNumber} - {SecondNumber}");
                var Result = Console.ReadLine();

                if (int.Parse(Result) == FirstNumber - SecondNumber)
                {
                    Console.WriteLine("Correct answer! Type any key for the next question");
                    Console.ReadLine();
                    Score++;
                }
                else
                {
                    Console.WriteLine("wrong answer! Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 2)
                {
                    Console.WriteLine($"Game over. your score is {Score}");
                    Console.ReadLine();
                }

            }
            Helpers.AddGameResult($"* Subbraction : Score = {Score}");
        }
       internal void AdditionGame(string message)
        {
            var random = new Random();
            int Score = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int FirstNumber = random.Next(1, 9);
                int SecondNumber = random.Next(1, 9);

                Console.WriteLine($"{FirstNumber} + {SecondNumber}");
                var Result = Console.ReadLine();

                if (int.Parse(Result) == FirstNumber + SecondNumber)
                {
                    Console.WriteLine("Correct answer! Type any key for the next question");
                    Console.ReadLine();
                    Score++;
                }
                else
                {
                    Console.WriteLine("wrong answer! Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 2)
                {
                    Console.WriteLine($"Game over. your score is {Score}");
                    Console.ReadLine();
                }

            }
            Helpers.AddGameResult($"* Addition : Score = {Score}");
        }
    }
}
