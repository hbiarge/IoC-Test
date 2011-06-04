// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DalAgent.cs" company="Arosbi">
//   Copyright (c) Hugo Biarge. Todos los derechos reservados.
// </copyright>
// <summary>
//   Implementacion de prueba de IDalAgent.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dal
{
    using System;

    /// <summary>
    /// Implementacion de prueba de IDalAgent.
    /// </summary>
    public class DalAgent : IDalAgent
    {
        /// <summary>
        /// Obtiene el saludo.
        /// </summary>
        public void HolaDal()
        {
            Console.WriteLine("Hola desde DalAgent");
        }
    }
}