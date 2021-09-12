using System;
using static BTreeDraft.Btree;

namespace BTreeDraft
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
                BTree b = new BTree(2);
                b.Insert(1);
                b.Insert(2);
                b.Insert(3);
                b.Insert(11);
                b.Insert(15);
                b.Insert(20);
                b.Insert(17);
            b.Insert(4);
            b.Insert(9);
            b.Insert(10);
            b.Insert(14);
            b.Insert(15);
            b.Insert(25);
            b.Insert(47);



            b.Show();

                if (b.Contain(12))
                {
                    Console.WriteLine("\nfound");
                }
                else
                {
                    Console.WriteLine("\nnot found");
                }
              
            
        }

    }
}
