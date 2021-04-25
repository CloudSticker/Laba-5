using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_5
{
    class Currency
    {
        public double RUR
        {
            get { return rur; }
            set { rur = value * 1.0; }
        }

        private double rur;


        public double EUR
        {
            get { return eur; }
            set { eur = Math.Round(value / 90.64, 4); }
        }

        private double eur;

        public double GBP
        {
            get { return gbp; }
            set { gbp = Math.Round(value / 103.98, 4); }
        }

        private double gbp;
    }
}
