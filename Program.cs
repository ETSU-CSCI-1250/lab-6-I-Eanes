/*
 * 
 * This switch statement allows the user to choose which method they would like to be ran.
 * And yes, I disliked creating variables in the actual code but its easier that way.
 * (Also switch statement usage was borrowed from Mark M. while we were cooperating on this assignment.)
 * 
 */

Console.WriteLine($"Which method do you want to run? \n 1. Show Character \n 2. Retail Price \n " +
    $"3. Temperature Table \n 4. Prime Numbers \n");
int chosenMethod = Convert.ToInt32(Console.ReadLine());

switch(chosenMethod)
{
    case 1:
        Console.WriteLine("What text would you like to input?");
        string inputText = Console.ReadLine();
        Console.WriteLine("Which char would you like?");
        int inputChar = Convert.ToInt32(Console.ReadLine());
        ShowCharacter(inputText, inputChar);
        break;
    case 2:
        Console.WriteLine("What is the wholesale cost?");
        double inputWholesale = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("What is the markup percentage?\n (do not include the %)");
        double inputMarkup = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("The new price of the item is: " + Math.Round(CalculateRetail(inputWholesale, inputMarkup), 2) + ".");
        break;
    case 3:
        Console.WriteLine("What is the temperature in fahrenheit?");
        double inputTemp = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("The temperature in celsius is " + Celsius(inputTemp) + ". ");
        break;
    case 4: 
        Console.WriteLine("What number would you like to test?");
        int numInput = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The number is prime: " + IsPrime(numInput) + ".");
        break;
    default:
        Console.Write("Sorry wrong entry, please retry");
        break;
}

/*
 * 
 * The method for ShowCharacter
 * 
 */

static void ShowCharacter(string inputText, int charRequest)
{
    Console.WriteLine(inputText[(charRequest-1)]);
}

/*
 * 
 * The method for CalculateRetail
 * 
 */

static double CalculateRetail(double inputAmount, double markupAmount)
{
    return (inputAmount * ((markupAmount/100)+1));
}

/*
 * 
 * The method for Celsius, 
 * I'm still not sure to what decimal point a temperature should be but I guessed to the tenths
 * 
 */

static double Celsius(double fahrenheit)
{
    double celsCalc = (5.00 / 9.00);
    return Math.Round((celsCalc * (fahrenheit-32)), 1);
}

/*
 * 
 * The IsPrime method, 
 * I did this in class without realizing it was for a lab and 
 * just thought it would be funny to figure out a way to do it other than the demonstrations. 
 * Just a fun fact.
 * 
 */

static bool IsPrime(int numInput)
{
    int num = 2;
    while (num < numInput)
    {
        if (numInput % num == 0)
        {
            return false;
        }
        else
        {
            num++;
        }

    }
    return true;
}


