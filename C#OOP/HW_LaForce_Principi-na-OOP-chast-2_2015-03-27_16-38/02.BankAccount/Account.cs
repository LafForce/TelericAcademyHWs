namespace BankAccounts
{
    using System;

    abstract class Account : IRemunerable, IDepositable
    {
        private Customer owner;
        private decimal balance;
        private DateTime openDate;
        private decimal interestRate;

        public Account(Customer owner, decimal startBalance, decimal interestRate)
        {
            this.owner = owner;
            this.balance = startBalance;
            this.InterestRate = interestRate;
            this.openDate = new DateTime(2014, 11, 20);
        }

        internal Customer Owner
        {
            get
            {
                return this.owner;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The interest rate should be a positive value!");
                }

                this.interestRate = value;
            }
        }

        public int Months
        {
            get
            {
                return (DateTime.Now.Year * 12 + DateTime.Now.Month) -
                    (this.openDate.Year * 12 + this.openDate.Month);
            }
        }

        public virtual decimal CalculateInterestAmount()
        {
            return (this.Months * this.InterestRate);
        }

        public void Deposite(decimal receivedSum)
        {
            if (receivedSum <= 0)
            {
                throw new ArgumentException("You cannot deposite a negative or a zero sum!");
            }

            this.Balance += receivedSum;
        }

        public override string ToString()
        {
            return string.Format("Owner: {0}\nAccount type: {1}\nBalance: {2} BGN\nInterest: {3} BGN",
                this.Owner.Name, this.GetType().Name, this.Balance, this.CalculateInterestAmount());
        }
    }
}
