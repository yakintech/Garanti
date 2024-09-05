using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Models
{
    public class XMLReport : SystemReports
    {
        public override void ExportReport()
        {
            Console.WriteLine("Exporting XML report");
        }

    }
}
