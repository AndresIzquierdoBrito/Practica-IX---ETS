using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pokemon;

namespace PracticaTests
{
    [TestClass]
    public class PokemonTests
    {
        static List<Pokemon> pkms = new List<Pokemon>(){
               new Pokemon("Pokemon 1", "Grass", "Poison", 1, 1, 1, 10, 1, 1, 1, 1, 2, false),
               new Pokemon("Pokemon 2", "Fire", null, 4, 1, 1, 11, 1, 1, 1, 1, 1, false),
               new Pokemon("Pokemon 3 - Highest Attack from Gen 3", "Water", null, 7, 1, 1, 12, 1, 1, 1, 1, 3, false),
               new Pokemon("Pokemon 4 - Highest Attack from Gen 2", "Electric", null, 25, 1, 1, 13, 1, 1, 1, 1, 2, false),
               new Pokemon("Pokemon 5 - Highest Attack from Gen 4", "Normal", "Fairy" , 1, 1, 1, 14, 1, 1, 1, 1, 4, false),
               new Pokemon("Pokemon 6 - Highest Attack from Gen 1", "Normal", null, 143, 1, 1, 15, 1, 1, 1, 1, 1, false),  //Expected highest 
               new Pokemon("Pokemon 7 - Highest Attack - Legendary", "Psychic", null, 150, 1, 1, 16, 1, 1, 1, 1, 1, true),
               new Pokemon("Pokemon 8 - Highest Attack from Gen 5", "Normal", null, 143, 1, 1, 15, 1, 1, 1, 1, 5, false),  //Expected highest 
               new Pokemon("Pokemon 9 - Highest Attack from Gen 6", "Normal", null, 143, 1, 1, 15, 1, 1, 1, 1, 6, false),  //Expected highest 
               new Pokemon("Pokemon 10 - Highest Attack from Gen 7", "Normal", null, 143, 1, 1, 15, 1, 1, 1, 1, 7, false),  //Expected highest 
        };

        [TestClass]
        public class StrongestPokemonTests
        {
            [TestMethod]
            public void TestGenerationOne()
            {
                int generation = 1;

                string strongest = pokemon.Program.StrongestPokemon(generation, pkms);

                Assert.AreEqual("Pokemon 6 - Highest Attack from Gen 1", strongest);
            }

            [TestMethod]
            public void TestGenerationTwo()
            {
                int generation = 2;

                string strongest = pokemon.Program.StrongestPokemon(generation, pkms);

                Assert.AreEqual("Pokemon 4 - Highest Attack from Gen 2", strongest);
            }

            [TestMethod]
            public void TestGenerationThree()
            {
                int generation = 3;

                string strongest = pokemon.Program.StrongestPokemon(generation, pkms);

                Assert.AreEqual("Pokemon 3 - Highest Attack from Gen 3", strongest);
            }
            public void TestGenerationFour()
            {
                int generation = 4;

                string strongest = pokemon.Program.StrongestPokemon(generation, pkms);

                Assert.AreEqual("Pokemon 5 - Highest Attack from Gen 4", strongest);
            }

            [TestMethod]
            public void TestGenerationFive()
            {
                int generation = 5;


                string strongest = pokemon.Program.StrongestPokemon(generation, pkms);

                Assert.AreEqual("Pokemon 8 - Highest Attack from Gen 5", strongest);
            }

            [TestMethod]
            public void TestGenerationSix()
            {
                int generation = 6;

                string strongest = pokemon.Program.StrongestPokemon(generation, pkms);

                Assert.AreEqual("Pokemon 9 - Highest Attack from Gen 6", strongest);
            }

            [TestMethod]
            public void TestGenerationSeven() // Espera un valor vacio al no deber aceptar Pokemon de Gen 7
            {
                int generation = 7;

                string strongest = pokemon.Program.StrongestPokemon(generation, pkms);

                Assert.AreEqual("", strongest);
            }

            [TestMethod]
            public void TestStrongestPokemonWithOnlyLegendary() // Espera un valor null al no deber aceptar Pokemon de Gen 7
            {
                int generation = 1;

                List<Pokemon> pkmnLegendary = new List<Pokemon>();
                new Pokemon("Pokemon 1", "Grass", "Poison", 1, 1, 1, 10, 1, 1, 1, 1, 2, true);

                string strongest = pokemon.Program.StrongestPokemon(generation, pkmnLegendary);

                Assert.IsNull(strongest);
            }

            [TestMethod]
            public void TestStrongestPokemonEmpyList() // Espera un valor null al no deber aceptar Pokemon de Gen 7
            {
                int generation = 1;

                List<Pokemon> emptyList = new List<Pokemon>();

                string strongest = pokemon.Program.StrongestPokemon(generation, emptyList);

                Assert.IsNull(strongest);
            }

            [TestMethod]
            public void TestFilterPokemonWithEmptyList()
            {
                List<Pokemon> emptyList = new List<Pokemon>();
                pokemon.Program.FilterPokemon(emptyList);

                Assert.IsTrue(File.Exists("pokemon2tipos.csv"));
                Assert.AreEqual(1, File.ReadAllLines("pokemon2tipos.csv").Length);
            }

            [TestMethod]
            public void TestFilterPokemonWithTwoTypesNull() // Check if method excludes Pokemon with NULL as second type
            {
                pokemon.Program.FilterPokemon(pkms);

                Assert.IsTrue(File.Exists("pokemon2tipos.csv"));
                string[] lines = File.ReadAllLines("pokemon2tipos.csv");
                Assert.AreEqual(lines.Length, 3);   // Should exclude pokemons that have second type as null
            }

            [TestMethod]
            public void TestFilterPokemonWithTwoTypesEmpty() // Check if method excludes Pokemon with EMPTY STRING as second type
            {

                List<Pokemon> pkmnEmptySecondType = new List<Pokemon>(){
                    new Pokemon("Pokemon 1", "Grass", "Poison", 1, 1, 1, 10, 1, 1, 1, 1, 2, false),
                    new Pokemon("Pokemon 2", "Fire", "", 4, 1, 1, 11, 1, 1, 1, 1, 1, false),
                    new Pokemon("Pokemon 3", "Water", "", 7, 1, 1, 12, 1, 1, 1, 1, 3, false),
                    new Pokemon("Pokemon 4", "Electric", "", 25, 1, 1, 13, 1, 1, 1, 1, 2, false)
                };

                pokemon.Program.FilterPokemon(pkmnEmptySecondType);

                Assert.IsTrue(File.Exists("pokemon2tipos.csv"));
                string[] lines = File.ReadAllLines("pokemon2tipos.csv");
                Assert.AreEqual(lines.Length, 2);   // Should exclude pokemons that have second type as null
            }



        }
    }
}

