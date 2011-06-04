// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FakeTypesExtension.cs" company="Hugo">
//   Hola
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace IoC.Unity.Extensions
{
    using Microsoft.Practices.Unity;

    /// <summary>
    /// Define una extensión de Unity para los tipos comunes en todos los contextos.
    /// </summary>
    public class FakeTypesExtension : UnityContainerExtension
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
            // Registrar los tipos para los Fakes
        }
    }
}