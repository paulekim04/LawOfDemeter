namespace LawOfDemeter1
{
    public class Class1
    {

    }
    //TEST A
    //TEST B
    //TEST C
    public class Wallet
    {
        public decimal MoneyAmount { get; private set; }

        public Wallet(decimal moneyAmount)
        {
            MoneyAmount = moneyAmount;
        }

        public void AddMoney(decimal amount)
        {
            MoneyAmount += amount;
        }

        public void WithdrawMoney(decimal amount)
        {
            MoneyAmount -= amount;
        }
    }
    //TEST Feature A
    //TEST Feature B
    public class Customer
    {
        public string FirstName { get; }
        public string LastName { get; }
        public Wallet Wallet { get; }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Wallet = new Wallet(1000m);
        }
    }

    public class PaperBoy
    {
        public void DeliverMagazine(decimal costOfMagazine, Customer customer)
        {
            Wallet w = customer.Wallet;

            if (w.MoneyAmount > costOfMagazine)
            {
                w.WithdrawMoney(costOfMagazine);
            }
            else
            {
                //
            }
        }
    }



}
