// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FakeDalAgent.cs" company="Arosbi">
//   Copyright (c) Hugo Biarge. Todos los derechos reservados.
// </copyright>
// <summary>
//   Defines the FakeDalAgent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace Dal
{
    /// <summary>
    /// Implementación de prueba.
    /// </summary>
    public class FakeDalAgent : IDalAgent
    {
        /// <summary>
        /// Obtiene el saludo.
        /// </summary>
        public void HolaDal()
        {
            Console.WriteLine("Hola desde FakeDalAgent");
        }
    }
}