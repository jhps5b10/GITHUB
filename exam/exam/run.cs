using System;
using System.IO;
namespace exam
{
    class run
    {
        static void Main(string[] args)
        {
            //非動態配置
            //string path = "E:\\lossandactivation\\activation_function\\set111.txt";
            //string b = "sigmoid";
            //output opt = new output();
            //opt.printxy(path, b);

            //動態配置       
            int acccount = 0;
            int losscount = 0;
            output opt = new output();

            StreamReader act = new StreamReader("E:\\lossandactivation\\setact.txt");
            String actline = act.ReadToEnd();
            string[] ActArray = actline.Split(Environment.NewLine);
            for (int i = 0; i < ActArray.Length / 2; i++)
            {
                opt.printxy(ActArray[acccount], ActArray[acccount + 1]);
                acccount += 2;
            }

            StreamReader loss = new StreamReader("E:\\lossandactivation\\setloss.txt");
            String lossline = loss.ReadToEnd();
            string[] LossArray = lossline.Split(Environment.NewLine);
            for (int i = 0; i < LossArray.Length / 2; i++)
            {
                opt.printsum(LossArray[losscount], LossArray[losscount + 1]);
                losscount += 2;
            }

        }
    }
}
