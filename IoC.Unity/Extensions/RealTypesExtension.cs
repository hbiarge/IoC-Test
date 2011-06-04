// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RealTypesExtension.cs" company="Arosbi">
//   Copyright (c) Hugo Biarge. Todos los derechos reservados.
// </copyright>
// <summary>
//   
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Dal;

namespace IoC.Unity.Extensions
{
    using Microsoft.Practices.Unity;

    /// <summary>
    /// Define una extensión de Unity para los tipos comunes en todos los contextos.
    /// </summary>
    public class RealTypesExtension : UnityContainerExtension
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
            // Registrar los tipos para las implementaciones reales
            Container.RegisterType<IDalAgent, DalAgent>(new TransientLifetimeManager());
        }
    }
}