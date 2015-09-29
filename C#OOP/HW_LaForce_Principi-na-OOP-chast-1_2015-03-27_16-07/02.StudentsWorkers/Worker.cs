//Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay 
//and method MoneyPerHour() that returns money earned by hour by the worker. 

namespace StudentsAndWorkers
{
    using System;
    using System.Text;

    class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Week salary should has a positive value!");
                }

                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentException("Work hours per day should be between 1 and 24!");
                }

                workHoursPerDay = value;
            }
        }


        public decimal CalculateMoneyPerHour()
        {
            decimal moneyPerHour = 0;

            moneyPerHour = (this.weekSalary / 5) / this.workHoursPerDay;

            return Math.Round(moneyPerHour, 2);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("{0} earns {1} BGN per hour", base.ToString(), this.CalculateMoneyPerHour()));

            return result.ToString();
        }
    }
}
