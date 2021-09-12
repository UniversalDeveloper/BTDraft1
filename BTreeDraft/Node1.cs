using System;
using System.Collections.Generic;
using System.Text;

namespace BTreeDraft
{
    class Node1
    {
        public int size;
        public int[] data;
        public Node[] children;
        public int countDataInNode = 0;
        public bool leaf;

        public Node1(int size)
        {
            this.size = size;
            data = new int[size];
            children = new Node[size + 1];
            leaf = true;
        }

        public bool findInNode(int value)
        {
            for (int i = 0; i < countDataInNode; i++)
            {
                if (value == data[i])
                    return true;
                if (value < data[i])
                    return !leaf && children[i].findInNode(value);
            }
            return !leaf && children[countDataInNode].findInNode(value);
        }
    }
}
