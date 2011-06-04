// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommonTypesExtension.cs" company="Hugo">
//   Hola
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace IoC.Unity.Extensions
{
    using Bl;
    using Dal;
    using Infrastructure;
    using Microsoft.Practices.Unity;

    /// <summary>
    /// Define una extensión de Unity para los tipos comunes en todos los contextos.
    /// </summary>
    public class CommonTypesExtension : UnityContainerExtension
    {
        /// <summary>
        /// Initial the container with this extension's functionality.
        /// </summary>
        /// <remarks>
        /// When overridden in a derived class, this method will modify the given
        /// <see cref="T:Microsoft.Practices.Unity.ExtensionContext"/> by adding strategies, policies, etc. to
        /// install it's functions into the container.
        /// </remarks>
        protected override void Initialize()
        {
            // Registrar tipos comunes
            Container.RegisterType<ILogger, MyLogger>(new TransientLifetimeManager());
            Container.RegisterType<ITestService, TestService>(new TransientLifetimeManager());
            Container.RegisterType<IDalAgent, DalAgent>(new TransientLifetimeManager());
        }
    }
}