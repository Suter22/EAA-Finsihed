using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coach
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int u;
            int t;
            float time;
            int lanes = 3;
            float Wrecord;
            float Erecord;
            float Brecord;
            string gender = "E";
            int lane = 0;

            while (gender != "M" || gender != "F")
            {
                Console.Clear();
                Console.Write("Enter Gender[F/M]: ");
                gender = Console.ReadLine();

                if (gender == "M" || gender == "F")
                {
                    break;
                }
            }

            if (gender == "M")
            {
                Wrecord = 9.58f;
                Erecord = 9.86f;
                Brecord = 9.87f;

            }
            else
            {
                Wrecord = 10.49f;
                Erecord = 10.73f;
                Brecord = 10.99f;
            }

            while (lanes < 4 || lanes > 8)
            {
                Console.Clear();
                lanes = InputNumber("Enter Number of Lanes (4 - 8) : ");

                if (lanes >= 4 && lanes <= 8)
                {
                    break;
                }
            }

            List<float> times = new List<float> { };
            Console.Clear();

            for (t = 0; t < lanes; t++)
            {
                lane = lane + 1;
                Console.WriteLine("Input Lane " + lane + (": "));


                if (!float.TryParse(Console.ReadLine(), out time))
                {
                    Console.WriteLine("Must Be An Integer, Reenter Number: ");
                    lane = lane - 1;
                    lanes = lanes + 1;
                }
                else
                {

                    times.Add(time);
                    if (time < Wrecord)
                    {
                        Console.WriteLine("World Record Broken");
                        Wrecord = time;
                    }
                    else if (time < Erecord)
                    {
                        Console.WriteLine("European Record Broken");
                        Erecord = time;
                        Brecord = time;
                    }
                    else if (time < Brecord)
                    {
                        Console.WriteLine("British Record Broken");
                        Brecord = time;
                    }

                }
            }
            Console.Clear();
            times.Sort();
            u = times.Count();

            for (i = 0; i < u; i++)
            {
                Console.WriteLine(times[i] + " Seconds ");
            }
            Console.ReadKey();

        }

        static int InputNumber(string msg)
        {
            int lanes = 3;
            while (true)
            {

                try
                {
                    Console.Write(msg);
                    lanes = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);

                }

            }
            return lanes;
        }


    }
}
