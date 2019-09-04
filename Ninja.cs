using System;

namespace human
{ 
    class Ninja : Human{
        public static Random RandomGen = new Random();
        public Ninja(){
            Dexterity = 175;
        }


        public void Steal(Human target){
            target.Health -=5;
            this.Health +=5;
        
        }

        
         public override void Attack(Human target){
             int dmg = Dexterity*5;
            target.Health -=dmg;
            int num = 20;
            for (int i=0; i<100; i++){
                int randomChance = RandomGen.Next(100);
                if(randomChance < num)
                {
                    target.Health-=10;
                    Console.WriteLine("Powered up. You inflicted 10 extra Damage!!");
                }
            }
        }
    }

}