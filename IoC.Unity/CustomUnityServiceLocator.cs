// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomUnityServiceLocator.cs" company="Arosbi">
//   Copyright (c) Hugo Biarge. Todos los derechos reservados.
// </copyright>
// <summary>
//   
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Configuration;

using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;

namespace IoC.Unity
{
    /// <summary>
    /// Implementación personalizada de un IServiceLocator personalizado con Unity.
    /// </summary>
    public class CustomUnityServiceLocator : ServiceLocatorImplBase
    {
        #region Members

        /// <summary>
        /// Almacena el diccionario con los contenedores.
        /// </summary>
        private readonly IDictionary<string, IUnityContainer> containersDictionary;

        #endregion

        #region Constructores

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomUnityServiceLocator"/> class.
        /// </summary>
        /// <param name="containersDictionary">
        /// The containers dictionary.
        /// </param>
        /// <exception cref="ArgumentNullException">Si el parámetro es null.
        /// </exception>
        public CustomUnityServiceLocator(IDictionary<string, IUnityContainer> containersDictionary)
        {
            if (containersDictionary == null)
            {
                throw new ArgumentNullException("containersDictionary");
            }

            this.containersDictionary = containersDictionary;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// When implemented by inheriting classes, this method will do the actual work of resolving
        ///             the requested service instance.
        /// </summary>
        /// <param name="serviceType">Type of instance requested.</param><param name="key">Name of registered service you want. May be null.</param>
        /// <returns>
        /// The requested service instance.
        /// </returns>
        protected override object DoGetInstance(Type serviceType, string key)
        {
            var containerName = this.GetContainerName();

            this.CheckContainerName(containerName);

            var container = this.containersDictionary[containerName];

            return container.Resolve(serviceType, key, new ResolverOverride[0]);
        }

        /// <summary>
        /// When implemented by inheriting classes, this method will do the actual work of
        ///             resolving all the requested service instances.
        /// </summary>
        /// <param name="serviceType">Type of service requested.</param>
        /// <returns>
        /// Sequence of service instance objects.
        /// </returns>
        protected override IEnumerable<object> DoGetAllInstances(Type serviceType)
        {
            var containerName = this.GetContainerName();

            this.CheckContainerName(containerName);

            var container = this.containersDictionary[containerName];

            return container.ResolveAll(serviceType, new ResolverOverride[0]);
        }

        /// <summary>Obtiene el nombre del contenedor actual.
        /// </summary>
        /// <returns>
        /// El nombre del contenedor activo.
        /// </returns>
        protected virtual string GetContainerName()
        {
            // We use the default container specified in AppSettings
            return ConfigurationManager.AppSettings["defaultIoCContainer"];
        }

        /// <summary>
        /// Valida el nombre del contenedor.
        /// </summary>
        /// <param name="containerName">
        /// The container name.
        /// </param>
        /// <exception cref="ArgumentNullException">Si el nombre del contenedor es nulo o una cadena vacía o un espacio en blanco.
        /// </exception>
        /// <exception cref="InvalidOperationException">Si el nombre no se encuentra en los contenedores actuales.
        /// </exception>
        private void CheckContainerName(string containerName)
        {
            if (string.IsNullOrWhiteSpace(containerName))
            {
                throw new ArgumentNullException("containerName");
            }

            if (!this.containersDictionary.ContainsKey(containerName))
            {
                throw new InvalidOperationException("No se encuentra la clave en el diccionario");
            }
        }

        #endregion
    }
}
