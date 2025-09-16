namespace Topic_5._3___Multiple_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1

            int age;

            Console.WriteLine("Hello! How old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("");

            if (age >= 13 && age <= 19)
            {
                Console.WriteLine("Teenagers scare the living shit out of me.");
            }

            else
            {
                Console.WriteLine("Congratulations! You are not a teenager.");
            }

            //Programming tasks

            //Task 1

            double money;
            string work;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Are you working tonight?");
            work = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("How much money do you have?");
            double.TryParse(Console.ReadLine(), out money);

            Console.WriteLine("");

            if (work.ToUpper() == "N" && money >= 20)
            {
                Console.WriteLine("Congratulations! You can go to the movies!");
            }

            else
            {
                Console.WriteLine("You cannot go to the movies.");
            }

            //Task 2

            int guesses;
            string userGuess;

            guesses = 0;

            //1
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Guess the password.");
            userGuess = Console.ReadLine();
            Console.WriteLine("");

            if (userGuess.ToLower() == "password" && guesses < 5)
            {
                Console.WriteLine("Open Sesame!");
            }
            else
            {
                guesses += 1;
                Console.WriteLine("Incorrect. You have " + (5 - guesses) + " guesses remaining.");
            }

            //2
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Guess the password.");
            userGuess = Console.ReadLine();
            Console.WriteLine("");

            if (userGuess.ToLower() == "password" && guesses < 5)
            {
                Console.WriteLine("Open Sesame!");
            }
            else
            {
                guesses += 1;
                Console.WriteLine("Incorrect. You have " + (5 - guesses) + " guesses remaining.");
            }

            //3
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Guess the password.");
            userGuess = Console.ReadLine();
            Console.WriteLine("");

            if (userGuess.ToLower() == "password" && guesses < 5)
            {
                Console.WriteLine("Open Sesame!");
            }
            else
            {
                guesses += 1;
                Console.WriteLine("Incorrect. You have " + (5 - guesses) + " guesses remaining.");
            }

            //4
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Guess the password.");
            userGuess = Console.ReadLine();
            Console.WriteLine("");

            if (userGuess.ToLower() == "password" && guesses < 5)
            {
                Console.WriteLine("Open Sesame!");
            }
            else
            {
                guesses += 1;
                Console.WriteLine("Incorrect. You have " + (5 - guesses) + " guess remaining.");
            }

            //5
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Guess the password.");
            userGuess = Console.ReadLine();
            Console.WriteLine("");

            if (userGuess.ToLower() == "password" && guesses < 5)
            {
                Console.WriteLine("Open Sesame!");
            }
            else
            {
                Console.WriteLine("Access denied.");
            }

            //Part 2

            string pizzaTopping;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("What is your favourite pizza topping?");
            pizzaTopping = Console.ReadLine();
            Console.WriteLine("");

            if (pizzaTopping.ToLower() == "ham" || pizzaTopping.ToLower() == "pineapple" || pizzaTopping.ToLower() == "bacon")
            {
                Console.WriteLine("Yummy!");
            }
            else
            {
                Console.WriteLine("Gross!");
            }

            //Programming tasks

            //task 1

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Welcome to the bus station! Enter your age: ");
            Int32.TryParse(Console.ReadLine(), out age);

            Console.WriteLine("");
            Console.WriteLine("");

            if (age <= 12 || age >= 60)
            {
                Console.WriteLine("Your ticket costs: $2.00");
            }
            else
            {
                Console.WriteLine("Your ticket costs: $3.50");
            }

            //task 2

            string favouriteAnimal;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("What is your favourite animal?");
            favouriteAnimal = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("");

            if (favouriteAnimal.ToLower() == "dog" || favouriteAnimal.ToLower() == "horse")
            {
                Console.WriteLine("Me too!");
            }
            else
            {
                Console.WriteLine("To each their own.");
            }

            //task 3

            double temperature;
            string weather;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("What is the temperature outside?");
            double.TryParse(Console.ReadLine(), out temperature);

            Console.WriteLine("");
            Console.Write("What is the weather like?");
            weather = Console.ReadLine();

            Console.WriteLine("");

            if (temperature >= 25 || weather.ToLower() == "sunny")
            {
                Console.WriteLine("Swim time!");
            }
            else
            {
                Console.WriteLine("Nap time!");
            }

                //
                Console.ReadLine();
        }
    }
}
