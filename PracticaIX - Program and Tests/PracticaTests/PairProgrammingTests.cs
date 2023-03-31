using PairProgramming;

namespace PracticaTests
{
    [TestClass]
    public class PairProgrammingTests
    {
        ///////////////////////////////////////// PersonaPorEncimaMedia /////////////////////////////////////

        [TestMethod]
        public void PersonaPorEncimaMedia_Caso1()   // Pasando una lista con MULTIPLES personas con la DIFERENTES alturas
        {
            Personas[] listaPersona = new Personas[]
            {
                new Personas { Nombre = "Persona 1", Altura = 1.60m },
                new Personas { Nombre = "Persona 2", Altura = 1.80m },
                new Personas { Nombre = "Persona 3", Altura = 1.60m },
                new Personas { Nombre = "Persona 4", Altura = 1.90m },
                new Personas { Nombre = "Persona 5", Altura = 1.75m },
            };

            string[] result = CSAlturas.PersonasPorEncimaMedia(listaPersona);

            CollectionAssert.AreEqual(new[] { "Persona 2", "Persona 4", "Persona 5" }, result);
        }
        [TestMethod]
        public void PersonaPorEncimaMedia_Caso2()   // Pasando una lista con MULTIPLES personas con la MISMA altura
        {
            Personas[] listaPersona = new Personas[]
            {
                new Personas { Nombre = "Persona 1", Altura = 1.70m },
                new Personas { Nombre = "Persona 2", Altura = 1.70m },
                new Personas { Nombre = "Persona 3", Altura = 1.70m },
            };

            string[] result = CSAlturas.PersonasPorEncimaMedia(listaPersona);
            CollectionAssert.AreEqual(new string[] { }, result);
        }

        [TestMethod]
        public void PersonaPorEncimaMedia_Caso3()   // Pasando una lista VACIA
        {
            Personas[] listaPersona = new Personas[0];
            string[] result = CSAlturas.PersonasPorEncimaMedia(listaPersona);
            CollectionAssert.AreEqual(new string[] { }, result);
        }

        [TestMethod]
        public void PersonaPorEncimaMedia_Caso4() // Pasando una lista con UNA persona
        {
            Personas[] listaPersona = new Personas[]
            {
                new Personas { Nombre = "Persona 1", Altura = 1.80m }
            };
            string[] result = CSAlturas.PersonasPorEncimaMedia(listaPersona);
            CollectionAssert.AreEqual(new string[] { }, result);
        }

        ///////////////////////////////////////// PersonaPorDebajoMedia /////////////////////////////////////

        [TestMethod]
        public void PersonaPorDebajoMedia_Caso1() // Pasando una lista con MULTIPLES personas con la DIFERENTES alturas
        {
            Personas[] listaPersona = new Personas[]
            {
                new Personas { Nombre = "Persona 1", Altura = 1.60m },
                new Personas { Nombre = "Persona 2", Altura = 1.80m },
                new Personas { Nombre = "Persona 3", Altura = 1.60m },
                new Personas { Nombre = "Persona 4", Altura = 1.90m },
                new Personas { Nombre = "Persona 5", Altura = 1.75m },
            };

            string[] result = CSAlturas.PersonasPorDebajoMedia(listaPersona);

            CollectionAssert.AreEqual(new[] { "Persona 1", "Persona 3" }, result);
        }
        [TestMethod]
        public void PersonaPorDebajoMedia_Caso2() // Pasando una lista con MULTIPLES personas con la MISMA altura
        {
            Personas[] listaPersona = new Personas[]
            {
                new Personas { Nombre = "Persona 1", Altura = 1.70m },
                new Personas { Nombre = "Persona 2", Altura = 1.70m },
                new Personas { Nombre = "Persona 3", Altura = 1.70m },
            };

            string[] result = CSAlturas.PersonasPorDebajoMedia(listaPersona);
            CollectionAssert.AreEqual(new string[] { }, result);
        }

        [TestMethod]
        public void PersonaPorDebajoMedia_Caso3() // Pasando una lista VACIA
        {
            Personas[] listaPersona = new Personas[0];
            string[] result = CSAlturas.PersonasPorDebajoMedia(listaPersona);
            CollectionAssert.AreEqual(new string[] { }, result);
        }

        [TestMethod]
        public void PersonaPorDebajoMedia_Caso4() // Pasando una lista con UNA persona
        {
            Personas[] listaPersona = new Personas[]
            {
                new Personas { Nombre = "Persona 1", Altura = 1.80m }
            };
            string[] result = CSAlturas.PersonasPorDebajoMedia(listaPersona);
            CollectionAssert.AreEqual(new string[] { }, result);
        }

        ///////////////////////////////////////// PersonaMasAlta /////////////////////////////////////


        [TestMethod]
        public void PersonaMasAlta_Caso1()  // Pasando una lista con UNA persona
        {
            Personas[] listaPersona = new Personas[]
            {
                new Personas { Nombre = "Persona 1", Altura = 1.80m }
            };
            string result = CSAlturas.personaMasAlta(listaPersona);

            Assert.AreEqual("Persona 1", result);
        }

        [TestMethod]
        public void PersonaMasAlta_Caso2() // Pasando una lista con MULTIPLES personaS
        {
            Personas[] listaPersona = new Personas[]
            {
                new Personas { Nombre = "Persona 1", Altura = 1.60m },
                new Personas { Nombre = "Persona 2", Altura = 1.80m },
                new Personas { Nombre = "Persona 3", Altura = 1.60m },
                new Personas { Nombre = "Persona 4", Altura = 1.90m },
                new Personas { Nombre = "Persona 5", Altura = 1.75m },
            };
            string result = CSAlturas.personaMasAlta(listaPersona);
            
            Assert.AreEqual("Persona 4", result);
        }

        [TestMethod]
        public void PersonaMasAlta_Caso3() // Pasando una lista VACIA
        {
            Personas[] listaPersona = new Personas[0];

            Assert.ThrowsException<IndexOutOfRangeException>(() => CSAlturas.personaMasAlta(listaPersona));
        }
    }
}