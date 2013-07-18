using System;

class MaxSequenceOfEqualElem
{
    static void Main()
    {
        Console.WriteLine("Please, enter array separate with something:");
        string inputArray = Console.ReadLine();
        char[] charArray = inputArray.ToCharArray();
        long lengthOfCharArray = charArray.Length;
        string trimArray = "";

        for (int index = 0; index < lengthOfCharArray; index++)
        {
            if (charArray[index] != ',' && charArray[index] != ' ' && charArray[index] != '\t')
            {
                trimArray = trimArray + charArray[index].ToString();
            }
        }

        long lengthOfArray = trimArray.Length;
        long[] longArray = new long[lengthOfArray];

        for (int index = 0; index < lengthOfArray; index++)
        {
            longArray[index] = long.Parse(trimArray[index].ToString());
        }

        long[] sequence = new long[lengthOfArray];
        int indexOfSequence = 0;
        sequence[0] = longArray[0];

        long[] maximalSequence = sequence;
        int lengthOfMaxSequence = indexOfSequence + 1;

        for (int index = 1; index < lengthOfArray; index++)
        {
            if (sequence[indexOfSequence] == longArray[index])
            {
                indexOfSequence++;
            }
            else
            {
                if (lengthOfMaxSequence < indexOfSequence + 1)
                {
                    maximalSequence = sequence;
                    lengthOfMaxSequence = indexOfSequence + 1;
                }

                indexOfSequence = 0;

                //It's maybe mistake, but working.
                if (index == lengthOfArray - 1)
                {
                    break;
                }
            }

            sequence[indexOfSequence] = longArray[index];
        }

        for (int index = 0; index < lengthOfMaxSequence; index++)
        {
            if (index == 0)
            {
                Console.Write("Max sequence of equal elements is {");
            }

            Console.Write("{0}", maximalSequence[index]);

            if (index + 1 < lengthOfMaxSequence)
            {
                Console.Write(", ");
            }
            else
            {
                Console.WriteLine("}");
            }
        }
    }
}
