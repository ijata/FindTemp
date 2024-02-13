// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;


public class TemperatureAnalizer
{
    public static int FindHighestTemperature(int[] temperatures)
    {
        // TODO: Uzupełnij implementację, znajdując najwyższą temperaturę
        // wśród wszystkich temperatur w tablicy.
        // Zwróć wartość najwyższej temperatury.
        int i = 0;
        int temp = 0;

        while (i < temperatures.Length)
        {
            if (i == 0)
            {
                temp = temperatures[0];
            }
            else
            {
                if (temp < temperatures[i])
                {
                    temp = temperatures[i];
                }
            }

            i++;

        }

        return temp;
    }

    // Znajduje najniższą temperaturę w tablicy temperatur
    public static int FindLowestTemperature(int[] temperatures)
    {
        // TODO: Uzupełnij implementację, znajdując najniższą temperaturę
        // wśród wszystkich temperatur w tablicy.
        // Zwróć wartość najniższej temperatury.
        int i = 0;
        int temp = 0;


        while (i < temperatures.Length)
        {
            if (i == 0)
            {
                temp = temperatures[0];
            }
            else
            {
                if (temp > temperatures[i])
                {
                    temp = temperatures[i];
                }
            }

            i++;

        }

        return temp;
    }
    public static void Main(string[] args)
    {
        int[] temperatures = { 12, 32, 21, 43, 10, 8, 26, 0 };


        Console.WriteLine(FindHighestTemperature(temperatures));
        Console.WriteLine(FindLowestTemperature(temperatures));
    }

}