using System;

namespace wizard_ninja_samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Human me = new Human("steve", 10, 50, 3, 20);
            // Console.WriteLine(me.name);
            // Console.WriteLine(me.health);
            Wizard wizz = new Wizard();
            wizz.Fireball(me);
            Ninja ninjaman = new Ninja();
            ninjaman.Steal(me);
            ninjaman.GetAway();
            Samurai sam = new Samurai();
            Samurai sam2 = new Samurai();
            Samurai sam3 = new Samurai();
            Samurai sam4 = new Samurai();
            sam2.ShowSamurai();
            me.attack(sam);
            Console.WriteLine("sam health: " + sam.health);
            sam.DeathBlow(me);
            Console.WriteLine("me health: " + me.health);
            sam.Meditate();
            Console.WriteLine("sam health: " + sam.health);
            Console.WriteLine("wizard health: " + wizz.health);
            Console.WriteLine("wizard name: " + wizz.name);
            wizz.Heal();
            Console.WriteLine("wizard health: " + wizz.health);

        }
    }
}
