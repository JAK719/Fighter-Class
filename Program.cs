using System;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            Console.WriteLine("Weclome to the UFC!  Create your Fighter");
            Console.WriteLine("What is your fighter's First Name?");
            string firstName = Console.ReadLine();
            Console.WriteLine($"Hey {firstName}!  What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Finally, {firstName} {lastName}, what is your nickname?");
            string nickname = Console.ReadLine();
            Fighter fighter = new Fighter(firstName, lastName, nickname);
            Console.Clear();


            
            while(true)
            {
                Console.WriteLine($"Name:{fighter.FirstName} {fighter.LastName} | Nickname:{fighter.NickName} | Weight:{fighter.Weight} | Strength:{fighter.Strength} | Conditioning:{fighter.Conditioning} | Striking:{fighter.Striking} | Grappling:{fighter.Grappling}");
                Console.WriteLine("What would you like to do?\n 1. Strength Training \n 2. Conditioning Training \n 3. Train Striking \n 4. Train Grappling \n 5. Cut Weight \n 6. Gain Weight \n 7. Fight!"  );
                string input = Console.ReadLine();
                Console.Clear();

                switch(input)
                {
                    case "1":
                        Console.WriteLine("Choose your training method:\n 1. Push Ups \n 2. Free Weights \n 3. Tire Lift ");
                        string input2 = Console.ReadLine();
                     
                        Random random1 = new Random();
                        if (input2 == "1")
                            fighter.StrengthTraining(random1.Next(1, 5));
                        else if (input2 == "2")
                            fighter.StrengthTraining(random1.Next(6, 10));
                        else if (input2 == "3")
                            fighter.StrengthTraining(random1.Next(11, 15));
                        if (fighter.Strength == 100)
                            Console.WriteLine($"Your strength is already at {fighter.Strength}.  Go train something else. \nPress any key to retunr to the gym...");
                        //else if (input2 <= 3 && input2 >= 1 && fighter.Strength < 100)
                        //    Console.WriteLine($"Excellent Gains!  You're Strength is now up to {fighter.Strength}.  Keep on training and you'll be ready to make your Championship run!\nPress any key to return to the gym...");
                        //else if(input2 < 1 && input2 > 3)
                         else
                             Console.WriteLine("Don't waste my time! \nIf you don't want to train press any key to return to the gym...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                   
                    case "2":
                        Console.WriteLine("Choose your training method:\n 1. Jump Rope \n 2. Burpees \n 3. Sparring");
                        string input3 = Console.ReadLine();
                        Random random2 = new Random();
                        if (input3 == "1")
                            fighter.ConditionTraining(random2.Next(1, 5));
                        else if (input3 == "2")
                            fighter.ConditionTraining(random2.Next(6, 10));
                        else if (input3 == "3")
                            fighter.ConditionTraining(random2.Next(11, 15));
                        if (fighter.Conditioning == 100)
                            Console.WriteLine($"Your conditioning is already at {fighter.Conditioning}.  Go train something else. \n Press any key to return to the gym...");
                        else if (fighter.Conditioning < 100)
                                Console.WriteLine($"Great Workout!  You're conditioning is now up to {fighter.Conditioning}.  Soon you'll be ready to fight into the Championship rounds! \nPress any key to return to the gym...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                   
                    case "3":
                        Console.WriteLine("Choose your training method:\n 1. Heavy Bag \n 2. Boxing \n 3. Kickboxing");
                        string input4 = Console.ReadLine();
                        Random random3 = new Random();
                        if (input4 == "1")
                            fighter.StrikeTraining(random3.Next(1, 5));
                        else if (input4 == "2")
                            fighter.StrikeTraining(random3.Next(6, 10));
                        else if (input4 == "3")
                            fighter.StrikeTraining(random3.Next(11, 15));
                        if (fighter.Striking == 100)
                            Console.WriteLine($"Your striking is already at {fighter.Striking}.  Go train something else. \nPress any key to return to the gym...");
                        else if (fighter.Striking < 100)
                                Console.WriteLine($"Great Session!  You're striking is now up to {fighter.Striking}.  Soon You'll be ready to swing with the best of them.\nPress any key to return to the gym...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        Console.WriteLine("Choose your training method:\n 1. Grappling Dummy  \n 2. Brazilian Jiu Jitsu Sparring \n 3. Wrestle a Bear");
                        string input5 = Console.ReadLine();
                        Random random4 = new Random();
                        if (input5 == "1")
                            fighter.GrapplingTraining(random4.Next(1, 5));
                        else if (input5 == "2")
                            fighter.GrapplingTraining(random4.Next(6, 10));
                        else if (input5 == "3")
                            fighter.GrapplingTraining(random4.Next(11, 15));
                        if (fighter.Grappling == 100)
                            Console.WriteLine($"Your grappling is already at {fighter.Grappling}.  Go Train Something else. \nPress any key to return to the gym...");
                        else if (fighter.Grappling < 100)
                                Console.WriteLine($"Great Effort!  You're grappling is now up to {fighter.Grappling}.  You're on your way to getting even the highest level black belts to submit\nPress any key to return to the gym...");
                        Console.ReadKey();
                        Console.Clear(); ;
                        break;

                    case "5":
                        Console.WriteLine("Choose your training method: \n 1. Fasting \n 2. Dehydrate \n 3. Sauna");
                       string input6 = Console.ReadLine();
                        Random random5 = new Random();
                        if (input6 == "1")
                            fighter.CutWeight(random5.Next(1, 5));
                        else if (input6 == "2")
                            fighter.CutWeight(random5.Next(6, 10));
                        else if (input6 == "3")
                            fighter.CutWeight(random5.Next(11, 15));
                        Console.WriteLine($"You're Weight is now down to {fighter.Weight}\nPress any key to return to the gym...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "6":
                        Console.WriteLine("Choose your training method: \n 1. Cold Bath \n 2. Increase Carb And Salt Intake\n 3. Increase Fluid Intake");
                        string input7 = Console.ReadLine();
                        Random random6 = new Random();
                        if (input7 == "1")
                            fighter.GainWeight(random6.Next(1, 5));
                        else if (input7 == "2")
                            fighter.GainWeight(random6.Next(6, 10));
                        else if (input7 == "3")
                            fighter.GainWeight(random6.Next(11, 15));
                        Console.WriteLine($"You're weight is now up to {fighter.Weight}\nPress any key to return to the gym...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "7":
                        CompFighter compfighter = new CompFighter();
                        Console.WriteLine($"Headling Tonight's UFC Main Event is {firstName} {nickname} {lastName} vs The Champion!\n Press any key to Fight!");
                        Console.ReadKey();
                        Console.Clear();
                        if (fighter.Conditioning + fighter.Strength + fighter.Grappling + fighter.Striking >= compfighter.Power  && fighter.Striking > fighter.Grappling)
                            Console.WriteLine($"You won by Knock Out! Congratulations to the new Champion {firstName} {nickname} {lastName}!\nPress any key to return to the gym...");
                       else if(fighter.Conditioning + fighter.Strength + fighter.Grappling + fighter.Striking >= compfighter.Power && fighter.Striking < fighter.Grappling)
                            Console.WriteLine($"You won by Submission! Congratulations to the new Champion {firstName} {nickname} {lastName}!\nPress any key to return to the gym...");
                       else if (fighter.Conditioning + fighter.Strength + fighter.Grappling + fighter.Striking >= compfighter.Power  && fighter.Striking == fighter.Grappling)
                            Console.WriteLine($"You won by Unanimous Decision! Congratulations to the new Champion {firstName} {nickname} {lastName}!\nPress any key to return to the gym...");
                        else if (fighter.Conditioning + fighter.Strength + fighter.Grappling + fighter.Striking < compfighter.Power)
                            Console.WriteLine("You lost this time, keep training and try again. \nPress Any Key To Get Back In The Gym...");
                        Console.ReadKey();
                        Console.Clear();
                        break;



















                }

            }






        }
    }
}
