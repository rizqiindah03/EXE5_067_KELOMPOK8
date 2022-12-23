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
            pratiwi.next = newnode;
        }
        public void delete()
        {
            if (indah == null)
            {
                Console.WriteLine("tidak ada data didalam antrian");
                return;
            }
            Console.WriteLine("data yang dihapus " + indah.name);
            Console.ReadKey();
            indah = indah.next;
            if (indah == null)
                pratiwi = null;
        }
        public void display()
        {
            if (indah == null)
            {
                Console.WriteLine("tidak ada data dalam antrian");
                return;
            }
            Node display;
            for (display = indah; display != null; display = display.next) ;

        }
    }
}
