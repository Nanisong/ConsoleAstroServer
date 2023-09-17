using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAstroServer
{
    [ServiceContract]
    internal interface IAstroContract
    {
        [OperationContract]
        double GetStarVelocity(double x, double y);
        [OperationContract]
        double GetStarDistance(double x);
        [OperationContract]
        double GetTempKelvin(double x);
        [OperationContract]
        double GetSchRadius(double x);
    }
}
