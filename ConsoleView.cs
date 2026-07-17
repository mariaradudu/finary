using System;

public static class ConsoleView
{
    public static void Show(
        BusinessCard card)
    {
        Console.WriteLine(
            "Generating Business Card..."
        );

        Console.WriteLine();

        Console.WriteLine(card.Contact.Name);

        Console.WriteLine(card.Contact.Company);

        Console.WriteLine();

        ExportManager.Export(card);

        Console.WriteLine();

        Console.WriteLine("Completed.");
    }
}
