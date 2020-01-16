using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class IlishFishType : Fish
    {
        public string Ilishname;
        public string Ilishweight;

        private IlishFishType()
        {

        }
        public IlishFishType(string ilishname, string ilishweight)
        {
            this.Ilishname = ilishname;
            this.Ilishweight = ilishweight;
        }
    }
}
