namespace pokemon
{
    internal class Pokemon
    {
        readonly string name = "", type1, type2;
        readonly int id, total, hp, attack, defense, spAtk, spDef, speed, generation;
        readonly bool legendary;

        public string Name => name;
        public string Type1 => type1;
        public string Type2 => type2;
        public int Id => id;
        public int Total => total;
        public int Hp => hp;
        public int Attack => attack;
        public int Defense => defense;
        public int SpAtk => spAtk;
        public int SpDef => spDef;
        public int Speed => speed;
        public int Generation => generation;
        public bool Legendary => legendary;


        public Pokemon(string name, string type1, string type2, int id, int total, int hp, int attack, int defense, int spAtk, int spDef, int speed, int generation, bool legendary)
        {
            this.name = name;
            this.type1 = type1;
            this.type2 = type2;
            this.id = id;
            this.total = total;
            this.hp = hp;
            this.attack = attack;
            this.defense = defense;
            this.spAtk = spAtk;
            this.spDef = spDef;
            this.speed = speed;
            this.generation = generation;
            this.legendary = legendary;
        }
    }
}
