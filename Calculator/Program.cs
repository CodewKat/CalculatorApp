//Calculator .NET console application

using CalculatorApp;

double num1, num2;
int choice;

Console.WriteLine("Welcome to my Calculator App!");


while (true)
{
    try
    {
        Console.WriteLine("Please enter your first number");
        num1 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Please enter your second number");
        num2 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Choose an operation");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");

        Console.WriteLine("Enter your choice (1-4)");
        choice = Convert.ToInt32(Console.ReadLine());


        Calculator calculator = new Calculator();

        switch (choice)
        {
            case 1:
                Console.WriteLine($"The result of adding {num1} + {num2} is  {calculator.Add(num1, num2)}");
                break;
            case 2:
                Console.WriteLine($"The result of subtracting {num1} - {num2} is {calculator.Subtract(num1, num2)}");
                break;
            case 3:
                Console.WriteLine($"The result of multiplying {num1} * {num2} is  {calculator.Multiply(num1, num2)}");
                break;
            case 4:
                if (num2 != 0)
                {
                    Console.WriteLine($"The result of dividing {num1} / {num2} is {calculator.Divide(num1, num2)}");
                    break;
                }
                else
                {
                    Console.WriteLine("A non-zero value cannot be used to divide");
                    break;
                }
            default:
                Console.WriteLine("An Invalid choice was entered");
                break;
        }
        Console.ReadLine();
        break;
    }
    catch (Exception)
    {
        Console.WriteLine("Invalid Input! Please try again");
    }
}




