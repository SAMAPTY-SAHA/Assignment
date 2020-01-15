using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    interface RuiInterface
    {
         void add(RuiFishType ruiFishType);

        List<RuiFishType> getRuiall();

         void remove(int x);

    }
}
