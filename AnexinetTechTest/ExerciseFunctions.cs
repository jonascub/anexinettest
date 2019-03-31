using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnexinetTechTest
{
    static class ExerciseFunctions
    {
        public static double Pi()
        {

            int lim = (int)Math.Pow(10, 6);
            double res = 0.0;

            for (int k = 1; k <= lim; k++)
                res += Math.Pow(-1, k + 1) / ((2 * k) - 1);

            res = 4 * res;
            return res;
        }
        public static int GetAngle(int hour = 0, int minute = 0)
        {

            int hour_angle = (int)(0.5 * (hour * 60 + minute));
            int minute_angle = (int)(6 * minute);

            int angle = Math.Abs(hour_angle - minute_angle);
            angle = Math.Min(360 - angle, angle);

            return angle;
        }

        public static bool ValidateAnagrams(string FirstWord, string SecondWord)
        {

            char[] firstw = FirstWord.ToLower().ToCharArray();
            char[] secondw = SecondWord.ToLower().ToCharArray();

            Array.Sort(firstw);
            Array.Sort(secondw);

            return (firstw.ToString() == secondw.ToString()) ? true : false;
        }

        public static string StringCompress(string str)
        {

            int cp = 1;
            string resout = "";

            for (int i = 0;  i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                    cp++;
                else {
                    resout = resout + str[i] + cp;
                    cp = 1;
                }
            }

            resout = resout + str[str.Length - 1] + cp;
            return (resout.Length < str.Length) ? resout : str;
        }
    }
}
