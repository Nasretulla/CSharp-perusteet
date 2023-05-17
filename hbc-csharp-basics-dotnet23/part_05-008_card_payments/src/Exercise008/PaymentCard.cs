namespace Exercise008
{
    public class PaymentCard
    {
        public double balance { get; set; }

        public PaymentCard(double balance)
        {
            this.balance = balance;
        }

        public void AddMoney(double increase)
        {
            if (increase > 0)
            {
                this.balance = this.balance + increase;
            }
        }

        public bool TakeMoney(double amount)
        {
            // implement the method so that it only takes money from the card if
            // the balance is at least the amount parameter.
            // returns true if successful and false otherwise
            if (amount <= this.balance)
            {
                this.balance = this.balance - amount;
                return true;



            }
            return false;
        }
    }
}