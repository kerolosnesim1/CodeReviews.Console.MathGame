namespace SharpAcademy1
{
    internal class Menu
    {
        GameEngin gameEngin = new GameEngin();
       internal void ShowMenu(string? name)
        {
            Console.WriteLine("======================");
            Console.WriteLine($"\nwelcome {name.ToUpper()}  to the math game press any key to start...");
            Console.ReadLine();
            var isGameOn = true;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"Please choose the game from the list : 
         
    1 - addition. 
    2 - subtraction.
    3 - multiplication.
    4 - division.
    5 - Exit.
    6 - view previous games.

========================================");

                var SelectedGame = Console.ReadLine();


                switch (SelectedGame)
                {
                    case "1":
                        gameEngin.AdditionGame("addition game ");
                        break;


                    case "2":
                        gameEngin.SubtractionGame("subrtaction game ");
                        break;

                    case "3":
                        gameEngin.MultiplicationGame("multiplication game ");
                        break;

                    case "4":
                        gameEngin.DivisionGame("division game ");
                        break;

                    case "5":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;

                    case "6":
                        Helpers.GetGames();
                        break;

                    default:
                        Console.WriteLine("Invalid Game Number");
                        break;
                }

            } while (isGameOn);

        }
    }
}
