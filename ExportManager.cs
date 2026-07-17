using System;

public static class ExportManager
{
    public static void Export(
        BusinessCard card)
    {
        foreach (var format in Settings.Formats)
        {
            Console.WriteLine(
                $"{format} exported"
            );
        }
    }
}
