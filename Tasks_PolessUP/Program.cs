using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_PolessUP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tasks task = new Tasks();
            task.Task_1();

            int[] nums = new int[4] {8, 5, 1, 15};
            int target = 9;
            int[] index = task.Task_2(nums, target);
            Console.WriteLine("[" + index[0] + "," + index[1] + "]");


            Console.ReadLine();
        }
    }
}
