using System;

public class igra
{
    private int playerScore = 0;
    private int computerScore = 0;

    public void Play()
    {
        Console.WriteLine("Камень, ножницы, бумага!");
        while (true)
        {
            Console.WriteLine("Выбери: камень, ножницы, бумага или выход:");
            string playerChoice = Console.ReadLine().ToLower();

            if (playerChoice == "выход")
            {
                break;
            }

            string computerChoice = GetComputerChoice();
            Console.WriteLine($"компьютер выбрал: {computerChoice}");

            DetermineWinner(playerChoice, computerChoice);
            Console.WriteLine($"Счет: игрок {playerScore}, компьютер {computerScore}");
        }
    }

    public string GetComputerChoice()
    {
        Random random = new Random();
        int choice = random.Next(0, 3);
        if (choice == 0) return "камень";
        if (choice == 1) return "ножницы";
        return "бумага";
    }

    public void DetermineWinner(string player, string computer)
    {
        if (player == computer)
        {
            Console.WriteLine("Ничья!");
        }
        else if ((player == "камень" && computer == "ножницы") ||
                 (player == "ножницы" && computer == "бумага") ||
                 (player == "бумага" && computer == "камень"))
        {
            Console.WriteLine("Вы выиграли!");
            playerScore++;
        }
        else
        {
            Console.WriteLine("Компьютер выиграл!");
            computerScore++;
        }
    }
}