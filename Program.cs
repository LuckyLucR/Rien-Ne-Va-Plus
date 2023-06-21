Random random = new Random();
int chips = 10;
List<int> bets = new List<int>();
while (chips > 0)
{
    Console.WriteLine($"\nYou have {chips} chips");
    bets.Clear();
    while (chips > 0)
    {
        int input = 100;
        Console.Write("Bet on: ");
        string userInput = Console.ReadLine();
        while (!int.TryParse(userInput, out input) && input >= 0 && input <= 36)
        {
            if (userInput == "stop") { break; }
            Console.WriteLine("You can only use numbers from 0 - 36");
            Console.Write("Bet on: ");
            userInput = Console.ReadLine();
        }
        if (userInput == "stop") { break; }
        chips--;
        bets.Add(input);
    }
    int randomNumber = random.Next(0, 37);
    Console.WriteLine($"\nRien ne va plus\nWinning number: {randomNumber}");
    foreach (int bet in bets)
    {
        if (bet == randomNumber) chips += 35;
    }
}
Console.WriteLine("GAME OVER");