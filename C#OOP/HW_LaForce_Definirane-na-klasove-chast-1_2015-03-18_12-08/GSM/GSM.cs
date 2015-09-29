using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;

namespace GSM
{
    

    //    Problem 1. Define class
    //Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, 
    //battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
    //Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
    class GSM
    {
        

        //Problem 6. Static field
        //Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.

        private static GSM iPhone4S = new GSM("Apple", "IPhone4S", 1000000.99M, "Wiliam Henry Gates III",
                                               new Battery("IBatt", BatteryType.LiPolymer, 1000, 100),
                                               new Display(5.5F, 16000000));

        
        private string manufacturer = null;
        private string model = null;
        private decimal? price = null;
        private string owner = null;
        private Battery batteryCharacteristics = new Battery();
        private Display displayCharacteristics = new Display();

        //        Problem 9. Call history
        //Add a property CallHistory in the GSM class to hold a list of the performed calls.
        //Try to use the system class List<Call>.
        private List<Call> callHistory = new List<Call>();


        //        Problem 2. Constructors
        //Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
        //Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.


        public GSM(string manufacturer, string model)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;

        }

        public GSM(string manufacturer, string model, decimal price, string owner)
            : this(manufacturer, model, price, owner, null, null)
        {
        }

        public GSM(string manufacturer, string model, decimal price, string owner, Battery batteryCharacteristics, Display displayCharacteristics)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.Owner = owner;
            this.batteryCharacteristics = batteryCharacteristics;
            this.displayCharacteristics = displayCharacteristics;
            this.CallHistory = callHistory;
        }


        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }
        //        Problem 5. Properties
        //Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
        //Ensure all fields hold correct data at any given time.
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (value.Length < 2 && value.Length > 30)
                {
                    throw new ArgumentException("The name of the manufacturer is either to long or short!");
                }
                this.manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (value.Length < 2 && value.Length > 30)
                {
                    throw new ArgumentException("The model is either to long or short!");
                }
                this.model = value;
            }
        }


        public decimal? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price should be a positive amount!");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                if (value.Length < 2 && value.Length > 30)
                {
                    throw new ArgumentException("The name of the owner is either to long or short!");
                }
                this.owner = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(this.callHistory);
            }
            set
            {
             this.callHistory = value;
            }
        }

        //        Problem 10. Add/Delete calls
        //Add methods in the GSM class for adding and deleting calls from the calls history.
        //Add a method to clear the call history.

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void DeleteCallHistory()
        {
            this.callHistory.Clear();
        }

        //        Problem 11. Call price
        //Add a method that calculates the total price of the calls in the call history.
        //Assume the price per minute is fixed and is provided as a parameter.
        public decimal Account(decimal priceOfCall)
        {
            decimal totalDuration = (decimal)(this.callHistory.Select(x => x.Duration).Sum());
            return priceOfCall * (totalDuration / 60.0M);
        }


        public override string ToString()
        {
            return String.Format(CultureInfo.CreateSpecificCulture("en-US"),
                "This is the {0} GSM \nit is manufactured by {1} \nowned by {2}, \nits batery is {3} \nits display is {4}\nit costs {5:C2}"
                , Model , Manufacturer , Owner , batteryCharacteristics , displayCharacteristics , Price );
        }
    }
}