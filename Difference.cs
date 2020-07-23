using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_Challenge_Day_14_Scope
{
    public class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int [] a)
        {
            elements = a;
        }

        public void computeDifference()
        {
            Array.Sort(this.elements);

            maximumDifference = elements.Max() - elements.Min();
        }

    }
}
