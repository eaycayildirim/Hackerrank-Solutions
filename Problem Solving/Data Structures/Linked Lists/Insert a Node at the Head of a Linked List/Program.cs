using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace InsertANodeAtTheHeadOfALinkedList
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
        static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data)
        {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
            if (llist != null)
                newNode.next = llist;

            return newNode;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@"C:\Users\Sabreden Derviş\Masaüstü");

            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                SinglyLinkedListNode llist_head = insertNodeAtHead(llist.head, llistItem);
                llist.head = llist_head;
            }

            PrintSinglyLinkedList(llist.head, "\n", textWriter);
        }
    }
}
