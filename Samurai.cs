using System;

namespace human
{ 
    class Samurai: Human{
        public Samurai(){
            Health = 200;
        }

        public void Meditate(){
            this.health = 200;
        }

        public override void Attack(Human target){
            if(target.Healt<50){
                target.health = 0;
            }
            else {
            int dmg = Strength*5;
            target.Health -=dmg;
            Health+=dmg;

            }
        }
    }

}