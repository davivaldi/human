using System;

namespace human
{ 

    class Wizard : Human{
        public Wizard(){
            Health = 50;
            Intelligence = 25;
        }

        public void Heal(Human target){
            target.Health += Intelligence*10;
        }

         public override void Attack(Human target){
             int dmg = Intelligence*5;
            target.Health -=dmg;
            Health+=dmg;
        }
    }

}