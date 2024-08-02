namespace Bank.Presentation;

public class Interface
{
    public static void Main()
    {
        Console.WriteLine("****************Julia's Bank*****************");
        Console.WriteLine("::Login Page::");

        string userName = null;
        string password = null;

        Console.Write("Enter your username: ");
        userName = Console.ReadLine();

        if (userName != "")
        {
            Console.Write("Enter your password: ");
            password = Console.ReadLine();
        }

        if (userName == "system" && password == "manager")
        {
            var mainMenuChoice = -1;
            do
            {
                Console.WriteLine("\n:::Main Menu:::");
                Console.WriteLine("1. Customers");
                Console.WriteLine("2. Accounts");
                Console.WriteLine("3. Funds Transfer");
                Console.WriteLine("4. Funds Transfer Statements");
                Console.WriteLine("5. Account Statements");
                Console.WriteLine("0. Exit");

                Console.Write("Enter choice: ");
                mainMenuChoice = int.Parse(Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1: CustomersMenu();
                        break;
                    case 2: AccountsMenu();
                        break;
                    case 3: //TODO: Display menu
                        break;
                    case 4: //TODO: Display menu
                        break;
                    case 5: //TODO: Display menu
                        break;
                }
            } while (mainMenuChoice != 0);
        }
        else
        {
            Console.WriteLine("Invalid username or password.");
        }

        Console.WriteLine("Thank you! Visit again!");
    }

    static void CustomersMenu()
    {
        var customerMenuChoice = -1;

        do
        {
            Console.WriteLine("\n:::Customers menu:::");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Delete Customer");
            Console.WriteLine("3. Update Customer");
            Console.WriteLine("4. View Customer");
            Console.WriteLine("0. Back to Main Menu");
            
            Console.Write("Enter choice: ");
            customerMenuChoice = Convert.ToInt32(Console.ReadLine());
        } while (customerMenuChoice != 0);
    }

    static void AccountsMenu()
    {
        var accountsMenuChoice = -1;

        do
        {
            Console.WriteLine("\n:::Accounts menu:::");
            Console.WriteLine("1. Add Account");
            Console.WriteLine("2. Delete Account");
            Console.WriteLine("3. Update Account");
            Console.WriteLine("4. View Accounts");
            Console.WriteLine("0. Back to Main Menu");
            
            Console.Write("Enter choice: ");
            accountsMenuChoice = Convert.ToInt32(Console.ReadLine());
        } while (accountsMenuChoice != 0);
    }
}