using PairProgramming;

namespace PracticaTests
{
    [TestClass]
    public class PairProgrammingTests
    {
        
        [TestMethod]
        public void PersonaMasAltaTest()
        {
            Personas p = new Personas();
            p.Nombre = "Pepe";
            p.Altura = 1;
            Personas[] arrP = { p };
            string result = CSAlturas.personaMasAlta(arrP);

            Assert.AreEqual(p.Nombre, result);
        }
    }
}