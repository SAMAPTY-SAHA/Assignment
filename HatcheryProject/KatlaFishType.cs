using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class KatlaFishType
    {
        public string katlaname;
        public string katlaweight;

        private KatlaFishType()
        {

        }
        public KatlaFishType(string katlaname, string katlaweight)
        {
            this.katlaname = katlaname;
            this.katlaweight = katlaweight;
        }

    }
}
