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

    }
}

