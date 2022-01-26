using System;

namespace FinalAs
{
    class Pokemon
        {
        public string name;
        public int health;
        public float exp;
        public string Attack1;
        public string Attack2;

        public void Damage()
        {
            health -= 20;
            if (health <= 0)
            {

                Console.WriteLine("Pokemon Died!");

            }

           
        
        }
        public void Heavyattack()
            {
          
            exp += 20;
            if (health <= 0)
                {

                Console.WriteLine("Pokemon Died!");
            
                }
                
            
        }

        public void lightAttack1()
        {
            exp += 10;
            

            if (health <= 0)
            {
                Console.WriteLine("Pokemon Died!!");
            
            }
        
        
        }
       
        
        
        public Pokemon()
            {
            health = 100;
            exp = 0f;

            }
    
    }


    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon1 = new Pokemon();
            Pokemon pokemon2 = new Pokemon();

            Console.WriteLine("Enter first pokemon name : ");
            pokemon1.name = Console.ReadLine();
            Console.WriteLine("Enter Second Pokemon name : ");
            pokemon2.name = Console.ReadLine();


            Console.WriteLine("Enter attack1 for " +  pokemon1.name   +" light attack : ");
            pokemon1.Attack1 = Console.ReadLine();
            Console.WriteLine("Enter attack2 for " +  pokemon1.name   +" heavy attack : ");
            pokemon1.Attack2 = Console.ReadLine();


            Console.WriteLine("Enter attack1 for " +  pokemon2.name  + " light attack : ");
            pokemon2.Attack1 = Console.ReadLine();
            Console.WriteLine("Enter attack2 for " +  pokemon2.name  +  " heavy attack : ");
            pokemon2.Attack2 = Console.ReadLine();




            Console.WriteLine(pokemon1.name + "  performed  " + pokemon1.Attack1);
            pokemon1.lightAttack1();
            pokemon2.Damage();

            Console.WriteLine(pokemon2.name + "  performed  " + pokemon2.Attack2);
            pokemon2.Heavyattack();
            pokemon1.Damage();

            Console.WriteLine(pokemon1.name + "  performed  " + pokemon1.Attack2);
            pokemon1.Heavyattack();
            pokemon2.Damage();
            pokemon2.Damage();

            Console.WriteLine(pokemon1.name + "health : " + pokemon1.health);
            Console.WriteLine(pokemon2.name + "health: "+ pokemon2.health);

            if (pokemon1.health > pokemon2.health)
            {
                Console.WriteLine(pokemon1.name + " Won the fight!");

            }
            else { Console.WriteLine(pokemon2.name + " Won the fight!");
            }






        }
    }
}
