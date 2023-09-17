using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using AstroMaths;

namespace ConsoleAstroServer
{
    internal class AstroServerImplementation : IAstroContract
    {
        ClassAstroMaths math = new ClassAstroMaths();
        public double GetStarVelocity(double x, double y)
        {
            //double result = AstroMath.ClassAstroMath.StarVelocity(x, y);
            //Console.WriteLine(result);
            //return result;
            return math.StarVelocity(x, y);
        }

        public double GetStarDistance(double x)
        {
            return math.StarDistance(x);
        }

        public double GetTempKelvin(double x)
        {
            return math.TempKelvin(x);
        }

        public double GetSchRadius(double x)
        {
            return math.EventHorizon(x);
        }
    }
}
