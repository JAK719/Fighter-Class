using System;

namespace Choose_Your_Class
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // 
            Console.WriteLine("Congratulations on earning your first UFC Contract!\n\nWe just have a few questions before you're on your way to the top.");
            Console.Write("\nWhat is your fighter's First Name?  ");
            string firstName = Console.ReadLine();
            Console.Write($"\nHey {firstName}!  What is your last name?  ");
            string lastName = Console.ReadLine();
            Console.Write($"\nFinally, {firstName} {lastName}, what is your nickname?  ");
            string nickname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Welcome {firstName} '{nickname}' {lastName}, to the UFC! \n\nPress any key to continue to the locker room.");
            Fighter fighter = new Fighter(firstName, lastName, nickname);
            Console.ReadKey();
            Console.Clear();


            
            while(true)

            {
                
                fighter.AgeInYears = Convert.ToInt32(fighter.Age);
                Console.WriteLine($"Name: {fighter.FirstName} {fighter.LastName} | Nickname: {fighter.NickName} | Age: {fighter.AgeInYears} |  Weight: {fighter.Weight} | \n\nStrength: {fighter.Strength}  \n\nConditioning: {fighter.Conditioning}  \n\nStriking: {fighter.Striking}  \n\nGrappling: {fighter.Grappling}\n");
                Console.WriteLine("\nWelcome to the Locker Room!\n\nHow would you like to start your training?\n 1. Strength Training \n 2. Conditioning Training \n 3. Train Striking \n 4. Train Grappling \n 5. Cut Weight \n 6. Gain Weight \n 7. Fight!"  );
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
                            Console.WriteLine($"Your strength is already at {fighter.Strength}.  Go train something else. \nPress any key to retunr to the locker room...");
                        if (fighter.Strength < 100 && input2 == "1" || input2 == "2" || input2 == "3")
                            Console.WriteLine($"Excellent gains!  Your strength is now at {fighter.Strength}.  \nSoon you'll be ready for a Championship run. \nPress any key to return to the locker room.");
                            else
                        Console.WriteLine("Don't waste my time!  \nIf You dont want to train, get out of the gym...\nPress any key to return to the locker room");
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
                            Console.WriteLine($"Your conditioning is already at {fighter.Conditioning}.  Go train something else. \n Press any key to return to the locker room...");
                        if (fighter.Conditioning < 100 && input3 == "1" || input3 == "2" || input3 == "3")
                                Console.WriteLine($"Great Workout!  Your conditioning is now up to {fighter.Conditioning}.  \nSoon you'll be ready to fight into the Championship rounds! \nPress any key to return to the locker room...");
                        else
                            Console.WriteLine("Don't waste my time!  \nIf You dont want to train, get out of the gym...\nPress any key to return to the locker room");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                   
                    case "3":
                        Console.WriteLine("Choose your training method:\n 1. Heavy Bag \n 2. Boxing \n 3. Kickboxing");
                        string input4 = Console.ReadLine();
                        Random random3 = new Random();
                        if (input4 == "1" )
                            fighter.StrikeTraining(random3.Next(1, 5));
                        else if (input4 == "2")
                            fighter.StrikeTraining(random3.Next(6, 10));
                        else if (input4 == "3")
                            fighter.StrikeTraining(random3.Next(11, 15));
                        if (fighter.Striking == 100)
                            Console.WriteLine($"Your striking is already at {fighter.Striking}.  Go train something else. \nPress any key to return to the locker room...");
                        if (fighter.Striking < 100 && input4 == "1" || input4 == "2" || input4 == "3")
                            Console.WriteLine($"Great Session!  Your striking is now up to {fighter.Striking}.  \nSoon You'll be ready to swing with the best of them.\nPress any key to return to the locker room...");
                        else 
                            Console.WriteLine("Don't waste my time!  \nIf You dont want to train, get out of the gym...\nPress any key to return to the locker room");
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
                            Console.WriteLine($"Your grappling is already at {fighter.Grappling}.  Go Train Something else. \nPress any key to return to the locker room...");
                        if (fighter.Grappling < 100 && input5 == "1" || input5 == "2" || input5 == "3")
                               Console.WriteLine($"Great Effort!  Your grappling is now up to {fighter.Grappling}.  \nYou're on your way to making even the highest level black belts to submit.\nPress any key to return to the gym...");
                        else
                            Console.WriteLine("Don't waste my time!  \nIf You dont want to train, get out of the gym...\nPress any key to return to the locker room.");
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
                        if(input6 == "1" || input6 == "2" || input6 == "3")
                            Console.WriteLine($"You're Weight is now down to {fighter.Weight}\nPress any key to return to the locker room...");
                        else
                            Console.WriteLine("If you're not committed to cutting weight then get out of my gym!\nPress any key to return to the locker room.");
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
                        if (input7 == "1" || input7 == "2" || input7 == "3")
                            Console.WriteLine($"You're weight is now up to {fighter.Weight}\nPress any key to return to the locker room...");
                        else
                            Console.WriteLine("You're not ready to move up in weight.\nPress any key to return to the locker room...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "7":
                        CompFighter compfighter = new CompFighter();
                        Console.WriteLine($"Headling Tonight's UFC Main Event is {firstName} {nickname} {lastName} vs The Champion!\n Press any key to Fight!");
                        Console.ReadKey();
                        Console.Clear();
                        if (fighter.Conditioning + fighter.Strength + fighter.Grappling + fighter.Striking >= compfighter.Power  && fighter.Striking > fighter.Grappling)
                            Console.WriteLine($"You won by Knock Out! Congratulations to the new Champion {firstName} '{nickname}' {lastName}!\nPress any key to return to the gym...");
                       else if(fighter.Conditioning + fighter.Strength + fighter.Grappling + fighter.Striking >= compfighter.Power && fighter.Striking < fighter.Grappling)
                            Console.WriteLine($"You won by Submission! Congratulations to the new Champion {firstName} '{nickname}' {lastName}!\nPress any key to return to the gym...");
                       else if (fighter.Conditioning + fighter.Strength + fighter.Grappling + fighter.Striking >= compfighter.Power  && fighter.Striking == fighter.Grappling)
                            Console.WriteLine($"You won by Unanimous Decision! Congratulations to the new Champion {firstName} '{nickname}' {lastName}!\nPress any key to return to the gym...");
                        else if (fighter.Conditioning + fighter.Strength + fighter.Grappling + fighter.Striking < compfighter.Power)
                            Console.WriteLine("You lost this time, keep training and try again. \nPress Any Key To Get Back In The Gym...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
                fighter.Tick();


            }






        }
    }
}
