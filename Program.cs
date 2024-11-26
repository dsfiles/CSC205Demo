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
    }
}