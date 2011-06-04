// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyLogger.cs" company="Arosbi">
//   Copyright (c) Hugo Biarge. Todos los derechos reservados.
// </copyright>
// <summary>
//   
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Infrastructure
{
    using System;

    /// <summary>
    /// Implementación de prueba del Logger.
    /// </summary>
    public class MyLogger : ILogger
    {
        /// <summary>
        /// Loguea un error.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public void LogError(string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException("message");
            }

            Console.WriteLine("Ooops! Ha ocurrido un error: " + message);
        }
    }
}