namespace Exercise015
{
    public class Money
    {

        private int euros;
        private int cents;

        public Money(int euros, int cents)
        {
            if (cents > 99)
            {
                euros = euros + cents / 100;
                cents = cents % 100;
            }

            this.euros = euros;
            this.cents = cents;
        }

        public Money Plus(Money addition)
        {
            Money newMoney = new Money(euros, cents);
            // create a new Money object that has the correct worth
            newMoney.euros += addition.euros;
            newMoney.cents += addition.cents;


            if (newMoney.cents >= 100)
            {
                newMoney.euros += newMoney.cents / 100;
                newMoney.cents = newMoney.cents % 100;
            }


            // return the new Money object
            return newMoney;
        }

        public Money Minus(Money decreaser)
        {
            // Create a new Money object that has the correct worth
            Money newMoney = new Money(euros, cents);

            // Subtract the value of the 'decreaser' Money object
            newMoney.euros -= decreaser.euros;
            newMoney.cents -= decreaser.cents;

            // Adjust the value of the new Money object if necessary
            if (newMoney.cents < 0)
            {
                newMoney.euros--;
                newMoney.cents += 100;
            }
            if (newMoney.euros < 0)
            {
                newMoney.euros = 0;
                newMoney.cents = 0;
            }

            // Return the new Money object
            return newMoney;
        }


        public bool LessThan(Money compared)
        {
            // Do something here


            int totalWorth = euros * 100 + cents;
            int comparedWorth = compared.euros * 100 + compared.cents;
            return totalWorth < comparedWorth;

        }

        public override string ToString()
        {
            string zero = cents < 10 ? "0" : "";
            return euros + "." + zero + cents.ToString() + "e";
        }
    }
}