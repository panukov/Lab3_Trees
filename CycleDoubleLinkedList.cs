using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Trees
{
    public class DoubleNode
    {
        private char info;
        private int key;
        private double next;
        private double prev;

        public char Info { get; set; }
        public int Key { get; set; }
        public DoubleNode Next { get; set; }
        public DoubleNode Prev { get; set; }

        public DoubleNode()
        {

        }

        public DoubleNode(char info, int key)
        {
            Info = info;
            Key = key;
        }

        public DoubleNode(char info, DoubleNode next, DoubleNode prev)
        {
            Info = info;
            Next = next;
            Prev = prev;
        }
    }

    public class CycleDoubleLinkList
    {
        private DoubleNode head;
        public CycleDoubleLinkList()
        {
            head = new DoubleNode();
            head.Next = head;
            head.Prev = head;
        }

        public void AddNode(char info, int key)
        {
            DoubleNode p = new DoubleNode(info, key);
            if (head.Next == head)
            {
                head.Next = p;
                head.Prev = p;
                p.Prev = head;
                p.Next = head;
            } 
            else
            {
                p.Next = head;   
                p.Prev = head.Prev;
                head.Prev.Next = p;
                head.Prev = p;
            }
        }

        public string PrintList()
        {
            string result = "";
            DoubleNode p = head.Next;
            int i = 0;

            while(p != head)
            {
                i++;
                result += i.ToString() +  ". Информационное поле: " + p.Info.ToString() + "\n";
                result += i.ToString() + ". Ключ:" +  p.Key.ToString() + "\n";

                p = p.Next;
            }

            return result;
        }

        public void DisplayInDataGridView(DataGridView grid)
        {
            grid.Rows.Clear();

            int index = 1;
            DoubleNode p = head.Next;

            while (p != head)
            {
                grid.Rows.Add(index.ToString(), p.Key.ToString(), p.Info.ToString());
                index++;
                p = p.Next;
            }
        }

        public void Clear()
        {
            head.Next = head;
            head.Prev = head;
        }
    }
}
