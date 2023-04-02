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
            Console.WriteLine("\nTask 2: \n");
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
    }
}
