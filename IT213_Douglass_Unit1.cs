using System;

namespace IT213_Douglass_Unit1
{
    class Program
    {
        private static string monthlyPayment;

        static void Main(string[] args)
        {
            //here are my string variables
            String name = "John Smith";
            String address = "101 N. Main Street";
            String city = "Anytown";
            String state = "TX";
            String zipCode = "11111";
            String unitsTaken = "19";

            //constant numeric variables
            const double pricePerUnit = 100.50;
            const double discount = 150;

            // string value to unitsTaken
            int intUnitsTaken = Convert.ToInt32(unitsTaken);

            // increment units by one still confused
            intUnitsTaken++;

            // Multiplying the constant variable for price per unit to answer tution easy 
            double tuition = pricePerUnit * intUnitsTaken;

            // subtracting the const discount value from tuition and make answer to afterDiscount (variable)
            double afterDiscount = tuition - discount;

            // divide discount from 12 to get monthlyPayment
            double monthlyPayment = afterDiscount / 12;

            // output
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("City: " + city);
            Console.WriteLine("State: " + state);
            Console.WriteLine("Zip Code: " + zipCode);

            Console.WriteLine("The number of units taken is: " + intUnitsTaken);

            // format tuition values and monthly payment as currency and display
            Console.WriteLine(string.Format("The tuition before discount is {0:C}", tuition));
            Console.WriteLine(string.Format("The tuition after the discount is {0:C}", afterDiscount));
            Console.WriteLine(string.Format("your monthly payment is: {0:C}", monthlyPayment));

            //keep console window open
            Console.Read();



        }
    }
} //end of program
