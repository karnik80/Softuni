using System;
using System.Collections.Generic;
using System.Linq;

namespace Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Dragon>> myDragons = new Dictionary<string, List<Dragon>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string type = tokens[0];
                string name = tokens[1];
                //int damage = int.Parse(tokens[2]);
                //int health = int.Parse(tokens[3]);
                //int armor = int.Parse(tokens[4]);

                Dragon temp = new Dragon(tokens);

                if (myDragons.ContainsKey(type))
                {
                    if(myDragons[type].Exists(x => x.Name == name))//Update Name under that type
                    {
                        int index = myDragons[type].FindIndex(x => x.Name == temp.Name);
                        myDragons[type][index].Health = temp.Health;
                        myDragons[type][index].Damage = temp.Damage;
                        myDragons[type][index].Armor = temp.Armor;
                    }
                    else//Add new Dragon under that type
                    {
                        myDragons[type].Add(new Dragon(tokens));
                        myDragons[type].OrderBy(x => x.Name);
                    }
                }
                else//Add new type
                {
                    myDragons.Add(type, new List<Dragon>());
                    myDragons[type].Add(new Dragon(tokens));
                    myDragons[type].OrderBy(x => x.Name);
                }
            }//End forloop

            foreach (var item in myDragons)
            {
                double avrArmor = item.Value.Average(x => x.Armor);
                double avrHealth = item.Value.Average(x => x.Health);
                double avrDamage = item.Value.Average(x => x.Damage);

                Console.WriteLine($"{item.Key}::({avrDamage:F2}/{avrHealth:F2}/{avrArmor:F2})");

                List<Dragon> nameSorted = item.Value.OrderBy(x => x.Name).ToList();
                foreach (var dragon in nameSorted)
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }

    public class Dragon 
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }

        public Dragon(string[] dragonProperties)
        {
            Name = dragonProperties[1];
            if(dragonProperties[2] == "null")
            {
                Damage = 45;
            }
            else
            {
                Damage = int.Parse(dragonProperties[2]);
            }

            if(dragonProperties[3] == "null")
            {
                Health = 250;
            }
            else
            {
                Health = int.Parse(dragonProperties[3]);
            }

            if(dragonProperties[4] == "null")
            {
                Armor = 10;
            }
            else
            {
                Armor = int.Parse(dragonProperties[4]);
            }
        }
    }
}
