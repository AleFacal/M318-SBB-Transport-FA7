using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransportGUI
{
    public class AbfahrtenKlasse
    {
        string mCategory;
        string mOperator;
        string mTo;
        DateTime mDeparture;

        public AbfahrtenKlasse(string Category, string Operator, string To, DateTime Departure)
        {
            mCategory = Category;
            mOperator = Operator;
            mTo = To;
            mDeparture = Departure;
            
        }

        public string Category
        {
            get { return mCategory; }
            set { mCategory = value; }
        }  

   

        public DateTime Departure
        {
            get { return mDeparture; }
            set { mDeparture = value; }
        }

        public string Operator
        {
            get { return mOperator; } 
            set { mOperator = value; }
        }

        public string To
        {
            get { return mTo; } 
            set { mTo = value; }
        }



    }

}
