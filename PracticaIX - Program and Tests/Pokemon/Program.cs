using System.Diagnostics;

namespace pokemon
{
    public class Program
    {
        static readonly string fichero = "pokemon.csv";
        public static List<Pokemon> pkms = new();

        private static void Main()
        {
            List<string> lineas = File.ReadAllLines(fichero).ToList();
            foreach (string linea in lineas.Skip(1))
            {
                string[] parts = linea.Split(',');
                pkms.Add(new(parts[1], parts[2], parts[3], Convert.ToInt32(parts[0]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]), Convert.ToInt32(parts[7]),
                    Convert.ToInt32(parts[8]), Convert.ToInt32(parts[9]), Convert.ToInt32(parts[10]), Convert.ToInt32(parts[11]), Convert.ToBoolean(parts[12])));
            }
            lineas.Clear();
            Console.WriteLine(StrongestPokemon(Funciones.LeerEntero("Introduce una generación para conocer su pokemon con más ataque: ", limInf: 1, limSup: 6)));
            FilterPokemon();
            //try
            //{
            //    Console.WriteLine("\n\n\tTratando de abrir el Csv...");
            //    Process.Start($"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Programs\\Microsoft VS Code\\Code.exe", filtrado).Close();
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex);
            //}
            Console.ReadKey();
        }
        public static string StrongestPokemon(int generation, List<Pokemon> pkms = null)
        {
            string s = pkms.Where(pkm => pkm.Generation == generation && !pkm.Legendary).MaxBy(pkm => pkm.Attack).Name;
            return s;
        }

        public static void FilterPokemon(List<Pokemon> pkms = null)
        {
            StreamWriter sw = new("pokemon2tipos.csv");
            sw.WriteLine("#,Name,Type 1,Type 2,Total,HP,Attack,Defense,Sp. Atk,Sp. Def,Speed,Generation,Legendary");

            foreach (Pokemon pkm in pkms.Where(pk => pk.Type2 != ""))
                sw.WriteLine($"{pkm.Id},{pkm.Name},{pkm.Type1},{pkm.Type2},{pkm.Total},{pkm.Hp},{pkm.Attack},{pkm.Defense},{pkm.SpAtk},{pkm.SpDef},{pkm.Speed},{pkm.Generation},{pkm.Legendary}");
            sw.Close();
        }
    }
}
