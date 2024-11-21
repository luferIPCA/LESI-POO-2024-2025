using System;
using System.Collections;
using System.Text;

namespace MyCollections
{

    class MySortedList
    {
        public SortedList st;
        const int CAPACITY = 100;


        public MySortedList()
        {
            st = new SortedList(CAPACITY);
        }

        public MySortedList(int n)
        {
            if (n > CAPACITY) n = CAPACITY;
            st = new SortedList(n);
        }

    }
    }
