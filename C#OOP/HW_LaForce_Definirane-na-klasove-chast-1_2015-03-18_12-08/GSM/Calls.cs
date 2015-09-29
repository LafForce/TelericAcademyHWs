using System;
using System.Globalization;

namespace GSM
{
    //    Problem 8. Calls
    //Create a class Call to hold a call performed through a GSM.
    //It should contain date, time, dialled phone number and duration (in seconds).
    class Call
    {

        private DateTime time;
        private string dialledNumber;
        private TimeSpan duration;
        public Call(string time, string dialledNumber, double duration)
        {
            this.Time = time;
            this.DialledNumber = dialledNumber;
            this.Duration = duration;
        }

        public string Time
        {
            get
            {
                return this.time.ToString("dd.MM.yyyy HH:mm:ss");
            }
            private set
            {
                this.time = DateTime.ParseExact(value, "d.M.yyyy H:m:s", CultureInfo.InvariantCulture);
            }
        }

        public string DialledNumber
        {
            get
            {
                return this.dialledNumber;
            }
            private set
            {
                this.dialledNumber = value;
            }
        }

        public double Duration
        {
            get
            {
                return this.duration.TotalSeconds;
            }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Neagative duration?!");
                this.duration = TimeSpan.FromSeconds(value);
            }
        }

        public override string ToString()
        {
            return string.Format("The call made on: {0}; to number: {1} was {2}s long", Time, DialledNumber, Duration);
        }
    }
}