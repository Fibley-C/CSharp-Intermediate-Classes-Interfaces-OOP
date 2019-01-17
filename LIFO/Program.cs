using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFO
{
    public class Stack
    {
        private List<object> StackList = new List<object>();

        public void Push (object obj)
        {
            if (obj is null)
            {
                throw new InvalidOperationException("Null was passed to the stack!");
            }
            StackList.Add(obj);
        }

        public object Pop()
        {
            if (StackList.Count != 0)
            {
                var last = StackList.Last();
                StackList.Remove(last);
                return last;
            }
            throw new InvalidOperationException("Cannot pop object to Stack as it is empty!");
        }

        void Clear()
        {
            if (StackList.Count != 0)
            {
                StackList.Clear();
            }
            throw new InvalidOperationException("Stack is currently empty!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
