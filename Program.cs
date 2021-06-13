using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Stack_By_Me
{
    class Program
    {
        static void Main(string[] args)
        {

            string n = Console.ReadLine();
            if (IsBalnced(n))
            {
                Console.WriteLine("is Balnced");
                return;
            }
            else
            {
                Console.WriteLine(" not Balnced");
            }
            //StackByArray<int> m = new StackByArray<int>();
            //Console.WriteLine( m.GetLenght());
        }
        public static bool arePair(char open,char close)
        {
            if (open == '{' && close == '}')
                return true;
            else if (open == '(' && close == ')')
                return true;
            else if (open == '[' && close == ']')
                return true;
            return false;
        }

        static bool IsBalnced(string exp)
        {
            StackByArray<char> n = new StackByArray<char>();
          
            for (int i = 0; i <exp.Length; i++)
            {
                if (exp[i]=='{'||exp[i]=='['||exp[i]=='(')
                {
                    n.Push(exp[i]);
                }
                else if (exp[i] == '}' || exp[i] == ']' || exp[i] == ')')
                {
                    if (n.isEmpty()||!arePair(n.GetTop(),exp[i]))
                    {
                        return false;
                        
                        
                    }
                    else
                    {
                        n.Pop();
                    }
                }
            }
            return n.isEmpty();
        }
    }
    class StackByArray<T>
    {
        int top;
        char[] arr;
        public int size = 100;
      
      
        public StackByArray()
        {
            top = -1;
      arr  = new char[size];
        }
        public void Push(char Value)
        {
            if (isFull())
            {
                Console.WriteLine("Stack Is Full To Add");
                return;
            }
            top++;
            arr[top] = Value;

        }
        public void Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("The Stack Is Empty");
                return;
            }
            top--;
            
        }
        public void Pop_Return(ref char Value)
        {
            if (isEmpty())
            {
                Console.WriteLine("The Stack Is Empty");
                return;
            }
            
            Value = arr[top];
           
            Console.WriteLine(Value);
            top--;
        }
       
        
        public void Print()
        {
            if (isEmpty())
            {
                Console.WriteLine("The Stack Is Empty");
                return;
            }
            Console.Write("[");
            for (int i =top; i >=0; i--)
            {
                Console.Write(arr[i]+ " ");
            }
            Console.Write("]");
        }
        public bool isFull()
        {
            if (top==arr.Length-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEmpty()
        {
            if (top<0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetLenght()
        {
            return size;
        }

        public char GetTop()
        {
            if (isEmpty())
            {
                Console.WriteLine("The Stack Is Empty");
                return ' ';
            }

           return (char)arr[top];
        }
    }
}
