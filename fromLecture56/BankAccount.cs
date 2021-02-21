namespace fromLecture56
{
    internal class BankAccount
    {
        private double money;
        private string owner;

        public BankAccount(double money, string owner)
        {
            this.money = money;
            this.owner = owner;
        }

        public double Money
        {
            get
            {
                return money;
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }
        }

        //overloading plus operator right now, but we can overload =, >=, < , etc. (anything)
        //a + oprator-t írjuk le
        public static BankAccount operator +(BankAccount bank1, BankAccount bank2)
        {
            double newAmonuntOfMoney = bank1.Money + bank2.Money;
            string newOwners = bank1.Owner + "+" + bank2.Owner;

            BankAccount newBankAccount = new BankAccount(newAmonuntOfMoney, newOwners);
            return newBankAccount;
        }

        // előző másol és változtat, hogy ne legyen error: Program --> BankAccount bank4 = bank3 + 500;
        public static BankAccount operator +(BankAccount bank1, double amount)
        {
            double newAmonuntOfMoney = bank1.Money + amount;
            string newOwners = bank1.Owner;

            BankAccount newBankAccount = new BankAccount(newAmonuntOfMoney, newOwners);
            return newBankAccount;
        }
    }
}