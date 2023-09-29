using System.ServiceModel;
//Author: Lan Song ID:30072745 26/9/2023 Murdoch
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
