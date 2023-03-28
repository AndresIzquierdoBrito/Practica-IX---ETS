using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTests
{
    [TestClass]
    public class PokemonTests
    {
        [TestMethod]
        public void testpokemondef()
        {
            int n = 2, y = 1;
            Assert.AreEqual(3, n+y);
        }
    }
}
