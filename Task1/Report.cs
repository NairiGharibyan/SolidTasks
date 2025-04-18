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
        public void SaveToFile(string path)
        {
            System.IO.File.WriteAllText(path, Content);
        }
        public void Print()
        {
            Console.WriteLine($"--- {Title} ---\n{Content}");
        }
    }
    //Report classum xaxtvum e solidi "Single Responsibility" principy. "One class - One job - One reason to change". aysinqn ayn vor classy petq e mek gorcaruyt irakanacni - tvyal depqum aydpes che. 
    //report classum miajamanak pahvum en ev bolor tvyalnery, ev ayn metodnery voronq ashxatum en  dranc het. aystex Report clasy karox e unenal tarber patjarner popoxvelu hamar,
    //orinak print methody poxelu hamar petq e dimenq amboxj report dasin, ev tvyal methody poxelu ardjwunqwum karox e ha8k arajanal kargavorel naev tvyal clasi ayld
    //andamnery,inchy hangecnum e xndirneri. Sranic xusapelu hamar harkavor e bajanel report klasy mi qani klasneri yst pahanjvox gorcaruytneri. 
    public class Reeport
    {
        public string Title { get; set; }
        public string Content { get; set; }

    }
    public class ReportSave
    {
        public void Save(Reeport report , string path)
        {
            System.IO.File.WriteAllText($"{path}", report.Content);
        }
    }
    public class ReportPrint 
    { 
        public void Print(Reeport report) 
        {
            Console.WriteLine($"--- {report.Title} ---\n{report.Content}");
        }
    }
}

