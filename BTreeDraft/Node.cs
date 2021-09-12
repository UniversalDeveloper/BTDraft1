using System;
using System.Collections.Generic;
using System.Text;

namespace BTreeDraft
{
    class Node
    {
        public static int T =2;
        public int n;
       public  int[] key = new int[2 * T - 1];
       public  Node []child = new Node[2 * T];
       public bool leaf = true;

        public int Find(int k)
        {
            for (int i = 0; i < this.n; i++)
            {
                if (this.key[i] == k)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
