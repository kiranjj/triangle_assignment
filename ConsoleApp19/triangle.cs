using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleA2
{
    public static class TriangleSolver
    {
        enum TriangleType
        {
            Equilateral, Isosceles, Scalene, NotValid
        }
        public static string ReportTringle(int side1, int side2, int side3)
        {
            string str_TriangleType = "";
            if (side1 == side2 && side2 == side3)
            {
                str_TriangleType = TriangleType.Equilateral.ToString();
            }
            else if (side1 == side2 || side2 == side3 || side3 == side1)
            {
                str_TriangleType = TriangleType.Isosceles.ToString();
            }
            else
            {
                str_TriangleType = TriangleType.Scalene.ToString();
            }
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                str_TriangleType = TriangleType.NotValid.ToString();
            }
            return str_TriangleType;
        }
    }
}

