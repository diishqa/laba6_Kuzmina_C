//try
//{
//    int number1 = int.Parse(Console.ReadLine());
//    int number2 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(number1 / number2);
//} catch(DivideByZeroException ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}
//catch (FormatException ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}
//finally
//{
//    Console.WriteLine("Продожение работы");
//}

//try
//{
//    Console.Write("Введите первое число: ");
//    int number1 = int.Parse(Console.ReadLine());
//    Console.WriteLine("Введите второе число:");
//    int number2 = int.Parse(Console.ReadLine());
//    Console.WriteLine("Введите операцию (+, *, :, -)");
//    string operation = Console.ReadLine();
//    int result = 0;
//    switch (operation)
//    {
//        case "+": result = number1 + number2; break;
//        case "-": result = number1 - number2; break;
//        case "*": result = number1 * number2; break;
//        case ":":
//            if (number2 == 0)
//            {
//                throw new DivideByZeroException("Ошибка деления на ноль");
//            }
//            result = number1 / number2; break;
//        default: Console.WriteLine("Неизвестная операция"); break;
//    }
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}
//catch (FormatException ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}

//int number = 12;
//Console.WriteLine(number.ToString());
//bool test = false;
//Console.WriteLine(test.ToString());
//DateTime dateTime= DateTime.Now;
//Console.WriteLine(dateTime.ToString());
//int age = int.Parse("27");
//DateTime brithDay = DateTime.Parse("28 May 1980");
//Console.WriteLine($"{brithDay:D}");
//int count = int.Parse("sdfsdf");
//string input = Console.ReadLine();
//if (int.TryParse(input, out int result))
//{
//    Console.WriteLine(result);
//}
//else
//{
//    Console.WriteLine("Некорректный ввод");
//}
//using System.Linq.Expressions;

//try
//{
//    checked
//    {
//        byte x = 254;
//        Console.WriteLine(x);
//        x++;
//        Console.WriteLine(x);
//        x++;
//        Console.WriteLine(x);

//    }
//} catch (OverflowException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//using System.Runtime.CompilerServices;

//Console.WriteLine("Введите суму: ");
//string? amount = Console.ReadLine();
//try
//{
//    decimal amountValue = decimal.Parse(amount);
//} catch (FormatException) when (amount.Contains("$"))
//{
//    Console.WriteLine("В суммах нельзя исползовать знак доллара!");
//} catch (FormatException)
//{
//    Console.WriteLine("Суммы должны соержать только цифры");
//}

//try
//{
//    checked
//    {
//        int x = int.MaxValue - 1;
//        Console.WriteLine($"Initial value: {x}");
//        x++;
//        Console.WriteLine($"After incrementing: {x}");
//        x++;
//        Console.WriteLine($"After incrementing: {x}");
//        x++;
//        Console.WriteLine($"After incrementing: {x}");

//    }
//} catch (OverflowException ex)
//{
//    Console.WriteLine("The code overflowed but I caught the exception");
//}

//static double Add(double a, double b)
//{
//    return a * b;
//}
//double a = 4.5;
//double b = 2.5;
//double answer=Add(a,b);
//Console.WriteLine($"{a} + {b} = {answer}");
//Console.WriteLine("Нажмите ENTER чтобы продолжить");

//задание 1

//static double plus(double a, double b) { return a + b; }
//static double minus(double a, double b) { return a - b; }
//static double umn(double a, double b) { return a * b; }
//static double del(double a, double b) { return a / b; }
//static double step(double a, double b) { return Math.Pow(a, b); }


//try
//{
    
//    Console.Write("Введите 'EXIT' чтобы выйти или наж ENTER чтобы продолжить: ");
//    string exit = Console.ReadLine();
//    double result = 0;
//    while (true)
//    {
//        if (exit == "")
//        {
//            Console.Write("Введите первое число: ");
//            double number1 = double.Parse(Console.ReadLine());
//            Console.Write("Введите второе число:");
//            double number2 = double.Parse(Console.ReadLine());
//            Console.Write("Введите операцию (+, *, :, -, ^)");
//            string operation = Console.ReadLine();
//            switch (operation)
//            {
//                case "+":
//                    Console.WriteLine($"Ответ: {plus(number1, number2)}");
//                    break;
//                case "-":
//                    Console.WriteLine($"Ответ: {minus(number1, number2)}");
//                    break;
//                case "*":
//                    Console.WriteLine($"Ответ: {umn(number1, number2)}");
//                    break;
//                case "^":
//                    Console.WriteLine($"Ответ: {step(number1, number2)}");
//                    break;
//                case ":":
//                    if (number2 == 0)
//                    {
//                        throw new DivideByZeroException("Ошибка деления на ноль");
//                    }
//                    Console.WriteLine($"Ответ: {del(number1, number2)}");
//                    break;

//                default: Console.WriteLine("Неизвестная операция"); break;
//            }
//        }
//        else if (exit == "EXIT")
//        {
//            break;
//        }

//    }
    
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}
//catch (FormatException ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}

//задание 2



















Console.ReadLine();