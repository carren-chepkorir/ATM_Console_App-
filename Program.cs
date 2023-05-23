using System;
public class CardHolder
{

    string cardNum;
    string firstName;

    string lastName;
    int pin;
    double balance;
    public CardHolder(string cardNum, string firstName, string lastName, int pin, double balance)
    {
        this.cardNum = cardNum;
        this.firstName = firstName;
        this.lastName = lastName;
        this.pin = pin;
        this.balance = balance;

    }

    // public CardHolder(string v, object value)
    // {
    // }


    public string getNum()
    {
        return cardNum;
    }
    public string getFirstName()
    {
        return firstName;
    }
    public string getLastName()
    {
        return lastName;
    }
    public int getPin()
    {
        return pin;
    }
    public double getBalance()
    {
        return balance;
    }
    public void setNum(string newCardNum)
    {
        cardNum = newCardNum;


    }
    public void setFirstName(string newFirstName)
    {
        firstName = newFirstName;

    }
    public void setLastName(string newLastName)
    {
        lastName = newLastName;
    }
    public void setPin(int newPin)
    {
        pin = newPin;

    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(string[] args)
    {
        void printOptions()
        {
            System.Console.WriteLine("Please choose from the following options...:");
            System.Console.WriteLine("1.deposit");
            System.Console.WriteLine("2.withdraw");
            System.Console.WriteLine("3.balance");
            System.Console.WriteLine("4.E1xit");
        }




        void Deposit(CardHolder currentUser)
        {
            System.Console.WriteLine("How much would you like to deposit: ");
            double deposit = double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            System.Console.WriteLine("Thank you for your $$.Your current balance is : " + currentUser.getBalance() + deposit);



        }
        void Withdraw(CardHolder currentUser)
        {
            System.Console.WriteLine("How much money would you like to withdraw :");
            double Withdrawal = double.Parse(Console.ReadLine());
            //we have to check if the money for user is enough to withdraw
            if (currentUser.getBalance() > Withdrawal)
            {
                System.Console.WriteLine("you have insufficient funds");

            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - Withdrawal);
                System.Console.WriteLine("You are good to go ,Thank you.");
            }


        }
        void Balance(CardHolder currentUser)
        {
            System.Console.WriteLine("current balance is : " + currentUser.getBalance());

        }
        // we need to set up a liibrary of users in a list...a database 

        List<CardHolder> cardHolders = new List<CardHolder>();
        cardHolders.Add(new CardHolder("12345687", "John", "Cheuri", 1234, 2050.36));
        cardHolders.Add(new CardHolder("42345657", "Jacinta", "Chomba", 4234, 6600.68));
        cardHolders.Add(new CardHolder("45674567", "Erlirr", "Jasmine", 6674, 2550.5));
        cardHolders.Add(new CardHolder("88887567", "Caremy", "Chepkorir", 8737, 1870.3));
        cardHolders.Add(new CardHolder("92757897", "Rog", "Kip", 9086, 15220.3));

        //prompt the user
        System.Console.WriteLine("Welcome to this Simple ATM");
        System.Console.WriteLine("Please enter your Debit Card Number : ");
        String debitCardNumber = "";
        CardHolder currentUser;
        while (true)
        {
            try
            {
                debitCardNumber = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNumber);
                if (currentUser != null)
                { break; }
                else
                {
                    System.Console.WriteLine("card not recognized .Please try again later");

                }
            }
            catch
            {
                System.Console.WriteLine("card not recognized .Please try again later");
            }
        }
        System.Console.WriteLine("Please enter your Pin: ");
        int pinUser = 0;
        while (true)
        {
            try
            {
                pinUser = int.Parse(Console.ReadLine());
                if (currentUser.getPin() == pinUser)
                {
                    break;

                }
                else
                {
                    System.Console.WriteLine("incorrect pin,Please try again later. ");
                }
            }
            catch { System.Console.WriteLine("incorrect pin,Please try again later. "); }


        }

        System.Console.WriteLine("Welcome " + currentUser.getFirstName());
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());

            }
            catch
            { }
            if (option == 1) { Deposit(currentUser); }
            else if (option == 2) { Withdraw(currentUser); }
            else if (option == 3) { Balance(currentUser); }
            else if (option == 4) { break; }
            else { option = 0; }





        }
        while (option != 4);
        System.Console.WriteLine("Thank you ,Have a good day. ");







    }



}