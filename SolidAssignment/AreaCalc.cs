using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidAssignment
{
    //main class
    public class AreaShapeCalculator
    {
        public double Calculator(List<double> shapeList)
        {
            double totalarea = 0;
            // suming up the shape areas
            foreach (var area in shapeList)
            {
                totalarea += area;
            }
            return totalarea;
        }
        
    }
}

