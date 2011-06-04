// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILogger.cs" company="Arosbi">
//   Copyright (c) Hugo Biarge. Todos los derechos reservados.
// </copyright>
// <summary>
//   
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Infrastructure
{
    /// <summary>
    /// Representa las operaciones de un logger.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Loguea un error.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        void LogError(string message);
    }
}
