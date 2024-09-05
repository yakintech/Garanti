using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Models
{
    internal class PDFReport : SystemReports
    {
        public override void ExportReport()
        {
            Console.WriteLine("Exporting PDF report");
        }
    }
}
