bool prog = true;

while (prog == true)
{
    bool cont = true;
    char operation = ' ';

    Console.Write("Enter a number:\n\n");
    double num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("\n\nEnter another number:\n\n");
    double num2 = Convert.ToInt32(Console.ReadLine());

    while (cont == true)
    {
        Console.WriteLine("\n\nSelect an Operation to Perform:");
        Console.WriteLine("[1] + (Addition)");
        Console.WriteLine("[2] - (Subtraction)");
        Console.WriteLine("[3] * (Multiplication)");
        Console.WriteLine("[4] / (Division)");
        Console.WriteLine("[5] % (Modulus)\n\n");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            operation = '+';
            cont = false;
        }
        else if (choice == 2)
        {
            operation = '-';
            cont = false;
        }
        else if (choice == 3)
        {
            operation = '*';
            cont = false;
        }
        else if (choice == 4)
        {
            operation = '/';
            cont = false;
        }
        else if (choice == 5)
        {
            operation = '%';
            cont = false;
        }
        else
        {
            Console.WriteLine("\n\nInvalid Entry. Please Enter a Value Between 1 and 5\n\n");
        }
    }

    if (operation == '+')
    {
        Console.WriteLine("\n\n" + num1 + " + " + num2 + " = " + (num1 + num2) + "\n\n");
    }
    else if (operation == '-')
    {
        Console.WriteLine("\n\n" + num1 + " - " + num2 + " = " + (num1 - num2) + "\n\n");
    }
    else if (operation == '*')
    {
        Console.WriteLine("\n\n" + num1 + " * " + num2 + " = " + (num1 * num2) + "\n\n");
    }
    else if (operation == '/')
    {
        Console.WriteLine("\n\n" + num1 + " / " + num2 + " = " + (num1 / num2) + "\n\n");
    }
    else if (operation == '%')
    {
        Console.WriteLine("\n\n" + num1 + " % " + num2 + " = " + (num1 % num2) + "\n\n");
    }

    Console.WriteLine("Use Calculator Again?");
    Console.WriteLine("[1] Yes");
    Console.WriteLine("[Any Other Key] No\n\n");

    int choice2 = Convert.ToInt32(Console.ReadLine());

    if (choice2 == 1)
    {
        Console.WriteLine("\n\n" + "Here We Go...\n\n");
    } else
    {
        prog = false;
    }
}