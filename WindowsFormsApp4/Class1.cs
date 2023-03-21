using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    internal class Conversor
    {
        public string Conversao(string c, string v)
        {
            double cot = double.Parse(c);
            double valor = double.Parse(v);
            double r = (valor / cot);
            return r.ToString();
        }   
    }
}
