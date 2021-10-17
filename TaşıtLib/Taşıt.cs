using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaşıtLib
{
    public class Taşıt 
    {

        private string marka;
        private string model;
        private string renk;

        public string Marka { get => marka; set => marka = value.ToUpper(); }
        public string Model { get => model; set => model = value.ToUpper(); }
        public string Renk { get => renk; set => renk = value; }

    }
}
