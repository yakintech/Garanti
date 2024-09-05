using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Models
{
    public abstract class SystemReports
    {
        public void CalcTax()
        {
            Console.WriteLine("Calculating tax");
        }

        public void CalculatePersonalAllowance()
        {
            Console.WriteLine("Calculating personal allowance");
        }

        public void CalculateNationalInsurance()
        {
            Console.WriteLine("Calculating national insurance");
        }


        public abstract void ExportReport();

        public void GenerateReport()
        {
            CalcTax();
            CalculatePersonalAllowance();
            CalculateNationalInsurance();
            ExportReport();
        }
    }
}
