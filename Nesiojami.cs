using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktinis2._2
{
    class Nesiojami : Item
    {
        private string CPU;
        private string VaizdoPlokste;
        private string Atmintis;
        public void SetCPU(string CPU)
        {
            this.CPU = CPU;
        }
        public string GetCPU()
        {
            return CPU;
        }
        public void SetVaizdoPlokste(string VaizdoPlokste)
        {
            this.VaizdoPlokste = VaizdoPlokste;
        }
        public string GetVaizdoPlokste()
        {
            return VaizdoPlokste;
        }
        public void SetAtmintis(string Atmintis)
        {
            this.Atmintis = Atmintis;
        }
        public string GetAtmintisU()
        {
            return Atmintis;
        }
    }
}
