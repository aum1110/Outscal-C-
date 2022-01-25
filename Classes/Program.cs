using System;

namespace Classes
{
    class Wizard
    {
        public string name;
        public string spell;
        public int SpellCount;
        public float exp;
        public int health;

        public Wizard(string _name ,  string _spell) // Wizard Constructor 
        {
            name = _name;
            spell = _spell;
             health = 100;
            SpellCount = 2;
            exp = 1f;
            }
        public void Damage() // Damage method 
        {
            health -= 50;
        
        }
        public void Die() // DIE function
            {

            if (health <= 0)
            {
                Console.WriteLine(name + "Died");
            
                }
        
            }
        public void Health() // Health method
        {
            

            if (SpellCount <= 0)
            {
                health -= 50;
           
            }

        
        }
        public void CastSpell()
            {
            if (SpellCount > 0)
            {
                Console.WriteLine(name + "Casts" + spell);
                SpellCount--;
                exp += 0.3f;
            }
            else
            {
                Console.WriteLine("You are out of spells !");
            
                }
           }
    

    }
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wiz1 = new Wizard(" Wizzy " ," Wingardo ");
            Wizard wiz2 = new Wizard(" Moriheo ", " iskascel ");





            wiz1.CastSpell();

            wiz2.Damage();

            wiz2.CastSpell();

            wiz1.CastSpell();

            wiz1.Damage();
            wiz2.CastSpell();
            wiz1.Damage();
            

            Console.WriteLine(wiz1.health);
            Console.WriteLine(wiz2.health);

            if (wiz1.health > wiz2.health)
            {
                wiz2.Die();
                Console.WriteLine("Wizzy the wizard won!");

            }
            else
            {
                wiz1.Die();
                Console.WriteLine("Moriheo the wizard won !");
            
            }
            

        

        }
    }
}
