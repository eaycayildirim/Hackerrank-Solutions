﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace DeleteANode
{
    class Solution
    {

        class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                }

                this.tail = node;
            }
        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
        {
            while (node != null)
            {
                textWriter.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    textWriter.Write(sep);
                }
            }
        }

        static SinglyLinkedListNode deleteNode(SinglyLinkedListNode llist, int position)
        {
            SinglyLinkedListNode temp = llist;
            int count = 0;
            if(position == 0)
            {
                temp = temp.next;
                return temp;
            }
            while (count != position-1)
            {
                count++;
                temp = temp.next;
            }
            temp.next = temp.next.next;
            return llist;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@"C:\Users\Sabreden Derviş\Masaüstü");

            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            int position = Convert.ToInt32(Console.ReadLine());

            SinglyLinkedListNode llist1 = deleteNode(llist.head, position);

            PrintSinglyLinkedList(llist1, " ", textWriter);
            textWriter.WriteLine();
        }
    }
}
