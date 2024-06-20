// Caution: Code in construction!
using System;
using System.Xml.Linq;
class ex3
{
    public struct Hero
    {
        public string name;
        public string power;
        public int points;

    }
    static void Main()
    {
        Hero[] academy = new Hero[5];
        bool a = true;

        static void register()
        {

            Console.Write("Write the number of heroes you want to add: ");
            int number = int.Parse(Console.ReadLine());
            for (int p = 0; p < number; p++)
            {
                Hero[] academy = new Hero[5];
                Console.Write("\nWrite the hero's name: ");
                string name = Console.ReadLine();
                Console.Write("Write the power: ");
                string power = Console.ReadLine();
                Console.Write("Write the points: ");
                int points = int.Parse(Console.ReadLine());

                academy[p] = new Hero { name = name, power = power, points = points };
                
            }
            Console.WriteLine("Would you like to add more or return to menu:\n 1. Add\n 2. Return");
            int want_to = int.Parse(Console.ReadLine());
            if (want_to == 2) return;
        }

        static void main_menu()
        {
            Console.WriteLine("Write the number of your choice:\n 1. Register of hero\n 2. Creating team\n 3.Show team\n 4. End of the code ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    register();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    
                    break;
            }
        }
        
    }
}