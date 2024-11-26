using System;

public class Node
{
        public Node Next;
        public Node Prev;
        public int Value;
}

public class Program { 
    public static void Main()
    {
        Node node1 = new Node();
        Node node2 = new Node();
        Node node3 = new Node();
        Node head = node1;
        Node tail = node3;
        node1.Value = 2;
        node2.Value = 3;
        node3.Value = 4;

        //node1.Prev = head;
        //node3.Next = tail;

        node1.Next = node2;
        node2.Prev = node1;
        node2.Next = node3;
        node3.Prev = node2;

        //Console.WriteLine(head.Value);
        //Console.WriteLine(head.Next.Value);
        //Console.WriteLine(head.Next.Next.Value);




        

        Node iterator = head;
        while (iterator != null)
        {
            Console.Write(iterator.Value + " ");
            iterator = iterator.Next;
        }
        Console.WriteLine();

        iterator = tail;
        while (iterator != null)
        {
            Console.Write(iterator.Value + " ");
            iterator = iterator.Prev;
        }
        Console.WriteLine();

        Console.WriteLine(head.Next.Next.Prev.Next.Value);
        Console.WriteLine(tail.Prev.Prev.Next.Value);

    }
}