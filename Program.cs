using System;

class Program
{
    static void Main()
    {
        // Example using TryParse method to convert string to int
        Console.WriteLine("Enter a number");
        string a = Console.ReadLine();
        if (int.TryParse(a, out int result))
        {
            Console.WriteLine("Parsed number using int parse is :" + result);
        }
       
        else
        {
            Console.WriteLine("TryParse failed.Invalid input string.");
        }

        // Example using Convert method to convert string to double
        Console.WriteLine("Enter a number");
        string doubleString = Console.ReadLine();
        try
        {
            double doubleValue = Convert.ToDouble(doubleString);
            Console.WriteLine("Convert successful. Converted double value: " + doubleValue);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Invalid input format."+e);
        }
        catch (OverflowException oe)
        {
            Console.WriteLine("Input value is large"+oe);
        }
        catch(Exception ex) {
            Console.WriteLine("Exception"+ex.Message);
        }

        // using Parse method to convert string to decimal
        Console.WriteLine("Enter a number");
        string decimalString = Console.ReadLine();
        try
        {
            decimal decimalValue = decimal.Parse(decimalString);
            Console.WriteLine("Parse successful. Converted decimal value: " + decimalValue);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Invalid input format."+e);
        }
        catch (OverflowException oe)
        {
            Console.WriteLine("Input value is large "+oe);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception" + ex.Message);
        }
        finally { Console.WriteLine("End of Problem statement1"); }
        
        //

        //END OF PROBLEM STATEMENT1
        
        Console.ReadKey();
    }
}