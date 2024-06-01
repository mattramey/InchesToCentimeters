using System;

class InchesToCentimeters
{// open class InchesToCentimeters

    // declare a constant for inches to centimeter conversion
    public const double CentimetersConversion = 2.54;

     

    public static void Main(string[] args)
    {// open Main

        // use a for loop to iterate 4 times while asking user to enter a number of inches to convert
        for (int i = 1; i <= 4; i++)
        {//open forloop
         //prompt the user to enter a number of inches to convert
            Console.WriteLine("Enter a number of inches to convert to centimeters");
            // variable to represent measurement in inches set variable = to Console.Readline in order to be stored as the users input
            string input = Console.ReadLine();

            //create a method that will take the user input and parse it to the double data type variable inches. If the conversion is successful then create a new variable that multiplies the inches variable with the constant CentimetersConversion. (line27)
            if (double.TryParse(input, out double inches)) {//open if
                
// calculate the actual centiemters based off of the number the user enters and the constant CentimetersConversion (*2.54).
                double actualCentimeters = inches * CentimetersConversion;

                double centimeters = inches * CentimetersConversion;
                
                // use string interpolation to display the user input and the converted measurement in centimeters.
                Console.WriteLine($"{inches} inches equals {centimeters} centimeters");
                Console.WriteLine();
                // print out the the test passed after a succeful parse and conversion to centimeters.

// create an if else to check if the unit test passes or not. the method Math.Abs will check the absolute value of both the centimeters and the actualCentimeters. If the difference in absolute value of the centimeters is less than .01 the test passes.
                if (Math.Abs(centimeters - actualCentimeters) < 0.01){// open if
                      Console.WriteLine("unit test passed");
                  }// end if
                  else
                  {// open else
                      Console.WriteLine("unit test failed");
                  }// end else
            
                Console.WriteLine();
               

            }//close if 
             // error handle if the user enters a non-numeric value
            else
            {//open else
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please enter a valid number");
            }// close else


        }// close forloop
    }// close Main
   
}// close class InchesToCentimeters