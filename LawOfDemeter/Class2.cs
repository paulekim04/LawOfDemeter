namespace LawOfDemeter2
{
    public class Class2
    {

    }

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

    public class Customer
    {
        public string FirstName { get; }
        public string LastName { get; }
        private readonly Wallet wallet;

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            wallet = new Wallet(1000m);
        }

        public decimal GetPayment(decimal amount)
        {
            if (wallet.MoneyAmount >= amount)
            {
                wallet.WithdrawMoney(amount);
                return amount;
            }
            return 0;
        }
    }

    public class PaperBoy
    {
        public void DeliverMagazine(decimal costOfMagazine, Customer customer)
        {
            decimal payment = customer.GetPayment(costOfMagazine);

            if (payment == costOfMagazine)
            {
                //
            }
            else
            {
                //
            }
        }
    }



}
