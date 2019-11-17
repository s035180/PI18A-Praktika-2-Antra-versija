using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktinis2._2
{
    class Item
    {
        protected string pav;
        protected double kain;
        public Item()
        {
            pav = "";
            kain = 0;
        }
        public void SetPav(string pav)
        {
            this.pav = pav;
        }
        public string GetPav()
        {
            return pav;
        }
        public void SetKain(int kain)
        {
            this.kain = kain;
        }
        public double GetKain()
        {
            return kain;
        }
    }
}
