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
        public string Task_6(double num)
        {
            string[] numWords = new string[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "point" };

            string numString = num.ToString();
            string answer = "";

            for (int i = 0; i < numString.Length; i++)
            {
                if (numString[i] != '.' && numString[i] != ',')
                {
                    answer += numWords[Convert.ToInt32(numString[i].ToString())] + " ";

                }
                else
                {
                    answer += numWords[10] + " ";
                }
            }

            return answer;

        }

        public int Task_7(int num)
        {
            string numString = num.ToString();
            int[] numArray = new int[numString.Length];
            for (int i = 0; i < numString.Length; i++)
            {
                numArray[i] = Convert.ToInt32(numString[i].ToString());
            }
            int max = numArray.Max();
            int buff;
            for (int i = 1; i < numArray.Length; i++)
            {
                if (max == numArray[i])
                {
                    buff = numArray[i - 1];
                    numArray[i - 1] = max;
                    numArray[i] = buff;
                    numString = "";
                    for (int j = 0; j < numArray.Length; j++)
                    {
                        numString += numArray[j].ToString();

                    }
                    int answer = Convert.ToInt32(numString);
                    return answer;
                }
            }
            return 0;
        }
        public string Task_8(string colorRGB)
        {
            colorRGB = colorRGB.Replace('(', ' ');
            colorRGB = colorRGB.Replace(')', ' ');
            string[] colorRGBstring = colorRGB.Split(',');
            int[] colorRGBint = new int[colorRGBstring.Length];
            string hex = "";
            for (int i = 0; i < colorRGBstring.Length; i++)
            {
                colorRGBint[i] = Convert.ToInt32(colorRGBstring[i]);
                if (colorRGBint[i] > 255)
                {
                    colorRGBint[i] = 255;
                }
                if (colorRGBint[i] < 0)
                {
                    colorRGBint[i] = 0;
                }
                hex += colorRGBint[i].ToString("X2");
            }
            return hex;
        }

        public bool Task_9(int year)
        {
            bool answer;
            if (year % 4 == 0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            return answer;
        }

    }
}
