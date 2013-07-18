using System;

class CompareStrings
{
    static void Main()
    {
        Console.WriteLine("Please, enter two strings separated with Enter:");
        string firstString = Console.ReadLine();
        string secondString = Console.ReadLine();

        char[] firstToArray = firstString.ToCharArray();
        long lengthOfFirst = firstToArray.Length;

        char[] secondToArray = secondString.ToCharArray();
        long lengthOfSecond = secondToArray.Length;

        long lengthOfArrays = 0;
        bool isEqualLength = false;

        if (lengthOfFirst <= lengthOfSecond)
        {
            lengthOfArrays = lengthOfFirst;
        }
        else
        {
            lengthOfArrays = lengthOfSecond;
        }

        if (lengthOfFirst == lengthOfSecond)
        {
            isEqualLength = true;
        }

        for (int index = 0; index < lengthOfArrays; index++)
        {
            if (firstToArray[index] == secondToArray[index])
            {
                Console.WriteLine("{0} = {1}", firstToArray[index], secondToArray[index]);
            }
            else if (firstToArray[index] != secondToArray[index])
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
