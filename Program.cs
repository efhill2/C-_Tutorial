// See https://aka.ms/new-console-template for more information

//CTutorial.Program.writeSomething();
//CTutorial.Program.writeSomethingSpecific("I am an argument and Im called from a method");

//Console.WriteLine(CTutorial.Program.add(15, 31));
//Console.WriteLine(CTutorial.Program.add(CTutorial.Program.add(1,2), CTutorial.Program.add(3, 4)));

//Console.WriteLine(CTutorial.Program.multiply(15, 30));

//Console.WriteLine(CTutorial.Program.divide(1988, 34));

//CTutorial.Program.heyFriends("Jasmine", "Kenny", "Mercedes");

//CTutorial.Program.lowUpper("HeY ThErE !");

//CTutorial.Program.userInput();

//Console.WriteLine($"Equals {CTutorial.Program.calculate()}");
//Console.Read();

//CTutorial.Program.tryCatchExample();

//CTutorial.Program.tryParseExample2();

//CTutorial.Program.ifStatements();

CTutorial.Program.oddOrEven();


namespace CTutorial
{
    class Program
    {
        //Access Modifier (static), Return Type, Method Name (param 1, param 2)
        public static void writeSomething()
        {
            Console.WriteLine("Let's see if this works");
        }

        public static void writeSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int multiply(int num1, int num2)
        {
            return num1 * num2;

        }

        public static double divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public static void heyFriends(string name1, string name2, string name3)
        {
            Console.WriteLine("Hey " + name1 + ", " + name2 + ", and " + name3 + ", How's life?");
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

        public static void ifStatements()
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

    }
}


