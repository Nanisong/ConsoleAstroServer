using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using AstroMaths;
using System.Diagnostics;
//Author: Lan Song ID:30072745 26/9/2023 Murdoch
namespace ConsoleAstroServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6.3 To create the ServiceHost object that will host this interface using the NetNamedPipeBinding
            //This code can be runn a loop, however, the ServiceHost is open and is only closed when the console
            //program is terminated.Ensure you have created a Release build of this code for testing.

            try
            {
                using (ServiceHost host = new ServiceHost(typeof(AstroServerImplementation),
                    new Uri[]{
                        new Uri("net.pipe://localhost/SpaceServer1")}))
                {
                    host.AddServiceEndpoint(typeof(IAstroContract), new NetNamedPipeBinding(), "");
                    host.Open();
                                        
                    Console.WriteLine("Service is available. " + "Press <ENTER> to exit.");
                    Console.ReadLine();

                    host.Close();
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }
        }
    }
}
