using System;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Please, enter lengths of arrays separated with Enter:");
        long firstLength = Math.Abs(long.Parse(Console.ReadLine()));
        long secondLength = Math.Abs(long.Parse(Console.ReadLine()));
        //This isn't correct, but I don't want to throw exception.

        long[] firstArray = new long[firstLength];
        long[] secondArray = new long[secondLength];

        Console.WriteLine("Please, enter first array. The elements must separate with Enter:");
        for (long index = 0; index < firstLength; index++)
        {
            firstArray[index] = long.Parse(Console.ReadLine());
        }

        Console.WriteLine("Please, enter second array. The elements also must separate with Enter:");
        for (long index = 0; index < secondLength; index++)
        {
            secondArray[index] = long.Parse(Console.ReadLine());
        }

        long lengthOfArrays = 0;
        bool isEqualLength = false;

        if (firstLength <= secondLength)
        {
            lengthOfArrays = firstLength;
        }
        else
        {
            lengthOfArrays = secondLength;
        }

        if (firstLength == secondLength)
        {
            isEqualLength = true;
        }

        for (int index = 0; index < lengthOfArrays; index++)
        {
            if (firstArray[index] == secondArray[index])
            {
                Console.WriteLine("{0} = {1}", firstArray[index], secondArray[index]);
            }
            else if (firstArray[index] != secondArray[index])
            {
                Console.WriteLine("The arrays aren't equal.");
                break;
            }

            if (index == lengthOfArrays - 1)
            {
                if (isEqualLength)
                {
                    Console.WriteLine("The arrays are equal.");
                }
                else
                {
                    Console.WriteLine("The arrays aren't equal.");
                }
            }
        }
    }
}
