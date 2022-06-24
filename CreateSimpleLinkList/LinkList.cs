﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinkListAss
{
    public class LinkList
    {
      
            public Node Head;
            public Node Tail;
            public LinkList()
            {
                Head = null;
                Tail = null;
            }

            public void AddNode(Node node)
            {
                if (Head == null && Tail == null)
                {
                    Head = node;
                    Tail = node;
                }
                else
                {
                    node.next = Head;
                    Head = node;
                }
            }
        }
    }

