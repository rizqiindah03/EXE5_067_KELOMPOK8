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
            Console.WriteLine(display.name);
            Console.WriteLine("\n tekan enter untuk melanjutkan program ");
            Console.ReadKey();
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("menu");
                    Console.WriteLine(" 1. implement enter");
                    Console.WriteLine(" 2. implement delete");
                    Console.WriteLine(" 3. display values");
                    Console.WriteLine(" 4. exit");
                    Console.Write("\n enter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            Console.Clear();
                            q.enter();
                            break;
                        case '2':
                            Console.Clear();
                            q.delete();
                            break;
                        case '3':
                            Console.Clear();
                            q.display();
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine(" invalid option !");
                            }
                            break;
                    }
                }
               
            }
        }
    }
}
