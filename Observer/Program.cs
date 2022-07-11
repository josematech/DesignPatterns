using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Observer Pattern";

            //There could be loads of different observers
            MobileAppInstance mobileAppInstance = new MobileAppInstance();
            WebBrowserInstance webBrowserInstance = new WebBrowserInstance();

            //And there could be loads of different subjects too
            RYR4677 ryanairFlight = new RYR4677();
            ryanairFlight.AddObserver(mobileAppInstance);
            ryanairFlight.AddObserver(webBrowserInstance);
            AFR026 airfranceFlight = new AFR026();
            airfranceFlight.AddObserver(mobileAppInstance);
            airfranceFlight.AddObserver(webBrowserInstance);

            ryanairFlight.UpdateInfo();
            Console.WriteLine();
            airfranceFlight.UpdateInfo();

            ryanairFlight.RemoveObserver(mobileAppInstance);
            airfranceFlight.RemoveObserver(webBrowserInstance);

            Console.WriteLine();
            ryanairFlight.UpdateInfo();
            Console.WriteLine();
            airfranceFlight.UpdateInfo();

            Console.ReadKey();
        }
    }



}
