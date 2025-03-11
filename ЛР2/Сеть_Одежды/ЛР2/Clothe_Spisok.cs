using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    public class Clothes_spisok
    {
        private double price;
        private string name;

        public void Setnames(string M)
        {
            name = M;
        }
        public string getvaluesstring()
        {
            return name;
        }
        public void Setprice(double P)
        {
            price = P;
        }
        public Clothes_spisok(double MOR, string POK)
        {
            price = MOR;
            name = POK;
        }
    }
}