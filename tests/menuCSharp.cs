using System;

public class menuCSharp
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("- MENU -\n");
            Console.WriteLine("1. WriteHelloName\n2. getSumDoubles\n3. testParseStringToInt\n4. intDividedByZero\n5. tryParseStringToInt\n6. countsTo100\n7. countsToNumber\n0. Exit");
            Console.Write("\nWrite your option: ");

            try
            {
                int option = int.Parse(Console.ReadLine());
                Console.Write("\n");

                switch (option)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        writeHelloName("Diego");
                        break;
                    case 2:
                        getSumDoubles(2, 3);
                        break;
                    case 3:
                        testParseStringToInt();
                        break;
                    case 4:
                        intDividedByZero();
                        break;
                    case 5:
                        tryParseStringToInt();
                        break;
                    case 6:
                        countsTo100();
                        break;
                    case 7:
                        countsToNumber();
                        break;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    public static void writeHelloName(string name)
    {
        Console.WriteLine("Hello " + name);
    }

    public static void getSumDoubles(double num1, double num2)
    {
        Console.WriteLine(num1 + num2);
    }

    public static void testParseStringToInt()
    {
        Console.Write("Write a number: ");
        string stringGotten = Console.ReadLine();

        try
        {
            int numberParsed = int.Parse(stringGotten);
            Console.WriteLine("The String ('" + stringGotten + "') parsed to Int (" + numberParsed + ") successfully");
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void intDividedByZero()
    {
        int num1 = 5;
        int num2 = 0;

        try
        {
            int result = num1 / num2;
        }
        catch (Exception e) { Console.WriteLine(e.Message); }
    }

    public static void tryParseStringToInt()
    {
        Console.Write("Enter a number in order to be parsed: ");
        string numberAsString = Console.ReadLine();
        int parsedValue;

        bool success = int.TryParse(numberAsString, out parsedValue);

        if (success)
        {
            Console.WriteLine("Parsing successfully - number is: " + parsedValue);
        }
        else
        {
            Console.WriteLine("Parsing failed");
        }
    }

    public static void countsTo100()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void countsToNumber()
    {
        Console.Write("Enter a number: ");
        string numberAsString = Console.ReadLine();
        int number;

        bool validParse = int.TryParse(numberAsString, out number);

        if (validParse)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.Write("Entered value incorrect");
        }
    }
}