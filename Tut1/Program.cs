using System;

namespace Tut1
{
    class Program
    {
        public static int BinaryToDecimal(int[] binaryArray)
        {
            int decimalValue = 0;
            int pos = 0;

            for (int i = binaryArray.Length - 1; i >= 0; i--)
            {
                if (binaryArray[i] == 1)
                {
                    decimalValue += Convert.ToInt32(Math.Pow(2, pos));
                }
                pos++;
            }

            return decimalValue;
        }
        public static int MinDistance(int[] numberArray)
        {
            int dmin = Int32.MaxValue;
            int numberArrayLength = numberArray.Length;

            for (int i = 0; i < numberArrayLength - 1; i++)
            {
                for (int j = i + 1; j < numberArrayLength; j++)
                {
                    int difference = Math.Abs(numberArray[i] - numberArray[j]);
                    if (difference < dmin)
                    {
                        dmin = difference;
                    }
                }
            }

            return dmin;
        }

        static void Main(string[] args)
        {
            /*
            int[] numberinos = { 1, 6, 88, 72, 41, 9, 51, 31 };
            int dmin = MinDistance(numberinos);
            Console.WriteLine("The minimum distance is: {0}", dmin);

            Console.WriteLine();
            */

            int[] binaryArray = {1, 1, 0, 1, 0, 1};
            Console.WriteLine(BinaryToDecimal(binaryArray));


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("SORTED LIST TESTING");


            Console.WriteLine("Initial list");
            SortedList list = new SortedList(99);
            int[] numberinos = { 1, 6, 88, 72, 41, 9, 51, 31 };
            list.UpdateList(numberinos);
            list.WriteList();

            Console.WriteLine();
            Console.WriteLine("Insert Test");
            int insertNumber = 7;
            Console.WriteLine("Insert: {0}", insertNumber);

            list.Insert(insertNumber);
            list.WriteList();

            Console.WriteLine();
            Console.WriteLine("Delete Test");
            int deletePos = 3;
            Console.WriteLine("Delete position: {0}", deletePos);

            list.Delete(deletePos);
            list.WriteList();

            Console.WriteLine();
            Console.WriteLine("Search Test");
            int search = 31;
            Console.WriteLine("Searching for: {0}", search);
            int searchResult = list.Search(search);
            Console.WriteLine(searchResult);

            Console.WriteLine();
            Console.WriteLine("IsEmpty Test");
            Console.WriteLine(list.IsEmpty());

            Console.WriteLine();
            Console.WriteLine("IsFull Test");
            Console.WriteLine(list.IsFull());

            Console.WriteLine();
            Console.WriteLine("Clear Test");
            list.ClearList();
            list.WriteList();
            Console.WriteLine("End");
        }
    }
}