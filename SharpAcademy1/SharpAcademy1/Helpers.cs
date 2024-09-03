using Microsoft.VisualBasic;

namespace SharpAcademy1
{
    internal class Helpers
    {
        private static List<string> games = new List<string>();
        internal static void AddGameResult(string result)
        {
            games.Add(result);
        }
        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("=== Games History ===");
            Console.WriteLine("======================");
            if (games.Count == 0)
            {
                Console.WriteLine("No games played yet.");
            }
            else
            {
                foreach (var game in games)
                {
                    Console.WriteLine($"- {game}");
                }
            }
            Console.WriteLine("======================");
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadLine();
        }

        
    }
}
