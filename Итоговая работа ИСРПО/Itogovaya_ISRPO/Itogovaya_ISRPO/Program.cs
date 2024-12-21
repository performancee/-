using System;

class Program
{
    static void Main(string[] args)
    {
        igra game = new igra();
        game.Play();
        tests tests = new tests();
        tests.ComputerChoiceTest();
        tests.WinnerTest();
        tests.DrawTest();
    }
}