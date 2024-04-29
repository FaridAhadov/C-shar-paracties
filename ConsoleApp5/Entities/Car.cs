using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Entities
{
    internal class Car
    {
        public string marka;
        public string model;
        public int istehsalIli;

        public Car(string marka, string model, int istehsalIli)
        {
            this.marka = marka;
            this.model = model;
            this.istehsalIli = istehsalIli;
        }
    }
}
