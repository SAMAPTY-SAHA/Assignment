using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    interface GeneralInterface<T> where T : Fish
    {
        void add(T obj);

        List<RuiFishType> getRuiall();

        void remove(String objname,int x);
    }
}
