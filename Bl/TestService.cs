// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestService.cs" company="Arosbi">
//   Copyright (c) Hugo Biarge. Todos los derechos reservados.
// </copyright>
// <summary>
//   
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Bl
{
    using System;

    using Dal;

    using Infrastructure;

    using Microsoft.Practices.ServiceLocation;

    /// <summary>
    /// Implementación del servicio de test.
    /// </summary>
    public class TestService : ITestService
    {
        /// <summary>
        /// Almacena el agente dal.
        /// </summary>
        private readonly IDalAgent dalAgent;

        /// <summary>
        /// Almacena el logger.
        /// </summary>
        private readonly ILogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestService"/> class.
        /// </summary>
        /// <param name="dalAgent">
        /// The dal agent.
        /// </param>
        /// <param name="logger">
        /// The logger.
        /// </param>
        public TestService(IDalAgent dalAgent, ILogger logger)
        {
            if (dalAgent == null)
            {
                throw new ArgumentNullException("dalAgent");
            }

            if (logger == null)
            {
                throw new ArgumentNullException("logger");
            }

            this.dalAgent = dalAgent;
            this.logger = logger;
        }

        /// <summary>
        /// Realiza la operación de test.
        /// </summary>
        public void TestOperation()
        {
            var instance = ServiceLocator.Current.GetInstance<IDalAgent>();

            Console.WriteLine("Son iguales: " + ReferenceEquals(instance, this.dalAgent));

            this.logger.LogError("Test operation called!!!");
            this.dalAgent.HolaDal();

            Console.WriteLine("Operación de test");
        }
    }
}