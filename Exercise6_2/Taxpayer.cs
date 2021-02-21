namespace Exercise6_2
{
    internal class Taxpayer
    {
        private string socialSecNumber;
        private double yearlyGrossIncome;
        private double taxOwed;

        public string SocialSecNumber
        {
            get
            {
                return socialSecNumber;
            }
            set
            {
                socialSecNumber = value;
            }
        }

        public double YearlyGrossIncome
        {
            get
            {
                return yearlyGrossIncome;
            }
            set
            {
                yearlyGrossIncome = value;
                calcTaxOwed();
            } //minden alkalommal lefut calcTaxOwed() ha változtatva van.
        }

        public double TaxOwed
        {
            get
            {
                return taxOwed;
            }
        } //read-only

        private void calcTaxOwed()
        {
            if (yearlyGrossIncome < 30000)
            {
                taxOwed = yearlyGrossIncome * .15;
            }
            else
            {
                taxOwed = yearlyGrossIncome * .28;
            }
        } //2 kulcsos adó 15 és 28%
    }
}