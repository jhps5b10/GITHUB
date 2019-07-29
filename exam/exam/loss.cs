using System;
using System.Collections.Generic;
using System.Text;

namespace func
{
    class loss
    {
        double sum = 0;
        public double MAE(double losstrue,double losspre,int Length)
        {
            sum += Math.Abs(losstrue - losspre) * 1/Length;
            return sum;
        }
        public double MSE(double losstrue, double losspre, int Length)
        {
            sum += Math.Pow((losstrue - losspre), 2)/Length;
            return sum;
        }
        public double RMSE(double losstrue, double losspre, int Length)
        {
            sum += Math.Pow(losstrue - losspre, 2)/Length;
            return sum;
        }
        public double MAPE(double losstrue, double losspre, int Length)
        {
            sum += Math.Abs((losstrue - losspre) / losstrue)/Length*100;
            return sum;
        }
        public double SMAPE(double losstrue, double losspre, int Length)
        {
            sum += Math.Abs(losstrue - losspre) / ((Math.Abs(losstrue) + Math.Abs(losspre)) / 2)/Length*100;
            return sum;
        }
    }
}
