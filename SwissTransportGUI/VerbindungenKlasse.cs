using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransportGUI
{
    public class VerbindungenKlasse
    {
        string mDeparture;
        string mArrival;
        string mPlatform;
        string mDuration;
    


        public VerbindungenKlasse(string Departure, string Arrival, string Platform, string Duration)
        {
            mDeparture = Departure;
            mArrival = Arrival;
            mPlatform = Platform;
            mDuration = Duration;
  

        }

        public string Departure
        {
            get { return mDeparture; } 
            set { mDeparture = value; }
        }

        public string Arrival
        {
            get { return mArrival; }
            set { mArrival = value; }  
        }

        public string Platform
        {
            get { return mPlatform; }   
            set { mPlatform = value; }
        }

        public string Duration
        {
            get { return mDuration; }   
            set { mDuration = value; }  
        }

    }
}
