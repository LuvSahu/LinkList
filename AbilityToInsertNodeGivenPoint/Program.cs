﻿using LinkListAss;

namespace LinkedListAss
{
    public class Program
    {
        public static void Main(String[] args)
        {

            LinkList Link = new LinkList();
            Node node1 = new Node(70);
            Node node2 = new Node(56);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(95);


            //Link.AddNode(node1);
            //Link.AddNode(node2);
            //Link.AddNode(node3);
            //Link.AppendNode(node4);

            //Link.InsertNode(node5, node2);
            //Link.Display();

            //Link.DeleteNodeAtFirst();
            //Link.Display();

            //Link.DeleteNodeAtLast();
            //Console.WriteLine("\n Delete at node at last");
            //Link.Display();

            //Console.WriteLine("\n");
            //Console.WriteLine( Link.Search(2));

            Link.AppendNode(node2);
            Link.AppendNode(node3);
            Link.AppendNode(node1);
            Link.InsertNode(node4, node3);
            Link.Display();





        }
    }
}