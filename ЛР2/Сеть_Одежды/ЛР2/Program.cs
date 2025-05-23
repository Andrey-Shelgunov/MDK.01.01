﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    class Program
    {
        static void Main(string[] args)
        {
            SaleList report = new SaleList();
            report.AddSale(new Sales(1, new Things("Сумка", 1500, 12, Vid_Clot.Badidas)));
            report.AddSale(new Sales(1, new Things("Футболка", 1700, 6, Vid_Clot.Mike)));

            report.AddSale(new Sales(2, new Things("джинсы", 2000, 8, Vid_Clot.Moika_gobana)));
            report.AddSale(new Sales(2, new Things("Штаны", 1000, 5, Vid_Clot.Zuma)));

            report.AddSale(new Sales(3, new Things("джемпер", 350, 13, Vid_Clot.Zalenciaga)));
            report.AddSale(new Sales(3, new Things("кепка", 500, 9, Vid_Clot.Atone_Zisland)));



            int reportType;
            Console.WriteLine("Выберите вид отчёта (1 - весь, 2 - по видам): ");
            reportType = Convert.ToInt32(Console.ReadLine());
            if (reportType == 1)
            {
                report.PrintReportAll();
            }
            else if (reportType == 2)
            {
                report.PrintReportPerGenre();
            }
            else
            {
                Console.WriteLine("Введено неверное значение");
            }
        }
    }
}
