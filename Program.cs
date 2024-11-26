using System;

public class Node
{
    public Node Next;
    public Node Prev;
    public int Value;
    public Node(int value) { 
        Value = value;
        Next = null;
        Prev = null;
    }
    public Node(int value, Node prev) {
        Value = value;
        Prev = prev;
    }
}
public class Program { 
    public static void Main()
    {
        //Node node1 = new Node(2);
        Node head = new Node(2);

        //Node node2 = new Node(3);
        head.Next = new Node(3, head);

        //Node node3 = new Node(4);
        head.Next.Next = new Node(5, head.Next);
        
        //Node tail = node3;
      
        //head.Next = node2;
        //node2.Prev = head;
        //node2.Next = node3;
        //node3.Prev = node2;

        Print(head, "Original list: ");
        //// create a new node called node4, insert it between nodes 2 and 3
        //Node node4 = new Node(5);
        //node4.Prev = node2;
        //node4.Next = node3;
        //node2.Next = node4;
        //node3.Prev = node4;

        //Print(head, "After insertin a new node: ");

        //// remove the second node (node 2 with value 3)
        //// your code here
        //head.Next = node4;
        //node4.Prev = head;

        //Print(head, "After linking out node2: ");

    }
    public static void Print(Node iterator, string msg)
    {
        Console.Write(msg);
        while (iterator != null)
        {
            Console.Write(iterator.Value + " ");
            iterator = iterator.Next;
        }
        Console.WriteLine();
    }
}