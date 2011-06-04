// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnityIoC.cs" company="Arosbi">
//   Copyright (c) Hugo Biarge. Todos los derechos reservados.
// </copyright>
// <summary>
//   
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using IoC.Unity.Extensions;

using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;

namespace IoC.Core.Unity
{
    /// <summary>
    /// Implementación del IoC con Unity.
    /// </summary>
    public static class UnityIoC
    {
        /// <summary>
        /// Inicializa el contenedor.
        /// </summary>
        public static void Initialize()
        {
            // Create root container and childs
            var container = new UnityContainer();

            // Registramos los tipos comunes
            container.AddNewExtension<CommonTypesExtension>();

            // En función de la variable de configuración, registramos unos tipos u otros
            // Si no existe la variable de configuración, sólo se registran los tipos comunes
            var containerName = ConfigurationManager.AppSettings["defaultIoCContainer"];

            switch (containerName)
            {
                case "RealAppContext":
                    container.AddNewExtension<RealTypesExtension>();
                    break;
                case "FakeAppContext":
                    container.AddNewExtension<FakeTypesExtension>();
                    break;
                default:
                    break;
            }

            // Definimos el contenedor en el ServiceLocator
            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(container));
        }
    }
}
