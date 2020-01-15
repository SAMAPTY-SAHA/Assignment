using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    interface KatlaInterface
    {
        void add(KatlaFishType katlaFishType);

        List<RuiFishType> getRuiall();

        void remove(int x);
    }
}
