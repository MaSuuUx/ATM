using System.Reflection.Metadata;

class Program
{
    static double saldo = 1000;
    public static void Main(string[] args)
    {
        int opc;

        Console.WriteLine("BANK");
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Welcome Dear User \nWhat u wanna do today? ");
        Console.WriteLine("----------------------------------------------------------------------");
        Console.Write("1.Balance Inquiry \n2.Withdrawals \n3.Deposit \n4.Cancel \nEnter an option: ");
        opc = int.Parse(Console.ReadLine());

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
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
        while (opc != 4) ;
    }
    static void Balance()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"Your balance is  ${saldo}");
        Console.WriteLine("------------------------------------------");
        Console.ReadKey();

    }
    static void Withdrawals()
    {
        double retirar, saldoDis;
        Console.WriteLine("------------------------------------------");
        Console.Write("How much money do you want to withdraw? $");
        retirar = double.Parse(Console.ReadLine());
        Console.WriteLine("------------------------------------------");

        saldoDis = saldo - retirar;

        if (retirar > saldo)
        {
            Console.WriteLine("Sorry, the operation you want to perform is not possible due to lack of funds");
        }
        else
        {
            Console.WriteLine($"The operation has been carried out successfully, you have withdrawn ${retirar}");
            Console.WriteLine($"Available balance in the account ${saldoDis}");       
        }
        Console.ReadKey();
    }
    static void Deposit()
    {
        double deposito, saldoDis;
        Console.WriteLine("------------------------------------------");
        Console.Write("Enter the amount you wish to deposit: $");
        deposito = double.Parse(Console.ReadLine());
        Console.WriteLine("------------------------------------------");

        saldoDis = saldo + deposito;

        Console.WriteLine($"${deposito} has been deposited to your account");
        Console.WriteLine($"Available balance in the account ${saldoDis}");
        Console.ReadKey();

    }
    static void Cancel()
    {
        Console.WriteLine("------------------");
        Console.WriteLine("Have a nice day User :D");
        Console.WriteLine("------------------");
        Console.ReadKey();
    }
}