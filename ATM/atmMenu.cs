int pin = 1450, sum = 100000, pin1, pin2, pin3, enter, getSum;

Console.WriteLine("Enter your Ping");
pin1 = Convert.ToInt32(Console.ReadLine());
if (pin1 == pin)
{
    Console.WriteLine("Please, choose a one of this services: \n");

    Console.WriteLine("1. Check balance");

    Console.WriteLine("2. Get a money");

    Console.WriteLine("3. Deposite");

    Console.WriteLine("4. Change a PIN");

    Console.WriteLine("0. Exit \n");

    Console.WriteLine();

    enter = Convert.ToInt32(Console.ReadLine());
    switch (enter)
    {
        case 1:
            if (enter == 1)
            {
                Console.WriteLine($"Account balance is {sum}\n");
            }
            else
            {
                Console.WriteLine("Error");
            }
            break;
        case 2:
            if (enter == 2)
            {
                Console.Write("Write a sum that you need! \n");
                getSum = Convert.ToInt32(Console.ReadLine());
                if (getSum > sum)
                {
                    Console.WriteLine("You don`t have so much money!\n");
                    return;
                }
                else if (getSum <= sum)
                {
                    sum -= getSum;
                    Console.WriteLine($"Your Balance is {sum}, \n please don`t forget to get money: {getSum}\n");
                }
            }
            break;
        case 3:
            if (enter == 3)
            {
                Console.Write("Write a sum that you need to deposite!\n");
                getSum = Convert.ToInt32(Console.ReadLine());
                sum += getSum;
                Console.Write($"Total deposit amount is {sum}");
            }
            break;
        case 4:
            if (enter == 4)
            {
                Console.Write("write your previus PIN: \n\n");

                pin2 = Convert.ToInt32(Console.ReadLine());
                if (pin2 == pin)
                {
                    Console.WriteLine($"New PIN:\n");
                    pin3 = Convert.ToInt32(Console.ReadLine());
                    pin = pin3;
                    Console.WriteLine($"Your new PIN is {pin}");
                }
                else
                {
                    Console.Write("Wrong PIN, please, try again!\n");
                }
            };
            break;
        case 0:
            if (enter == 0)
            {
                Console.Write("Good Luck!\n");
            }
            break;
    }
}
else
{
    Console.WriteLine("Error! Wrong PIN\n");
}