namespace Exercise6_3
{
    internal class Job
    {
        private string jobDesc;
        private double timeToComplete;
        private double hourlyRate;
        private double totalFee;

        //create constructor:
        public Job(string desc, double timeToComplete, double hourlyRate)
        {
            JobDesc = desc;
            TimeToComplete = timeToComplete;
            HourlyRate = hourlyRate;
        }

        public string JobDesc
        {
            get
            {
                return jobDesc;
            }
            set
            {
                jobDesc = value;
            }
        }

        public double TimeToComplete
        {
            get
            {
                return timeToComplete;
            }
            set
            {
                timeToComplete = value;
                calcTotalFee();
            }
        }

        public double HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                hourlyRate = value;
                calcTotalFee();
            }
        }

        public double TotalFee
        {
            get
            {
                return totalFee;
            }
        }

        public static Job operator +(Job j1, Job j2)  //operator overload
        {
            string newDesc = j1.JobDesc + " and " + j2.JobDesc;
            double newTotalHours = j1.TimeToComplete + j2.TimeToComplete;
            double newHourlyRate = (j1.HourlyRate + j2.HourlyRate) / 2;

            Job addedJob = new Job(newDesc, newTotalHours, newHourlyRate);

            return addedJob;
        }

        private void calcTotalFee()
        {
            totalFee = hourlyRate * timeToComplete;
        }
    }
}