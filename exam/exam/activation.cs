using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace func
{
    class activation
    {
        double y = 0;
        public double unitstep_function(double b1) //單位階躍函式 OK
        {
            if (b1 < 0)   y = 0;
            else if (b1 >= 0)   y = 1;
            return y;
        }
        public double Identity_function(double b1) //Identity函式 OK
        {
            y = b1;              
            return y;
        }
        public double ReLU_function(double b1) //Relu函式 OK
        {
            if (b1 >= 0)   y = b1;
            else if (b1 < 0)   y = 0;
            return y;
        }
        public double sigmoid_function(double b1) //sigmoid函式 ok
        {
            y = 1 / (1 + Math.Pow(Math.E, -b1));
            return y;
        }
        public double tanh_function(double b1) //雙曲正切函式 ok
        {
            y = 2 / (1 + Math.Exp(-2 * b1)) - 1;
            return y;
        } 
        public double Leaky_ReLU_function(double b1) //Leaky_Relu函式 ok
        {
            if (b1 < 0)   y = 0.01 * b1;
            else if (b1 >= 0)   y = b1;
            return y;
        }
        public double PReLU_function(double b1) //PReLU函式 *******
        {
            double alpha = 0.1;
            if (b1 < 0)   y = alpha * b1;
            else if (b1 >= 0)  y = b1;
            return y;
        }
        public double RReLU_function(double b1) //RReLU函式  ok
        {
            int alpha = 2;
            if (b1 >= 0)   y = b1;
            else if (b1 < 0)   y = alpha * b1;
            return y;
        }
        public double ELU_function(double b1) //ELU函式 ok
        {
            Random alpha = new Random();
            if (b1 >= 0)  y = b1;
            else if (b1 < 0)   y = (Math.Exp(b1) - 1);
            return y;
        }
        public double SELU_function(double b1) //SELU函式 ok
        {
            double alpha = 1.67326;
            double lambda = 1.0507;
            if (b1 >= 0)   y = b1;
            else if (b1 < 0)   y = lambda * alpha * (Math.Exp(b1) - 1);
            return y;
        }
        public double SRELU_function(double b1) //SRELU函式 ok
        {
            double t1 = -2.5;
            double tr = 2.5;
            double a1 = 0.4;
            double ar = 2.0;
            if (b1 <= t1)   y = t1 + a1 * (b1 - t1);
            else if (b1 >= tr)   y = tr + ar * (b1 - tr);
            else if (t1 < b1 & b1 < tr)   y = b1;
            return y;
        }
        public double HardSigmoid_function(double b1) //HardSigmoid函式 ok 
        {
            if (b1 > 2.5)  y = 1;
            else if (b1 < -2.5)   y = 0;
            else if (b1 <= 2.5 & b1 >= -2.5)  y = 0.2 * b1 + 0.5;
            return y;
        }
        public double HardTanh_function(double b1) //HardTanh函式  ok 
        {
            if (b1 < -1) y = 0;
            else if (b1 > 1) y = 1;
            else if (b1 <= 1 & b1 >= -1) y = b1;
            return y;
        }
        public double LeCunTanh_function(double b1) //LeCunTanh函式 ok
        {
            y = 1.7519 * ((2 / (1 + Math.Exp(-2 * b1*2/3))) - 1);
            return y;
        }
        public double ArcTan_function(double b1) //反正切函式 *
        {
            y = Math.Tan(b1)*Math.Tan(-1);
            return y;
        }

        public double Softsign_function(double b1) //Softsign函式 ok
        {
            y = b1 / (1 + Math.Abs(b1));
            return y;
        }
        public double SoftPlus_function(double b1) //SoftPlus函式 ok
        {
            y = Math.Log(1 + Math.Exp(b1));
            return y;
        }
        public double Signum_function(double b1) //Signum函式 ok
        {
            if (b1 > 0) y = 1;
            else if (b1 < 0) y = -1;
            else if (b1 == 0) y = 0;
            return y;
        }
        public double BentIdentity_function(double b1) //Bent Identity函式 ok
        {
            y = (Math.Sqrt(Math.Pow(b1, 2) + 1) - 1)/2+b1;
            return y;
        }
        public double SymSigmoid_function(double b1) //Symmetrical Sigmoid函式 ok
        {
            y = (1 - (Math.Exp(-b1))) / (1 + (Math.Exp(-b1)));
            return y;
        }
        public double LogLog_function(double b1) //Log Log函式 ok
        {
            y = 1 - Math.Exp(-(Math.Exp(b1)));
            return y;
        }
        public double Gaussian_function(double b1) //Gaussian函式 ok
        {
            y = Math.Exp(-(Math.Pow(b1, 2)));
            return y;
        }
        public double Absolute_function(double b1) //Absolute函式 ok
        {
            y = Math.Abs(b1);
            return y;
        }
        public double Sin_function(double b1) //Sin函式 ok
        {
            y = Math.Sin(b1);
            return y;
        }
        public double Cos_function(double b1) //Cos函式 ok
        {
            y = Math.Cos(b1);
            return y;
        }
        public double Sinc_function(double b1) //Cos函式 ok
        {
            if (b1 == 0) y = 1;
            else if (b1 != 0) y = Math.Sin(b1) / b1;
            return y;
        }
        public double ISRU_function(double b1) //反平方根函式 *
        {
            y = 1 / Math.Tan(b1);
            return y;
        }








    }
}
