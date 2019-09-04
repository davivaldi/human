using System;

namespace human
{ 
    public class Human{
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public Human(string name){
            Name = name;
            health=100;
            Strength = 3;
            Intelligence =3;
            Dexterity =3;
        }
        public string name
    {
        get { return Name; }
    }

        public int Attack(Human target){
            target.health = target.health - Strength*5;
            return target.health;
        }







    }
    class Program
    {
        static void Main(string[] args)
        {
        
        










        }
    }
}
