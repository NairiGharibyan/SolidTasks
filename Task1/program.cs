using SolidTask1.InnerClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTask1
{
    public  class Program
    {
        static void Main(string[] args)
        {

            ReportSave saver = new ReportSave();
            saver.Save(new Reeport(), null);

            ReportPrint rep_print = new ReportPrint();
            rep_print.Print(new Reeport());
            
            Console.Read();
        }
    }
}

