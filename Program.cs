
int playerScore = 0;
int computerScore = 0;
string winner;

List<char> choices = new List<char> { 'r', 's', 'p' };

Console.WriteLine("Welcome to rock paper scissors!");

Random random = new Random();

while (playerScore != 3 && computerScore != 3)
{
    Console.WriteLine($"Player score - {playerScore} | Computer score - {computerScore}");
    Console.WriteLine("Player enter 'r' for rock, 'p' for paper, 's' for scissors");

    char playerChoice = Convert.ToChar(Console.ReadLine());

    int computerChoiceIndex = random.Next(0, choices.Count);

    int userIndex = choices.IndexOf(playerChoice);

    int result = (userIndex - computerChoiceIndex + 3) % 3;

    if (result == 0)
    {
        Console.WriteLine("It's a tie!");
    }
    else if (result == 1)
    {
        Console.WriteLine("Player wins!");
        playerScore++;
    }
    else
    {
        Console.WriteLine("Computer wins!");
        computerScore++;
    }
}

Console.WriteLine("The winner is: " + (playerScore == 3 ? "Player" : "Computer") + "!");
