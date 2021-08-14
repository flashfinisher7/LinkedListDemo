using System;

namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList Demo Problem");
            LinkedListQueue List = new LinkedListQueue();
            LinkedList List1 = new LinkedList();
            LinkedListStack List2 = new LinkedListStack();
            List2.peek();
            List2.pop();
            List2.Display();
            
            List.Enqueue(56);
            List.Enqueue(67);
            List.Enqueue(70);
            //List1.Add();
            
            List1.InsertAtParticularPosition(2, 30);
            List1.Display();


        }
    }
}
