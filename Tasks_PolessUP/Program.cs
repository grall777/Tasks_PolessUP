
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
            int[] indicesArray = task.Task_2(nums, target);
            Console.WriteLine("[" + indicesArray[0] + "," + indicesArray[1] + "]");

            int[] array = new int[] { 1, 3, 5, 6 };
            int index = task.Task_3(array, 5);
            Console.WriteLine("\nTask 3: \nIndex: " + indicesArray);


            int answer = task.Task_4(array);
            Console.WriteLine("\nTask 4: \nAnswer: " + answer);

            answer = task.Task_5(array);
            Console.WriteLine("\nTask 5: \nAnswer: " + answer);

            string answerString;
            answerString = task.Task_6(21.13);
            Console.WriteLine("\nTask 6: \nAnswer: " + answerString);

            answer = task.Task_7(2017);
            Console.WriteLine("\nTask 7: \nAnswer: " + answer);

            answerString = task.Task_8("(255, 255, 255)");
            Console.WriteLine("\nTask 8: \nAnswer: " + answerString);

            bool answerBool = task.Task_9(2015);
            Console.WriteLine("\nTask 9: \nAnswer: " + answerBool);

            answer = task.Task_10(2, 3, 5);
            Console.WriteLine("\nTask 10: \nAnswer: " + answer);


            Console.ReadLine();
        }
    }
}
