// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnityIoC.cs" company="Arosbi">
//   Copyright (c) Hugo Biarge. Todos los derechos reservados.
// </copyright>
// <summary>
//   
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace IoC.Unity
{
    using System.Configuration;

    using IoC.Unity.Extensions;

    using Microsoft.Practices.ServiceLocation;
    using Microsoft.Practices.Unity;

    /// <summary>
    /// Implementación del IoC con Unity.
    /// </summary>
    public static class UnityIoC2
    {
        /// <summary>
        /// Inicializa el contenedor.
        /// </summary>
        public static void Initialize()
        {
            var containersDictionary = new Dictionary<string, IUnityContainer>();

            // Creamos los contenedores
            var rootContainer = new UnityContainer();
            var realAppContainer = rootContainer.CreateChildContainer();
            var fakeAppContainer = rootContainer.CreateChildContainer();

            // Los añadimos al diccionario
            containersDictionary.Add("RootContext", rootContainer);
            containersDictionary.Add("RealAppContext", realAppContainer);
            containersDictionary.Add("FakeAppContext", fakeAppContainer);

            // Configuramos los contenedores
            rootContainer.AddNewExtension<CommonTypesExtension>();
            realAppContainer.AddNewExtension<RealTypesExtension>();
            fakeAppContainer.AddNewExtension<FakeTypesExtension>();

            // Definimos el contenedor en el ServiceLocator
            ServiceLocator.SetLocatorProvider(() => new CustomUnityServiceLocator(containersDictionary));
        }
    }
}
