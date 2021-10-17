using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaşıtLib
{
    public class Araba : Taşıt
    {
        private int vitessayisi;

        public int Vitessayisi { get => vitessayisi; set => vitessayisi = value; }
    }
}
