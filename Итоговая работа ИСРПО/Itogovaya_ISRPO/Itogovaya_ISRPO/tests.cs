using System;

public class tests
{
    public void ComputerChoiceTest()
    {
        igra game = new igra();
        string choice = game.GetComputerChoice();
        if (choice == "камень" || choice == "ножницы" || choice == "бумага")
        {
            Console.WriteLine("Passed");
        }
        else
        {
            Console.WriteLine("Failed");
        }
    }

    public void WinnerTest()
    {
        igra game = new igra();

        string player = "камень";
        string computer = "ножницы";
        game.DetermineWinner(player, computer);
    }
    public void DrawTest()
    {
        igra game = new igra();
        string player = "бумага";
        string computer = "бумага";
        game.DetermineWinner(player, computer); 
    }
}