using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gpax
{

    internal class GPACalculator
    {
        private double gpa_sum;
        private int n;
        private double maxGPA = double.MinValue;
        private double minGPA = double.MaxValue;

        public void setGPA(double gpa)
        {
            this.gpa_sum += gpa;
            this.n++;

            if (gpa > this.maxGPA)
            {
                this.maxGPA = gpa;
            }

            if (gpa < this.minGPA)
            {
                this.minGPA = gpa;
            }
        }

        public double getGPAX()
        {
            return this.n == 0 ? 0 : this.gpa_sum / this.n;
        }

        public double getMaxGPA()
        {
            return this.n == 0 ? 0 : this.maxGPA;
        }

        public double getMinGPA()
        {
            return this.n == 0 ? 0 : this.minGPA;
        }

        public int getStudentCount()
        {
            return this.n;
        }
    }
}
