namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("  ___            _       _                      _   ");
            Console.WriteLine(" | _ ) __ _ _ _ | |__   /_\\  __ __ ___ _  _ _ _| |_ ");
            Console.WriteLine(" | _ \\/ _` | ' \\| / /  / _ \\/ _/ _/ _ \\ || | ' \\  _|");
            Console.WriteLine(" |___/\\__,_|_||_|_\\_\\ /_/ \\_\\__\\__\\___/\\_,_|_||_\\__|");


            Console.ForegroundColor = ConsoleColor.Black;

            var sarasAccount = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            sarasAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your balance is now {sarasAccount.GetBalance()}");

            
        }
    }
}
