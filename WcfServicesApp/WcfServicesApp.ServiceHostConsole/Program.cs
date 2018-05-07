using System;
using System.ServiceModel;

namespace WcfServicesApp.ServiceHostConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // config cmd
            Console.Title = "Wcf services";

            // Create a ServiceHost for the CaseStudyService type.
            var host = new ServiceHost(typeof(WcfServiceLib.MainService));

            // Open the ServiceHost to create listeners and start listening for messages.
            host.Open();
            Console.WriteLine("Services are ready.");
            Console.WriteLine("Services are running.");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
