using System;

namespace wizard_ninja_samurai{
    public class Human{
        public string name;

        //The { get; set; } format creates accessor methods for the field specified
        //This is done to allow flexibility
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }

        public Human(string person)
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string person, int str, int intel, int dex, int hp)
        {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
        public void attack(object obj)
        {
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health -= strength * 5;
            }
        }
    }
    public class Wizard: Human{
        public Wizard() : base("wizardkid"){
            health = 50;
            intelligence = 25;
        }
        public void Heal(){
            health += intelligence*10;
        }
        public void Fireball(object obj){
            Random rand = new Random();
            int rando;
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                rando = rand.Next(20,51);
                Console.WriteLine("Fireball worth {0} damage", rando);
                enemy.health -= rando;
            }
        }

    }
    public class Ninja: Human{
        public Ninja() : base("ninjaman"){
            dexterity = 175;
        }
        public void Steal(object obj){
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                Console.WriteLine("stealing...");
                health += 10;
            }
        }
        public void GetAway(){
            health -= 15;
        }

    }
    public class Samurai: Human{
        public static int count = 0;
        public Samurai() : base("Sammy"){
            count++;
            health = 200;
        }
        public void DeathBlow(object obj){
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else if (enemy.health < 50)
            {
                Console.WriteLine("Deathblow...");
                enemy.health = 0;
            }
        }
        public void Meditate(){
            health = 200;
        }
        public void ShowSamurai(){
            Console.WriteLine("# samurai: " + count);
        }

    }

    
}