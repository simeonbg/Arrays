using System;

class PrintArrayWithIndexMultipliedBy5
{
    static void Main()
    {
        int number = 20;
        int[] array = new int[number];

        for (int index = 0; index < number; index++)
        {
            array[index] = index * 5;
            Console.WriteLine("{0}. {1}", index + 1, array[index]);
        }
    }
}
