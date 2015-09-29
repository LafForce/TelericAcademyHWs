using System;

namespace GSM
{
    //battery characteristics (model, hours idle and hours talk)

    class Battery
    {
        private BatteryType? batteryType = null;
        private string batteryModel = null;
        private int? hoursIdle = null;
        private int? hoursTalk = null;

        public Battery() 
        {
        }

        public Battery(string batteryModel) : this( batteryModel , 0 , 0 , 0 )
        {
        }
        public Battery(string batteryModel, BatteryType batteryType, int hoursIdle, int hoursTalk)
        {
            this.BatteryModel = batteryModel;
            this.BatteryType = batteryType;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        //        Problem 5. Properties
        public BatteryType? BatteryType
        {
            get
            {
                return this.batteryType;
            }
            private set
            {
                this.batteryType = value;
            }
        }
        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }

            set
            {
                if (value.Length < 2 && value.Length > 30)
                {
                    throw new ArgumentException("The model is either to long or short!");
                }
                this.batteryModel = value;
            }
        }

        public int? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("This battery should hold some charge!");
                }
                this.hoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("One should be able at least to make 1 call!");
                }
                this.hoursTalk = value;
            }
        }

        public override string ToString()
        {
            return String.Format(@"a {0} batery, of {1} type,
with standby time of {2} hours,
and talking time of {3} hours"
                , BatteryModel, BatteryType, HoursIdle, HoursTalk );
        }
    }
    public enum BatteryType
    {
        LiPolymer,
        LiIon,
        NiCd,
        NiMH
    }
}
