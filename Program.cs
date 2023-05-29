using System;

class Program
{
    //Initial Balance
    static double saldo = 1000;
    public static void Main(string[] args)
    {
        //Variable to perform another operation
        bool realizarOtraOperacion = true;

        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("                BANK OF IMAGINATION");
        Console.WriteLine("----------------------------------------------------------------------");

        do
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("What do you want to do ? ");
            Console.WriteLine("----------------------------------------------------------------------");
            
            //Options
            Console.Write("1.Balance Inquiry \n2.Withdrawals \n3.Deposit \n4.Cancel \nEnter an option: ");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Balance();
                    break;
                case 2:
                    Withdrawals();
                    break;
                case 3:
                    Deposit();
                    break;
                case 4:
                    Cancel();
                    realizarOtraOperacion = false;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

            //Conditional
            if (realizarOtraOperacion)
            {
                bool respuestaValida = false;
                while (!respuestaValida)
                {
                    Console.WriteLine("Do you want to perform another operation? (Y/N)");
                    string respuesta = Console.ReadLine();

                    if (respuesta.ToUpper() == "N")
                    {
                        Console.Clear();
                        Cancel();
                        realizarOtraOperacion = false;
                        respuestaValida = true;
                    }
                    else if (respuesta.ToUpper() == "Y")
                    {
                        respuestaValida = true;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Please enter Y or N.");
                    }
                }
            }
        } while (realizarOtraOperacion);
    }

    static void Balance()
    {
        DateTime transactionDateTime = DateTime.Now;


        //Ticket
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("                BANK OF IMAGINATION");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"Date: {transactionDateTime.ToShortDateString()}\r\nTime: {transactionDateTime.ToShortTimeString()}\r\nLocation: ATM Branch 123 Imaginary Street, Imaginary City");
        Console.WriteLine("Type: Balance Inquiry");
        Console.WriteLine($"Current Balance: ${saldo}");
        Console.WriteLine("------------------------------------------");
    }

    static void Withdrawals()
    {
        double retirar;
        DateTime transactionDateTime = DateTime.Now;

        Console.WriteLine("------------------------------------------");
        Console.Write("How much money do you want to withdraw? $");
        retirar = double.Parse(Console.ReadLine());
        Console.WriteLine("------------------------------------------");

        if (retirar > saldo)
        {
            Console.WriteLine("Sorry, the operation you want to perform is not possible due to lack of funds");
        }
        else
        {
            //Changes the value of the balance
            saldo -= retirar;

            //Ticket
            Console.WriteLine($"The operation has been carried out successfully, you have withdrawn ${retirar}");
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("                BANK OF IMAGINATION");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Date: {transactionDateTime.ToShortDateString()}\r\nTime: {transactionDateTime.ToShortTimeString()}\r\nLocation: ATM Branch 123 Imaginary Street, Imaginary City");
            Console.WriteLine("Type: Withdrawal");
            Console.WriteLine($"Amount Withdrawn: ${retirar}");
            Console.WriteLine($"Current Balance: ${saldo}");
            Console.WriteLine("------------------------------------------");
        }
    }

    static void Deposit()
    {
        double deposito;
        DateTime transactionDateTime = DateTime.Now;

        Console.WriteLine("------------------------------------------");
        Console.Write("Enter the amount you wish to deposit: $");
        deposito = double.Parse(Console.ReadLine());
        Console.WriteLine("------------------------------------------");

        //Changes the value of the balance
        saldo += deposito;

        //Ticket
        Console.WriteLine($"${deposito} has been deposited to your account");
        Console.WriteLine("\n------------------------------------------");
        Console.WriteLine("                BANK OF IMAGINATION");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"Date: {transactionDateTime.ToShortDateString()}\r\nTime: {transactionDateTime.ToShortTimeString()}\r\nLocation: ATM Branch 123 Imaginary Street, Imaginary City");
        Console.WriteLine("Type: Deposit");
        Console.WriteLine($"Amount Deposited: ${deposito}");
        Console.WriteLine($"Current Balance: ${saldo}");
        Console.WriteLine("------------------------------------------");
    }

    static void Cancel()
    {
        Console.WriteLine("------------------");
        Console.WriteLine("Thank you for using our ATM. Have a nice day!");
        Console.WriteLine("------------------");
        Console.ReadKey();
    }
}
