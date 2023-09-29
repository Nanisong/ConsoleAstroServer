using AstroMaths;
//Author: Lan Song ID:30072745 26/9/2023 Murdoch
namespace ConsoleAstroServer
{
    internal class AstroServerImplementation : IAstroContract
    {
        ClassAstroMaths math = new ClassAstroMaths();
        public double GetStarVelocity(double x, double y)
        {
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
