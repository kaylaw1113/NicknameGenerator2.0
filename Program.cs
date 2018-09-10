using System;

namespace NicknameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random adjectives = new Random();
            
            // string[] Happy = {"Cheerful", "Delighted", "Glad", "Joyful", "Chipper"};
            // string[] Sad = {"Bitter", "Somber", "Pessimistic", "Glum", "Morbid"};
            // string[] Brave = {"Adventurous", "Audacious", "Fearless", "Nervy", "Plucky"};
            // string[] Sleepy = {"Slumberous", "Hypnotic", "Sluggish", "Dopey", "Snoozy"}; 
            // string[] Smart = {"Wise", "Clever", "Brilliant", "Sharp", "Resourceful"};
            
                     

            Console.WriteLine("Please enter your name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Here is a list of adjectives: Happy, Sad, Brave, Sleepy, Smart. Enter the adjective that best describes you: ");
           
            string adjective = Console.ReadLine();
            

            switch (adjective){

                case "Happy":
                        string[] Happy = new string[5] {"Cheerful", "Delighted", "Glad", "Joyful", "Chipper"};
                        adjective = Happy[adjectives.Next(1,4)];
                        Console.WriteLine("{0}" + " {1}", adjective, name );
                        break;

                case "Sad":
                        string[] Sad = new string[5] {"Bitter", "Somber", "Pessimistic", "Glum", "Morbid"};
                        adjective = Sad[adjectives.Next(1,4)];
                        Console.WriteLine("{0}" + " {1}", adjective, name );
                        break;

                case "Brave":
                        string[] Brave = {"Adventurous", "Audacious", "Fearless", "Nervy", "Plucky"};
                        adjective = Brave[adjectives.Next(1,4)];
                        Console.WriteLine("{0}" + " {1}", adjective, name );
                        break;


                case "Sleepy":
                        string[] Sleepy = {"Slumberous", "Hypnotic", "Sluggish", "Dopey", "Snoozy"};
                        adjective = Sleepy[adjectives.Next(1,4)];
                        Console.WriteLine("{0}" + " {1}", adjective, name );
                        break;


                case "Smart":
                        string[] Smart = {"Wise", "Clever", "Brilliant", "Sharp", "Resourceful"};;
                        adjective = Smart[adjectives.Next(1,4)];
                        Console.WriteLine("{0}" + " {1}", adjective, name );
                        break;                
            }
           

            /*set a list of adjective the user can choose from. 
            create synonyms arrays from the adjectives given
            maybe use if statement to know which array to use
            randomize the array list
            play with output format
            */
        }
    }
}
