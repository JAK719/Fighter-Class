using System;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            Console.WriteLine("Weclome to the UFC!  Create your Fighter");
            Console.WriteLine("What would you like to name your fighter?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hey {name} what is your nickname?");
            string nickname = Console.ReadLine();
            Fighter fighter = new Fighter(name, nickname);
            Console.Clear();


            
            while(true)
            {
                Console.WriteLine($"Name:{fighter.Name} | Nickname:{fighter.NickName} | Weight:{fighter.Weight} | Strength:{fighter.Strength} | Conditioning:{fighter.Conditioning} | Striking:{fighter.Striking} | Grappling:{fighter.Grappling}");
                Console.WriteLine("What would you like to do?\n 1. Strength Training \n 2. Conditioning Training \n 3. Train Striking \n 4. Train Grappling \n 5. Fight!"  );
                int input = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch(input)
                {
                    case 1:
                        Console.WriteLine("Choose your training method:\n 1. Push Ups \n 2. Free Weights \n 3. Tire Lift ");
                        int input2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Random random1 = new Random();
                        if (input2 == 1)
                            fighter.StrengthTraining(random1.Next(1, 5));
                        else if (input2 == 2)
                            fighter.StrengthTraining(random1.Next(6, 10));
                        else if (input2 == 3)
                            fighter.StrengthTraining(random1.Next(11, 15));
                        Console.Clear();
                        break;
                   
                    case 2:
                        Console.WriteLine("Choose your training method:\n 1. Jump Rope \n 2. Burpees \n 3. Sparring");
                        int input3 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Random random2 = new Random();
                        if (input3 == 1)
                            fighter.ConditionTraining(random2.Next(1, 5));
                        else if (input3 == 2)
                            fighter.ConditionTraining(random2.Next(6, 10));
                        else if (input3 == 3)
                            fighter.ConditionTraining(random2.Next(11, 15));
                        break;
                   
                    case 3:
                        Console.WriteLine("Choose your training method:\n 1. Heavy Bag \n 2. Boxing \n 3. Kickboxing");
                        int input4 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Random random3 = new Random();
                        if (input4 == 1)
                            fighter.StrikeTraining(random3.Next(1, 5));
                        else if (input4 == 2)
                            fighter.StrikeTraining(random3.Next(6, 10));
                        else if (input4 == 3)
                            fighter.StrikeTraining(random3.Next(11, 15));
                        break;

                    case 4:
                        Console.WriteLine("Choose your training method:\n 1. Grappling Dummy  \n 2. Brazilian Jie Jitsu Sparring \n 3. Wrestle a Bear");
                        int input5 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Random random4 = new Random();
                        if (input5 == 1)
                            fighter.GrapplingTraining(random4.Next(1, 5));
                        else if (input5 == 2)
                            fighter.GrapplingTraining(random4.Next(6, 10));
                        else if (input5 == 3)
                            fighter.GrapplingTraining(random4.Next(11, 15));
                        break;

                    case 5:
                        CompFighter compfighter = new CompFighter();
                        Console.WriteLine($"Headling UFC PPV 258 is {nickname} vs The Champioon!\n 1. Press any key to Fight!");
                        Console.ReadKey();
                        Console.Clear();
                        if (fighter.Conditioning + fighter.Strength + fighter.Grappling + fighter.Striking >= compfighter.Power)
                            Console.WriteLine("You Win!");
                        else
                            Console.WriteLine("You lost this time, keep training and try again. \n Press Any Key To Get Back In The Gym...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                           
                        
                           
                               
                      


                }

            }






        }
    }
}
