using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesManager
{
    public class Utility
    {
        public static Random random = new Random(DateTime.Now.Millisecond);
        private readonly static string[] firstNamesArray = Properties.Resources.names.Split().Where(x => !string.IsNullOrEmpty(x)).ToArray();
        private readonly static string[] lastNamesArray = Properties.Resources.lastnames.Split().Where(x => !string.IsNullOrEmpty(x)).ToArray();
        private readonly static string[] cityNamesArray = Properties.Resources.citynames.Split().Where(x => !string.IsNullOrEmpty(x)).ToArray();
        private readonly static string[] streetNamesArray = Properties.Resources.streetnames.Split().Where(x => !string.IsNullOrEmpty(x)).ToArray();
        private readonly static string[] heArr = Properties.Resources.hebrewletters.Split().Where(x => !string.IsNullOrEmpty(x)).ToArray();
        private readonly static string[] emailProviderArray = new string[] { "@walla.co.il", "@gmail.com", "@la-dod-moshe.co.il", "@sce.ac.il", "@outlook.com" };
        private readonly static string[,] he_en_letters = new string[,] { {heArr[0], "a"},{heArr[1], "b"},{heArr[2], "g"},{heArr[3], "d"},
                                                                {heArr[4], "h"},{heArr[5], "v"},{heArr[6], "z"},{heArr[7], "h"},
                                                                {heArr[8], "t"},{heArr[9], "y"},{heArr[10], "k"},{heArr[11], "l"},
                                                                {heArr[12], "m"},{heArr[13], "n"},{heArr[14], "s"},{heArr[15], "i"},
                                                                {heArr[16], "p"},{heArr[17], "tz"},{heArr[18], "k"},{heArr[19], "r"},
                                                                {heArr[20], "sh"},{heArr[21], "t"},{heArr[22], "h"},{heArr[23], "m"},
                                                                {heArr[24], "n"},{heArr[25], "f"},{heArr[26], "tz"} };

        public static string GenerateFirstName()
        {

            return firstNamesArray[random.Next(firstNamesArray.Length)];
        }

        public static string GenerateLastName()
        {
            return lastNamesArray[random.Next(firstNamesArray.Length)];
        }

        public static string GenerateID()
        {
            string firstNum = random.Next(2, 4).ToString();
            return firstNum + random.Next(10000000, 99999999).ToString();
        }

        public static bool ValidateID(string id)
        {
            if (id.Length != 9) return false;
            int counter = 0, incNum, i;
            for (i = 0; i < 9; i++)
            {
                incNum = id[i] - '0';
                incNum *= (i % 2) + 1;
                if (incNum > 9) incNum -= 9;
                counter += incNum;
            }
            return (counter % 10 == 0);
        }

        public static string GenerateSalary()
        {
            return random.Next(3000, 50000).ToString() + "." + random.Next(100).ToString();
        }

        public static string He_En(string he)
        {
            for (int i = 0; i < he_en_letters.GetLength(0); i++)
            {
                if (he_en_letters[i, 0] == he)
                {
                    return he_en_letters[i, 1];
                }
            }

            return "-";
        }

        public static string GeneratePhoneNum()
        {
            string phoneNum = "05" + random.Next(0, 6).ToString() + random.Next(1000000, 10000000).ToString();
            return phoneNum;
        }

        public static string GenerateEmail(string firstName, string lastName)
        {
            string email = "";
            foreach (char c in firstName)
            {
                email += He_En(c.ToString());
            }

            return email + He_En(lastName[0].ToString()) + He_En(lastName[1].ToString()) + random.Next(80, 100).ToString() + emailProviderArray[random.Next(0, emailProviderArray.Length)];
        }

        public static string GenerateAddress()
        {
            string address = streetNamesArray[random.Next(streetNamesArray.Length)].ToString()
                                + " " + random.Next(100).ToString() + ", "
                                + cityNamesArray[random.Next(cityNamesArray.Length)].ToString();

            return address;
        }

        public static double CalculateIncomeTax(double salary)
        {
            if (salary <= 6450) { salary *= 0.10; }
            else if (salary >= 6451 && salary <= 9240) { salary *= 0.14; }
            else if (salary >= 9241 && salary <= 14840) { salary *= 0.20; }
            else if (salary >= 14841 && salary <= 20620) { salary *= 0.31; }
            else if (salary >= 20621 && salary <= 42910) { salary *= 0.35; }
            else { salary *= 0.47; }
            return Math.Round(salary, 2);
        }

        public static int CalculateTaxPercent(double sal, double netSal)
        {
            return (int)(100 * Math.Round((sal - netSal) / sal, 2));
        }


        //Sort version 1 - Bubble Sort O(n^2)
        //
        //public static bool Sort(List<Worker> arr)
        //{
        //    Worker temp;
        //    if (arr.Count == 0) { return false; }
        //    else
        //    {
        //        for (int j = 0; j <= arr.Count() - 2; j++)
        //        {
        //            for (int i = 0; i <= arr.Count() - 2; i++)
        //            {
        //                if (Double.Parse(arr[i].getSalary()) < Double.Parse(arr[i + 1].getSalary()))
        //                {
        //                    temp = arr[i + 1];
        //                    arr[i + 1] = arr[i];
        //                    arr[i] = temp;
        //                }
        //            }
        //        }
        //        return true;
        //    }
        //}

        //Sort version 2 - Merge Sort O(nlogn)
        //
        public static bool Sort(List<Worker> arr, int l, int r)
        {
            if (arr.Count == 0) { return false; }
            if (l < r)
            {
                // Find the middle
                // point
                int m = l + (r - l) / 2;

                // Sort first and
                // second halves
                Sort(arr, l, m);
                Sort(arr, m + 1, r);

                // Merge the sorted halves
                // Find sizes of two
                // subarrays to be merged
                int n1 = m - l + 1;
                int n2 = r - m;

                // Create temp arrays
                Worker[] L = new Worker[n1];
                Worker[] R = new Worker[n2];
                int i, j;

                // Copy data to temp arrays
                for (i = 0; i < n1; ++i)
                    L[i] = arr[l + i];
                for (j = 0; j < n2; ++j)
                    R[j] = arr[m + 1 + j];

                // Merge the temp arrays

                // Initial indexes of first
                // and second subarrays
                i = 0;
                j = 0;

                // Initial index of merged
                // subarray array
                int k = l;
                while (i < n1 && j < n2)
                {
                    if (Double.Parse(L[i].GetSalary()) >= Double.Parse(R[j].GetSalary()))
                    {
                        arr[k] = L[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = R[j];
                        j++;
                    }
                    k++;
                }

                // Copy remaining elements
                // of L[] if any
                while (i < n1)
                {
                    arr[k] = L[i];
                    i++;
                    k++;
                }

                // Copy remaining elements
                // of R[] if any
                while (j < n2)
                {
                    arr[k] = R[j];
                    j++;
                    k++;
                }
            }
            return true;
        }
    }
}
