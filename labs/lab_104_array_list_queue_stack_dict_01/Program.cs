using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_104_array_list_queue_stack_dict_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Put 10 numbers in an array
            int[] numberArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Move items to a list and add 1 (integer)
            List<int> numberList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                numberList.Add(numberArray[i] + 1);

            }

            //Move to a stack and add 1

            Stack<int> numberStack = new Stack<int>();

            for (int i = 0; i < 10; i++)
            {
                numberStack.Push(numberList[i] + 1);
            }


            //Move to a queue and add 1

            Queue<int> numberQueue = new Queue<int>();

            for (int i = 0; i < 10; i++)
            {
                numberQueue.Enqueue(numberStack.Pop() + 1);
            }

            //Move to dictionary and add 1

            Dictionary<int, int> numberDict = new Dictionary<int, int>();
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                numberDict.Add(i, (numberQueue.Dequeue() + 1));
                
            }
            for (var i = 0; i < numberDict.Count; i++)
            {
                total += numberDict[numberDict.Keys.ElementAt(i)];
            }
            Console.WriteLine(total);


            //Return total
        }
    }
}
