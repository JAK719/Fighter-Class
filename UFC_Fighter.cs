using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class Fighter
    {
     public string Name { get; set; }
     public string NickName { get; set; }
     public  int Weight { get; set; }
     public int Strength { get; set; }
     public int Conditioning { get; set; }
     public   int Grappling { get; set; }
     public  int Striking { get; set; }
     public bool MakeWeight { get; set; }
     
        public Fighter(string name, string nickName)
        {
            Random random = new Random();
            Name = name;
            NickName = nickName;
            Weight = random.Next(150, 250);
            Strength = random.Next(20, 35);
            Conditioning = random.Next(15, 30);
            Grappling = random.Next(20, 45);
            Striking = random.Next(25, 50);
            if (Weight < 200)
            {
                MakeWeight = true;

            }
            else
                MakeWeight = false;
        }

        public void StrikeTraining(int value)
        {
            if (Striking + value > 100)
                Striking = 100;
            else
                Striking = Striking + value;
        }

        public void GrapplingTraining(int value)
        {
            {
                if (Grappling + value > 100)
                    Grappling = 100;
                else
                    Grappling = Grappling + value;
            }
        }

        public void StrengthTraining(int value)
        {
            {
                if (Strength + value > 100)
                    Strength = 100;
                else
                    Strength = Strength + value;
            }
        }

        public void ConditionTraining(int value)
        {
            {
                if (Conditioning + value > 100)
                    Conditioning = 100;
                else
                    Conditioning = Conditioning + value;
            }
        }
        public void CutWeight(int value)
        {
            Weight -= value;
        }

        public void GainWeight(int value)
        {
            Weight += value;
        }

        public bool CheckMakeWeight()
        {
            if(Weight < 200)
            {
                MakeWeight = true;
                return MakeWeight;
            }

            MakeWeight = false;
            return MakeWeight;
        }
   



    }

    //public class CompFighter
    //{
    //   public int Power { get; set; }


    //    public CompFighter()
    //    {
    //        Random compRandom = new Random();
    //        Power = compRandom.Next(125, 390);

    //    }

    //}

   


}



