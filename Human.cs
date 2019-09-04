using System;

namespace human
{ 
    public class Human{
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int Health;
        public Human(string name){
            Name = name;
            Health = 100;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
        }
        public Human(string name, int health, int strength, int intelligence, int dexterity)
    {   
        Name = name;
        Health = health;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
    }

        public virtual int Attack(Human target){
            target.Health = target.Health - this.Strength*5;
            return target.Health;
        }

    }

}


