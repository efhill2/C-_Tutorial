// See https://aka.ms/new-console-template for more information

// CTutorial.Program.writeSomething();

// CTutorial.Program.writeSomethingSpecific("I am an argument and Im called from a method");

// CTutorial.Program.heyFriends("Jasmine", "Steven", "Kenny", "Mercedes");

// CTutorial.Program.lowUpper("HeY ThErE !");

// CTutorial.Program.userInput();
// Console.WriteLine($"Equals {CTutorial.Program.calculate()}");
// Console.Read();

// CTutorial.Program.tryCatchExample();

// CTutorial.Program.tryParseExample();

// CTutorial.Program.tryParseExample2();

// CTutorial.Program.tempertureGuage();

// CTutorial.Program.guessingGame();

// CTutorial.Program.doYouNeedParentSupervision();

// CTutorial.Program.calenderMonths();

// CTutorial.Program.oddOrEven();

// CTutorial.Program.nestedIfStatements();

// CTutorial.Program.userLoginExample();

// CTutorial.Program.calculateAverage();

// CTutorial.Program.incrementing();

namespace CTutorial
{
    class Program
    {
        //Public Method, Access Modifier (static), Return Type (void), Method Name ()
        //Simple Method that outputs a string 
        public static void writeSomething()
        {
            Console.WriteLine("Let's see if this works");
            Console.Read();
        }
        //Showing how to call an arrgument
        public static void writeSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        //A method showing the different types of string manipulation
        public static void heyFriends(string name1, string name2, string name3, string name4)
        {
            //String Concatination
            Console.WriteLine("Hey " + name1 + ", " + name2 + ", " + name3 + " , and " + name4 + ", How's life?");
            //String Interpolation
            Console.WriteLine($"Hey {name1}, {name2}, {name3} , and {name4}, How's Life?");
            //String Formatting 
            Console.WriteLine("Hey {0}, {1}, {2}, and {3}, How's life?", name1, name2, name3, name4);

            string randomWords = "This is a \"string\" with a \\ and a colon: ";
            Console.WriteLine(randomWords);
        }

        //public static void lowUpper(string s)
        //{
        //    string Low = s.ToLower();
        //    string Up = s.ToUpper();
        //    int count = Low.Length + Up.Length;
        //    Console.WriteLine(Low + Up);
        //    Console.WriteLine($"The amount of characters is {count}");
        //}        

        public static string lowUpper(string s)
        {
            return s.ToLower() + s.ToUpper();
        }

        public static void Count(string s)
        {
            Console.WriteLine("The amount of characters is {0}.", s.Length);
        }

        public static void userInput()
        {
            string userText = Console.ReadLine();
            Console.WriteLine(userText);
            Console.Read();
        }

        public static int calculate()
        {
            Console.WriteLine("Enter first number!");
            string num1Input = Console.ReadLine();
            Console.WriteLine("Enter second number!");
            string num2Input = Console.ReadLine();

            int num1 = int.Parse(num1Input);
            int num2 = int.Parse(num2Input);

            int result = num1 + num2;
            return result;
        }

        public static void tryCatchExample()
        {
            Console.WriteLine("Please enter your age (As a number)!");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);

            }
            catch (FormatException)
            {
                throw;
                //Console.WriteLine("Wrong Format: Numbers ONLY!!!");
            }
            catch (OverflowException)
            {
                throw;
                //Console.WriteLine("Too Long: Use fesiable age!!");
            }
            catch (ArgumentNullException)
            {
                throw;
                //Console.WriteLine("Nothing Entered!!");
            }
            finally
            {
                Console.WriteLine("Unknown Error");
            }
            Console.ReadKey();
        }

        public static void tryParseExample()
        {
            Console.WriteLine("Give me a number");

            string inputString = Console.ReadLine();
            int num1;

            bool isNumber = int.TryParse(inputString, out num1);

            if(isNumber)
            {
                Console.WriteLine("Correct input entered!");
            }
            else
            {
                Console.WriteLine("Wrong input entered!");
            }

            num1++;

            Console.WriteLine("User entered number + 1" , num1);

            Console.ReadKey();
        }

        public static void tryParseExample2()
        {
            string numberAsString = "0304";
            int parsedValue;

            bool success = int.TryParse(numberAsString, out parsedValue);

            if (success)
            {
                Console.WriteLine("Parsing Successful - number is " + parsedValue);
            }
            else
            {
                Console.WriteLine("Parsing Failed");
            }
            Console.Read();
        }

        public static void operators()
        {
            int num1 = 5;
            int num2 = 3;
            int result;

            //unary operators
            result = -num1;
            Console.WriteLine("Result is {0}", result);

            //bool
            bool isSunny = true;
            Console.WriteLine("Is it sunny? {0}", !isSunny);

            //post increment
            int num3 = 0;
            num3++;
            Console.WriteLine("Num is now {0}", num3);

            //pre increment
            int num4 = 0;
            ++num4;
            Console.WriteLine("Num is now {0}", num4);

            //post dncrement
            int num5 = 0;
            num5++;
            Console.WriteLine("Num is now {0}", num5);

            //pre dncrement
            int num6 = 0;
            ++num6;
            Console.WriteLine("Num is now {0}", num6);

        }

        public static void tempertureGuage()
        {
            Console.WriteLine("Please enter the temperture.");
            string userInput = Console.ReadLine();

            int userTempInput;
            int tempNumber;
            bool userEnteredNumber = int.TryParse(userInput, out userTempInput);

            if (userEnteredNumber)
            {
                tempNumber = userTempInput;
            }
            else
            {
                tempNumber = 0;
                Console.WriteLine("Wrong value entered, ONLY NUMBERS!! Temperature set to 0");
            }

            if (tempNumber < 50)
            {
                Console.WriteLine("Take a coat with you.");
            }
            else if (tempNumber == 50)
            {
                Console.WriteLine("Wear a thermal.");
            }
            else
            {
                Console.WriteLine("I can wear shorts");
            }

            Console.Read();
        }

        public static void guessingGame()
        {
            // Creating an instance of Random Class
            Random random = new Random();
            // Create a random number from 1 - 10
            int randomNumber = random.Next(1, 11);
            Console.WriteLine("Number Matching Game");
            Console.WriteLine("Enter a number between 1 and 10");
            string userNumberGuess = Console.ReadLine(); 
            int number;

            bool isNumber = int.TryParse(userNumberGuess, out number);

            if(isNumber)
            {
                if(randomNumber == int.Parse(userNumberGuess))
                {
                    Console.WriteLine($"Correct, You're Lucky. The numbers were: {randomNumber} and {userNumberGuess}");

                    Console.WriteLine("Please enter your age");
                    int age = int.Parse(Console.ReadLine());    
                    
                    if(age >=21)
                    {
                        Console.WriteLine("Congrats, sending a Drink package your way!");
                    }
                    else
                    {
                        Console.WriteLine("Congrats, sending a Snack package your way!");
                    }
                }
                else
                {
                    Console.WriteLine($"Wrong, Luck is not on your side! The numbers were: {randomNumber} and {userNumberGuess}");
                }
            }
            else
            {
                Console.WriteLine("Wrong Input!");
            }

           
            Console.ReadKey();

        }    

        public static void doYouNeedParentSupervision()
        {
            Console.WriteLine("A party for your town has arrived and everyone is invited");
            Console.WriteLine("First: Enter your age");
            int age = int.Parse(Console.ReadLine());

            if(age >= 21)
            {
                Console.WriteLine("Adult Drinking Ticket");
            }
            else if(age >=18 && age <= 20)
            {
                Console.WriteLine("Adult Nondrinking Ticket");
            }
            else if(age <=17)
            {
                Console.WriteLine("Are you with your parents? Answer with \"Yes\" or \"No\"");
                string withParents = Console.ReadLine();
                
                if(withParents == "Yes")
                {
                    Console.WriteLine("Youth Ticket with Parents");
                }
                else
                {
                    Console.WriteLine("You need to have your parents with you!");
                }
            }
        }

        public static void calenderMonths()
        {
            Console.WriteLine("Number of the Months");
            int month = int.Parse(Console.ReadLine());
            string monthName;

            // if(month == 1)
            //     monthName = "January";
            // else if(month == 2)
            //     monthName = "February";
            // else if(month == 3)
            //     monthName = "March";
            // else if(month == 4)
            //     monthName = "April";
            // else if(month == 5)
            //     monthName = "May";
            // else if(month == 6)
            //     monthName = "June";
            // else if(month == 7)
            //     monthName = "July";
            // else if(month == 8)
            //     monthName = "August";
            // else if(month == 9)
            //     monthName = "September";
            // else if(month == 10)
            //     monthName = "October";
            // else if(month == 11)
            //     monthName = "November";
            // else if(month == 12)
            //     monthName = "December";
            // else
            //     monthName = "Unknown";

            switch(month)
            {
                case 1:
                    monthName = "January";
                    break;
                 case 2:
                    monthName = "February";
                    break;
                 case 3:
                    monthName = "March";
                    break;
                 case 4:
                    monthName = "April";
                    break;
                 case 5:
                    monthName = "May";
                    break;
                 case 6:
                    monthName = "June";
                    break;
                 case 7:
                    monthName = "July";
                    break;
                 case 8:
                    monthName = "August";
                    break;
                 case 9:
                    monthName = "September";
                    break;
                 case 10:
                    monthName = "October";
                    break;
                 case 11:
                    monthName = "November";
                    break;
                 case 12:
                    monthName = "December";
                    break;
                default:
                    monthName = "Unknown";
                    break;
            }

            Console.WriteLine($"The month is {monthName}");

        }
        public static void oddOrEven()
        {
            Console.WriteLine("Please enter a number.");
            string userInput = Console.ReadLine();

            int userNumber;
            int number;
            bool userEnteredNumber = int.TryParse(userInput, out userNumber);

            if (userEnteredNumber)
            {
                number = userNumber;
            }
            else
            {
                number = 0;
                Console.WriteLine("Please enter a number");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is a even number");
            }
            else
            {
                Console.WriteLine(number + " is a odd number");
            }

            Console.ReadLine();
        }

        public static void nestedIfStatements()
        {
            int number;
            Console.WriteLine("Please Enter a number");
            bool stringNumber = int.TryParse(Console.ReadLine(), out number);



            if (number % 3 == 0)
            {
                Console.WriteLine("The number is equal to " + number + ", Divisible by 3");
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("The number is equal to " + number + ", Divisible by 7");
            }
            else if (number % 2 != 0)
            {
                Console.WriteLine("The number is equal to " + number + ", Odd number");
            }
            else
            {
                Console.WriteLine("The number is equal to " + number + ", Even number");
            }
            
            Console.Read();
        }

        public static void userLoginExample()
        {
            string userName = "Eugene";
            string password = "EFHill35";

            Console.WriteLine("Please enter your User Name");
            userName = Console.ReadLine();

            Console.WriteLine("Please enter your Password");
            password = Console.ReadLine();

            if (userName.Equals("Eugene") && password.Equals("EFHill35"))
            {
                Console.WriteLine("Welcome Back");
            }
            else
            {
                Console.WriteLine("Error: Wrong Infomation");
            }
            Console.Read();

        }

        public static void calculateAverage()
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;

            int average = (num1 + num2 + num3) / 3;
            Console.WriteLine("The average is: " + average);
        }

        public static void incrementing()
        {
            /*
            int num = 0; 

            Console.WriteLine($"Number is {num}");
            // incrementing of int
            num++;
            Console.WriteLine($"Number is {num}");

            // Pre Incrementing 
            Console.WriteLine("Num is {0}", ++num);
            Console.WriteLine("Num is {0}", num++);
            Console.WriteLine("Num is {0}", num);

            // decrementing
            num--;
            Console.WriteLine("Num is {0}", num);
            Console.WriteLine("Num is {0}", --num);
            Console.WriteLine("Num is {0}", num--);
            Console.WriteLine("Num is {0}", num);

            num += 30;
            Console.WriteLine("Num is {0}", num);
            num -= 10; 
            Console.WriteLine("Num is {0}", num);
            num *= 10;
            Console.WriteLine("Num is {0}", num);
            num /= 20;
            Console.WriteLine("Num is {0}", num);
            */

            int num1 = 10; 
            int num2 = 3; 

            int result = num1%num2; 

            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}


