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


            Link.AddNode(node1);
            Link.AddNode(node2);
            Link.AddNode(node3);
            Link.AppendNode(node4);

            Link.Display();



        }
    }
}