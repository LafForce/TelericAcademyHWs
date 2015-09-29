namespace BankAccounts
{
    using System;
    using System.Collections.Generic;

    class Bank
    {
        private string name;
        private IList<Account> allAccounts;

        public Bank(string name)
        {
            this.Name = name;
            this.allAccounts = new List<Account>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name of the bank cannot be null!");
                }

                this.name = value;
            }
        }

        internal IList<Account> AllAccounts
        {
            get
            {
                return new List<Account>(this.allAccounts);
            }
        }

        public void AddAccount(Account newAccount)
        {
            this.allAccounts.Add(newAccount);
        }

        public override string ToString()
        {
            return string.Format("The Bank {0} has {1} accounts opened in it.", this.Name, this.AllAccounts.Count);
        }
    }
}
