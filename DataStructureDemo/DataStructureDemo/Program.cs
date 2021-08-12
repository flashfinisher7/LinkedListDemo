using System;

namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList Demo Problem");
            LinkedList List = new LinkedList();
            List.Add(56);
            //List.Add(67);
            List.Add(70);
            List.Display();
            List.InsertAtParticularPosition(2, 30);
        }
    }
}
