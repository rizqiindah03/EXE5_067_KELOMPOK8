using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_067_KELOMPOK8
{
    class Node
    {
        public string name;
        public Node next; 
        
        public Node (string i, Node n)
        {
            name = i;
            next = n;
        }
    }
    class Queue
    {
        Node indah, pratiwi;
        public Queue()
        {
            indah = pratiwi = null;
        }
        public void enter()
        {
            string data;
            Node newnode = new Node();
            Console.Write("Masukkan input : ");
            data = Console.ReadLine();
            newnode.name = data;
            newnode.next = null;
            if (indah == null)
            {
                indah = newnode;
                pratiwi = newnode;
                return;
            }

        }
            
    }
}
