// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceLocatorProvider.cs" company="Arosbi">
//   Copyright (c) Hugo Biarge. Todos los derechos reservados.
// </copyright>
// <summary>
//   
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace IoC.Core
{
    /// <summary>
    /// This delegate type is used to provide a method that will
    /// return the current container. Used with the <see cref="ServiceLocator" />
    /// static accessor class.
    /// </summary>
    /// <returns>An <see cref="IServiceLocator" />.</returns>
    public delegate IServiceLocator ServiceLocatorProvider();
}
