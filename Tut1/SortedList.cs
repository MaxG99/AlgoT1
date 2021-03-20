using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut1
{
    class SortedList
    // Assume numbers in array are greater than 1.
    {
        private int[] numbers;
        private int capacity;
        private int count = 0;
        private int realStartingPos;

        public SortedList(int size)
        {
            capacity = size;
            numbers = new int[size];
            Count();
        }

        public void UpdateList(int[] list)
        {
            int listLength = list.Length;
            if (listLength > capacity)
            {
                listLength = capacity;
            }

            for (int i = 0; i < listLength; i++)
            {
                numbers[i] = list[i];
            }

            SortList();
            Count();
        }

        public void Insert(int num)
        {
            numbers[count] = num;
            SortList();
            Count();
        }

        public void Delete(int pos)
        {
            if (pos > capacity || pos < 0)
            {
                Console.WriteLine("Position is out of the bounds of the list");
                return;
            }

            numbers[realStartingPos + pos] = 0;
            SortList();
            Count();
        }

        public int Search(int item)
        {
            for (int i = realStartingPos; i < capacity; i++)
            {
                if (item == numbers[i])
                {
                    return i - realStartingPos;
                }
            }

            return -1;
        }

        private void Count()
        {
            count = 0;

            for (int i = 0; i < capacity; i++)
            {
                if (numbers[i] != 0)
                {
                    count++;
                }
            }

            realStartingPos = capacity - count;
        }

        private void SortList()
        {
            Array.Sort(numbers);
        }

        public void WriteList()
        {
            foreach (int element in numbers)
            {
                if (element != 0)
                {
                    Console.WriteLine(element);
                }
            }
        }
        public bool IsEmpty()
        {
            if (realStartingPos == capacity)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            if (realStartingPos == 0) {
                return true;
            } else
            {
                return false;
            }
        }

        public void ClearList()
        {
            for (int i = realStartingPos; i < capacity; i++)
            {
                numbers[i] = 0;
            }

            Count();
        }
    }
}
