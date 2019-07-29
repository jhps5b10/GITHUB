using System;
using System.IO;
using func;

namespace exam
{
    class output
    {
        public void printxy(string  actpath, string actname)
        {
            //act
            activation act = new activation();
            StreamWriter actsw = new StreamWriter(actpath);
            double[] ActX = new double[100];
            double[] ActY = new double[100];
            double x_data = -5;
            double b1 = 0; //儲存x



            switch (actname)
            {
                case "sigmoid":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.sigmoid_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);                        //Console.WriteLine(y[i]);
                    }
                    actsw.Close();
                    break;
                case "unitstep":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.unitstep_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);                        //Console.WriteLine(y[i]);
                    }
                    actsw.Close();
                    break;
                case "Identity":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.Identity_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);                        //Console.WriteLine(y[i]);
                    }
                    actsw.Close();
                    break;
                case "tanh":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.tanh_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);                        //Console.WriteLine(y[i]);
                    }
                    actsw.Close();
                    break;
                case "Softsign":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.Softsign_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);                        //Console.WriteLine(y[i]);
                    }
                    actsw.Close();
                    break;
                case "ISRU":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.ISRU_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);                        //Console.WriteLine(y[i]);
                    }
                    actsw.Close();
                    break;
                case "ReLU":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.ReLU_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);                        //Console.WriteLine(y[i]);
                    }
                    actsw.Close();
                    break;
                case "LeakyReLU":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.Leaky_ReLU_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);                        //Console.WriteLine(y[i]);
                    }
                    actsw.Close();
                    break;
                case "PReLU":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.PReLU_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);                        //Console.WriteLine(y[i]);
                    }
                    actsw.Close();
                    break;
                case "RReLU":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.RReLU_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);                        //Console.WriteLine(y[i]);
                    }
                    actsw.Close();
                    break;
                case "ELU":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.ELU_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);                        //Console.WriteLine(y[i]);
                    }
                    actsw.Close();
                    break;
                case "SELU":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.SELU_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);                        //Console.WriteLine(y[i]);
                    }
                    actsw.Close();
                    break;
                case "SRELU":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.SRELU_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);                        //Console.WriteLine(y[i]);
                    }
                    actsw.Close();
                    break;
                case "HardSigmoid":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.HardSigmoid_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);                        //Console.WriteLine(y[i]);
                    }
                    actsw.Close();
                    break;
                case "HardTanh":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.HardTanh_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);
                    }
                    actsw.Close();
                    break;
                case "LeCunTanh":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.LeCunTanh_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);
                    }
                    actsw.Close();
                    break;
                case "ArcTan":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.ArcTan_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);
                    }
                    actsw.Close();
                    break;
                case "SoftPlus":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.SoftPlus_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);
                    }
                    actsw.Close();
                    break;
                case "Signum":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.Signum_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);
                    }
                    actsw.Close();
                    break;
                case "BentIdentity":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.BentIdentity_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);
                    }
                    actsw.Close();
                    break;
                case "SymSigmoid":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.SymSigmoid_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);
                    }
                    actsw.Close();
                    break;
                case "LogLog":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.LogLog_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);
                    }
                    actsw.Close();
                    break;
                case "Gaussian":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.Gaussian_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);
                    }
                    actsw.Close();
                    break;
                case "Absolute":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.Absolute_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);
                    }
                    actsw.Close();
                    break;
                case "Sin":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.Sin_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);
                    }
                    actsw.Close();
                    break;
                case "Cos":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.Cos_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);
                    }
                    actsw.Close();
                    break;
                case "Sinc":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.Sinc_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);
                    }
                    actsw.Close();
                    break;
                case "MAE":
                    for (int i = 0; i < ActX.Length; i++)
                    {
                        ActX[i] = x_data + 0.1 * i;
                        b1 = ActX[i];
                        ActY[i] = act.Sinc_function(b1);
                        actsw.Write(b1.ToString("f1") + "  " + ActY[i].ToString("f7") + Environment.NewLine);
                    }
                    actsw.Close();
                    break;



            }

        }
        public void printsum(string losspath, string lossname)
        {
            //loss
            loss los = new loss();
            StreamWriter losssw = new StreamWriter(losspath);
            double[] LossTrue = new double[] {-2.83,-0.95,-0.88,1.21,-1.67,0.83,-0.27,1.36,-0.34,0.48,
            -2.83,-0.95,-0.88,1.21,-1.67,-2.99,1.24,0.64};
            double[] LossPre = new double[] { -0.28, -0.9, -1.72, 1.92, -0.17, -0.04, 1.63, -0.12, 0.14, -1.96,
            1.3, -2.51, -0.93, 0.39, -0.06, -1.29, 1.41, 2.37};
            double losstrue = 0;
            double losspre = 0;
            double[] sum = new double[LossTrue.Length];

            switch (lossname)
            {
                case "MAE":
                    for (int i = 0; i < LossTrue.Length; i++)
                    {
                        losstrue = LossTrue[i];
                        losspre = LossPre[i];
                        sum[i] = los.MAE(losstrue, losspre, LossTrue.Length);
                        losssw.Write(losstrue.ToString("f2") + " " + losspre.ToString("f2")
                            + " " + sum[i].ToString("f8") + Environment.NewLine);
                    }
                    losssw.Close();
                    break;
                case "MSE":
                    for (int i = 0; i < LossTrue.Length; i++)
                    {
                        losstrue = LossTrue[i];
                        losspre = LossPre[i];
                        sum[i] = los.MSE(losstrue, losspre, LossTrue.Length);
                        losssw.Write(losstrue.ToString("f2") + " " + losspre.ToString("f2")
                            + " " + sum[i].ToString("f8") + Environment.NewLine);
                    }
                    losssw.Close();
                    break;
                case "RMSE":
                    for (int i = 0; i < LossTrue.Length; i++)
                    {
                        losstrue = LossTrue[i];
                        losspre = LossPre[i];
                        sum[i] = los.RMSE(losstrue, losspre, LossTrue.Length);
                        losssw.Write(losstrue.ToString("f2") + " " + losspre.ToString("f2")
                            + " " + sum[i].ToString("f8") + Environment.NewLine);
                    }
                    losssw.Close();
                    break;
                case "MAPE":
                    for (int i = 0; i < LossTrue.Length; i++)
                    {
                        losstrue = LossTrue[i];
                        losspre = LossPre[i];
                        sum[i] = los.MAPE(losstrue, losspre, LossTrue.Length);
                        losssw.Write(losstrue.ToString("f2") + " " + losspre.ToString("f2")
                            + " " + sum[i].ToString("f8") + Environment.NewLine);
                    }
                    losssw.Close();
                    break;
                case "SMAPE":
                    for (int i = 0; i < LossTrue.Length; i++)
                    {
                        losstrue = LossTrue[i];
                        losspre = LossPre[i];
                        sum[i] = los.SMAPE(losstrue, losspre, LossTrue.Length);
                        losssw.Write(losstrue.ToString("f2") + " " + losspre.ToString("f2")
                            + " " + sum[i].ToString("f8") + Environment.NewLine);
                    }
                    losssw.Close();
                    break;

            }
        }
    }
}
