using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab_113_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

    }

    public class Array_List
    {
        public int arrayListMethod(int a, int b, int c, int d)
        {

            int[] numberArray = new int[] { a, b, c, d };

            //Move items to a list and add 1 (integer)
            Queue<int> numberQueue = new Queue<int>();

            foreach (var item in numberArray)
            {
                numberQueue.Enqueue(item * 2);
            }

            Stack<int> numberStack = new Stack<int>();

            foreach (var item in numberQueue)
            {
                numberStack.Push(item * 2);
            }

            Dictionary<int, int> numberDict = new Dictionary<int, int>();

            for (int i = 0; i < 4; i++)
            {
                int item = numberStack.Pop();
                numberDict.Add(i, (item * item));
            }
            int total = 0;

            ArrayList numberArrayList = new ArrayList();

            foreach (var item in numberDict)
            {
                numberArrayList.Add(item.Value);
            }

            foreach (var item in numberArrayList)
            {
                total += (int)item;
            }
            return total;

            

            //Accepts 4 integers
            //put to ARRAY
            //extract --> double --> put to QUEUE
            //extract --> double --> put to STACK
            //extract --> square --> put to DICTIONARY
            //put to ARRAYLIST
            //extract and get the sum of the items and return this sum.
        }

    }
}
