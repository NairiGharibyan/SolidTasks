using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTask1.InnerClass
{
    public class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
    public class ReportPrinter
    {
        public void Print(Report report)
        {
            Console.WriteLine($"--- {report.Title} ---\n{report.Content}");
        }
    }
    public class ReportSaver
    {
        public void SaveToFile(Report report, string path)
        {
            System.IO.File.WriteAllText(path, report.Content);
        }
    }

    // aystex Solid Violance chka, cragiry himnvace Single Responsibilty skzbunqi vra ev amen inch kargin e
}

