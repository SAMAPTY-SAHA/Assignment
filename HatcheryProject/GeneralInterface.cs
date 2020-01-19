using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    interface GeneralInterface<T> where T : Fish
    {
        void add(T obj);

        List<T> getall();

        void remove(String objname,int x);
    }
}
