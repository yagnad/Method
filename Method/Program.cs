using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an age between 18 and 100 years");
            //Gather user data from the input
            string input = Console.ReadLine();
            int age = int.Parse(input);

            //Validate user input using try catch block
            try
            {   //If the user input is between integers 18 and 100 use a if statement to test it
                if ((age > 17) && (age <= 100))
                {
                    int get_max_heart_rate = Max_Heart_Rate(age);

                    Console.WriteLine("\nBased on your age you entered: " + age);
                    Console.WriteLine("Your maximum heart rate during exercise should be  " + get_max_heart_rate);

                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }

                //Show the default message to gather valid user input
                else
                {
                    Console.Write("Please input a valid age between 18 and 100 years");
                    Console.WriteLine("Press any key to exit the program..");
                    Console.ReadKey(true);

                }


            }//End of try block
            //Display an error message for bad input
            catch
            {
                Console.Write("Please input a valid age between 18 and 100 years");
                Console.WriteLine("Press any key to exit the program..");
                Console.ReadKey(true);

            }//End of catch block
        }//Emd of Main

        //This static value return method calculates the max heart rate.
        private static int Max_Heart_Rate(int get_age)
        {
            //Formula for calculating the max heart rate during exercise
            int calc_max_heart_rate = 220 - get_age;

           

            return calc_max_heart_rate;
        }//End of Max heart rate method




    }//End of class
}//End of namesapace
