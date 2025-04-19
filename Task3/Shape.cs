using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTask1.InnerClass
{
    public class Violate_Shape
    {
        public string Type { get; set; }
    }
    public class AreaCalculator
    {
        public double CalculateArea(Violate_Shape shape)
        {
            if (shape.Type == "Circle")
                return 3.14 * 5 * 5; // Hardcoded radius
            else if (shape.Type == "Square")
                return 5 * 5; // Hardcoded side
            else
                throw new Exception("Shape not supported");
        }
    }

    //Tvyal cragrum Xaxtvac e "Open / Closed" skzbunqy(Open for extension, Close for Modification). Ete Shape-i mej avelacnenq ayl tesak, hark klini naev
    //AreCalculator classum popuxutyunner katarel ` if mej avelacnel ayl payman, isk sa hakasum e "Open/Close skzbunqin. Petq e tvyal cragiry dzevapoxenq aynpes vor inch vor ban
    //avleacneluc hark chlini poxel arden grvac kody. Aysinqn petq e abstrakciayi gaxapar avelacnel kodum, inchpes naev avtomat kerpov ogtagorcum enq Polymorphism.

    public abstract class Shape 
    {
        public abstract double Calculate_Area();
    }
    public class Circle : Shape
    {
        public double Radius { get; set; } = 5;

        public override double Calculate_Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Square : Shape 
    {
        public double SideLength { get; set; } = 5;
        public override double Calculate_Area() 
        {
            return SideLength * SideLength;
        }
    }
    //asytex arden ayl Shapei makeresy hashvelu hamar parzapes avelacnelu enq ayl klas vory kirakanacni da aranc base cragiry popoxelu(Open for Extension, Close for Modification)
}

