using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_PolessUP
{
    public class Tasks
    {
        public void Task_1()
        {
            Console.WriteLine("Task 1: \n");

            Console.WriteLine(" +\"\"\"\"\"+");
            Console.WriteLine("(| o o |)");
            Console.WriteLine(" |  ^  |");
            Console.WriteLine(" | '-' |");
            Console.WriteLine(" +-----+");
        }
        public int[] Task_2(int[] arrayNums, int target)
        {
            Console.WriteLine("\nTask 2: ");

            int[] index = new int[2];
            for (int i = 0; i < arrayNums.Length; i++)
            {
                for (int j = i + 1; j < arrayNums.Length - 1; j++)
                {
                    if (arrayNums[i] + arrayNums[j] == target)
                    {
                        index[0] = i;
                        index[1] = j;
                        return index;
                    }
                }
            }
            Console.WriteLine("no value");
            return index;

        }
        public int Task_3(int[] array, int target)
        {
            List<int> listSort = array.ToList();
            listSort.Sort();
            int[] arraySort = listSort.ToArray();
            for (int i = 0; i < arraySort.Length; i++)
            {
                if (arraySort[i] == target)
                {
                    return i;
                }
            }
            for (int i = 0; i < arraySort.Length; i++)
            {
                for (int j = 0; j < arraySort.Length; j++)
                {
                    if (target - i == arraySort[j])
                    {
                        return j + 1;
                    }
                }
            }
            if (target <= 0)
            {
                return 0;
            }
            return arraySort.Length;
        }

        public int Task_4(int[] nums)
        {
            List<int> listSort = nums.ToList();
            listSort.Sort();
            int[] arraySort = listSort.ToArray();
            return arraySort[arraySort.Length - 3];
        }
        public int Task_5(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == nums.Max())
                {
                    return i;
                }
            }
            return 0;
        }

    }
}
