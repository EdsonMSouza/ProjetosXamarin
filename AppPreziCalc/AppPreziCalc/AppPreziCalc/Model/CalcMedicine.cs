﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPreziCalc.Model
{
    public class CalcMedicine
    {
        public enum Type
        {
            ADULT = 0,
            CHILD,
            WHO
        }

        const int MILLI_GM_COMPRIMIDO = 600;
        const int DOSAGE_ADULT = 50;
        const int DOSAGE_CHILD = 60;

        public double CalcDosage(double numWeigth, Type enType)
        {
            double numValue = 0;

            if (enType == Type.WHO)
            {
                numValue = GetDosageWHO(numWeigth);
            }
            else if (numWeigth > 60 || enType == Type.ADULT)
            {
                numValue = GetDosageAdult(numWeigth);
            }
            else
            {
                numValue = GetDosageChild(numWeigth);
            }

            return numValue;
        }

        private double GetDosageChild(double numWeigth)
        {
            numWeigth = Math.Round(numWeigth);

            if (numWeigth == 0)
            {
                return 0;
            }
            else if (numWeigth >= 1 && numWeigth <= 6)
            {
                return 0.5;
            }
            else if (numWeigth >= 7 && numWeigth <= 12)
            {
                return 1;
            }
            else if (numWeigth >= 13 && numWeigth <= 16)
            {
                return 1;
            }
            else if (numWeigth >= 17 && numWeigth <= 20)
            {
                return 2;
            }
            else if (numWeigth >= 21 && numWeigth <= 25)
            {
                return 2.5;
            }
            else if (numWeigth >= 26 && numWeigth <= 30)
            {
                return 3;
            }
            else if (numWeigth >= 31 && numWeigth <= 35)
            {
                return 3.5;
            }
            else if (numWeigth >= 36 && numWeigth <= 40)
            {
                return 4;
            }
            else if (numWeigth >= 41 && numWeigth <= 45)
            {
                return 4.5;
            }
            else if (numWeigth >= 46 && numWeigth <= 50)
            {
                return 5;
            }
            else if (numWeigth >= 51 && numWeigth <= 55)
            {
                return 5.5;
            }
            else if (numWeigth >= 56 && numWeigth <= 60)
            {
                return 6;
            }

            return 0;
        }

        private double GetDosageAdult(double numWeigth)
        {
            numWeigth = Math.Round(numWeigth);

            if (numWeigth ==0)
            {
                return 0;
            }
            else if (numWeigth >= 1 && numWeigth <= 8)
            {
                return 0.5;
            }
            else if (numWeigth >= 9 && numWeigth <= 14)
            {
                return 1;
            }
            else if (numWeigth >= 15 && numWeigth <= 20)
            {
                return 1.5;
            }
            else if (numWeigth >= 21 && numWeigth <= 26)
            {
                return 2;
            }
            else if(numWeigth >= 27 && numWeigth <= 32)
            {
                return 2.5;
            }
            else if (numWeigth >= 33 && numWeigth <= 38)
            {
                return 3;
            }
            else if (numWeigth >= 39 && numWeigth <= 44)
            {
                return 3.5;
            }
            else if (numWeigth >= 45 && numWeigth <= 50)
            {
                return 4;
            }
            else if (numWeigth >= 51 && numWeigth <= 56)
            {
                return 4.5;
            }
            else if (numWeigth >= 57 && numWeigth <= 62)
            {
                return 5;
            }
            else if (numWeigth >= 63 && numWeigth <= 68)
            {
                return 5.5;
            }
            else if (numWeigth >= 69 && numWeigth <= 74)
            {
                return 6;
            }
            else if (numWeigth >= 74 && numWeigth <= 80)
            {
                return 6.5;
            }
            else
            {
                return 7;
            }
        }

        private double GetDosageWHO(double numWeigth)
        {
            numWeigth = Math.Round(numWeigth);

            if (numWeigth == 0)
            {
                return 0;
            }
            else if (numWeigth >= 1 && numWeigth <= 19)
            {
                return 1;
            }
            else if (numWeigth >= 20 && numWeigth <= 25)
            {
                return 1.5;
            }
            else if (numWeigth >= 26 && numWeigth <= 33)
            {
                return 2;
            }
            else if (numWeigth >= 34 && numWeigth <= 39)
            {
                return 2.5;
            }
            else if (numWeigth >= 40 && numWeigth <= 48)
            {
                return 3;
            }
            else if (numWeigth >= 49 && numWeigth <= 55)
            {
                return 3.5;
            }
            else if (numWeigth >= 56 && numWeigth <= 63)
            {
                return 4;
            }
            else if (numWeigth >= 64 && numWeigth <= 69)
            {
                return 4.5;
            }
            else if (numWeigth >= 70 && numWeigth <= 78)
            {
                return 5;
            }
            else if (numWeigth >= 79 && numWeigth <= 84)
            {
                return 5.5;
            }
            else
            {
                return 6;
            }
        }
    }
}
