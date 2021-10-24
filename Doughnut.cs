using System;
using System.Collections.Generic;
using System.Text;

namespace Ungureanu_Alin_Lab2
{
    class Doughnut
    {
        private DoughnutType mFlavor;

        public DoughnutType Flavor
        {
            get
            {
                return mFlavor;
            }
            set
            {
                mFlavor = value;
            }
        }
        private readonly DateTime mTimeOfCreation;
        public DateTime TimeOfCreation
        {
            get
            {
                return mTimeOfCreation;
            }

        }
        public Doughnut(DoughnutType aFlavor) // constructor
        {
            mTimeOfCreation = DateTime.Now;
            mFlavor = aFlavor;
        }
    }
}

