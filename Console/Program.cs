// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Hugo">
//   Hola
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Configuration;
using Bl;

using Microsoft.Practices.ServiceLocation;

using con = System.Console;
using IoC.Unity;

namespace Console
{
    /// <summary>
    /// Punto de entrada.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Punto de entrada.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        internal static void Main(string[] args)
        {
            UnityIoC2.Initialize();
            var locator = ServiceLocator.Current;

            // Real
            DoCall(locator);

            con.ReadLine();
            ConfigurationManager.RefreshSection("appSettings");

            // Fake
            DoCall(locator);

            con.ReadLine();
        }

        /// <summary>
        /// Realiza la llamada.
        /// </summary>
        /// <param name="locator">
        /// The locator.
        /// </param>
        private static void DoCall(IServiceLocator locator)
        {
            var testService = locator.GetInstance<ITestService>();
            testService.TestOperation();
        }
    }
}
