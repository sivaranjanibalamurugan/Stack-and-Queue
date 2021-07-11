using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
  
    public class StackNode<T>
    {
         public T value;
         public StackNode<T> Next;
        public StackNode(T value)
        {
            this.value = value;
            this.Next = null;
        }
    }
    public class Stack<T>
    {
        public StackNode<T> top;

        public void Push(T value)
        {
            StackNode<T> stackNode = new StackNode<T>(value);
            // to check the top element
            if (top == null)
            {
                top = stackNode;
            }
            else
            {
                stackNode.Next = top;
                top = stackNode;
            }
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("No element to pop");
            }
            else
            {
                top = top.Next;
            }
        }
        //returns the top element of the stack
        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("No element to peek");
                return;
            }
            Console.WriteLine("the top element is {0}", top.value);
        }
        //display method
        public void display()
        {
            if (top == null)
            {
                Console.WriteLine("No element in stack");
            }
            else
            {
                StackNode<T> temp = top;
                while (temp != null)
                {
                    Console.WriteLine("{0}", temp.value);
                }
            }
        }

    }
}

