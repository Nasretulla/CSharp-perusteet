
namespace Exercise014
{
    public class PaymentCard
    {
        private double balance;
        public PaymentCard(double openingBalance)
        {
            // write code here
            this.balance = openingBalance;
        }

        public void EatLunch()
        {
            if (this.balance > 10.6)
            {
                this.balance = this.balance - 10.60;

            }

        }

        public void DrinkCoffee()
        {
            if (this.balance > 2.0)
            {
                this.balance = this.balance - 2.0;

            }

        }

        public void AddMoney(double amount)
        {
            // write code here
            if (amount > 150)
            {

                this.balance = this.balance = 150;
            }
            else if (amount < 0)
            {
                this.balance = this.balance + 0;

            }

            else
            {
                this.balance = this.balance + amount;
            }

        }

        public override string ToString()
        {
            // write code here
            return "The card has a balance of " + this.balance + " euros";
        }
    }
}