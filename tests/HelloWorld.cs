using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Write your option:\n");
        Console.WriteLine("1. WriteHelloName\n2. getSumDoubles\n3. testParseStringToInt");

        try
        {
            int option = int.Parse(Console.ReadLine());
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }

        switch (option)
        {
            case 1:
                writeHelloName("Diego");
                break;
            case 2:

        }
            



            Console.WriteLine(getSumDoubles(2.5, 3.26));

            testParseStringToInt();
        }

        public static void writeHelloName(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        public static double getSumDoubles(double num1, double num2)
        {
            return num1 + num2;
        }

        public static void testParseStringToInt()
        {
            Console.WriteLine("Write a number: ");
            string stringGotten = Console.ReadLine();

            try
            {
                int numberParsed = int.Parse(stringGotten);
            }
            catch (Exception e)
            {
                Console.WriteLine("Format Exception");
                Console.WriteLine(e.Message);
            }
        }
    }