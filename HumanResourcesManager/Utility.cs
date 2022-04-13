using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesManager
{
    public class Utility
    {
        private static string[] namesArray = File.ReadAllLines("names.txt", Encoding.GetEncoding("Windows-1255"));
        private static string[] lastNamesArray = File.ReadAllLines("lastnames.txt", Encoding.GetEncoding("Windows-1255"));
        private static string[] cityNamesArray = File.ReadAllLines("cities.txt", Encoding.GetEncoding("Windows-1255"));
        private static string[] streetNamesArray = File.ReadAllLines("streetnames.txt", Encoding.GetEncoding("Windows-1255"));
        private static string[] heArr = File.ReadAllLines("hebrewletters.txt", Encoding.GetEncoding("Windows-1255"));
        private static string[] emailProviderArray = new string[] { "@walla.co.il", "@gmail.com", "@ladodmoshe.co.il"};
        private static string[,] he_en_letters = new string[,] { {heArr[0], "a"},
                                                                {heArr[1], "b"},
                                                                {heArr[2], "g"},
                                                                {heArr[3], "d"},
                                                                {heArr[4], "h"},
                                                                {heArr[5], "v"},
                                                                {heArr[6], "z"},
                                                                {heArr[7], "h"},
                                                                {heArr[8], "t"},
                                                                {heArr[9], "y"},
                                                                {heArr[10], "k"},
                                                                {heArr[11], "l"},
                                                                {heArr[12], "m"},
                                                                {heArr[13], "n"},
                                                                {heArr[14], "s"},
                                                                {heArr[15], "i"},
                                                                {heArr[16], "p"},
                                                                {heArr[17], "tz"},
                                                                {heArr[18], "k"},
                                                                {heArr[19], "r"},
                                                                {heArr[20], "sh"},
                                                                {heArr[21], "t"},
                                                                {heArr[22], "h"},
                                                                {heArr[23], "m"},
                                                                {heArr[24], "n"},
                                                                {heArr[25], "f"},
                                                                {heArr[26], "tz"} };

        public static Random generator = new Random(DateTime.Now.Millisecond);

        public static string generateFirstName()
        {

            return namesArray[generator.Next(namesArray.Length)];
        }

        public static string generateLastName()
        {
            return lastNamesArray[generator.Next(namesArray.Length)];
        }

        public static string generateID()
        {
            string firstNum = generator.Next(2, 4).ToString();
            return firstNum + generator.Next(10000000, 99999999).ToString();
        }

        public static string generateSalary()
        {
            return generator.Next(3000, 50000).ToString();
        }

        public static string he_en(string he)
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

        public static string generatePhoneNum()
        {
            string phoneNum = "05" + generator.Next(0, 6).ToString() + generator.Next(1000000, 10000000).ToString();
            return phoneNum;
        }

        public static string generateEmail(string firstName, string lastName)
        {
            string email = "";
            foreach (char c in firstName)
            {
                email += he_en(c.ToString());
            }

            return email + he_en(lastName[0].ToString()) + he_en(lastName[1].ToString()) + emailProviderArray[generator.Next(0,emailProviderArray.Length)];
        }

        public static string generateAddress()
        {
            string address = streetNamesArray[generator.Next(streetNamesArray.Length)].ToString()
                                + " " + generator.Next(100).ToString() + ", "
                                + cityNamesArray[generator.Next(cityNamesArray.Length)].ToString();

            return address;
        }

        //כמה אחוז מס לקח לך מס הכנסה 
        public static int tax(string salary)
        {
            int sa = Int32.Parse(salary);
            if (sa <= 6450) { return 10; }
            else if (sa >= 6451 && sa <= 9240) { return 14; }
            else if (sa >= 9241 && sa <= 14840) { return 20; }
            else if (sa >= 14841 && sa <= 20620) { return 31; }
            else if (sa >= 20621 && sa <= 42910) { return 35; }
            else { return 47; }

        }
        //כמה מס הכנסה לקח לך
        public static double monthtax(string salary, int tax)
        {
            return Int32.Parse(salary) * (0.01 * tax);
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
        //                if (Int32.Parse(arr[i].getSalary()) < Int32.Parse(arr[i + 1].getSalary()))
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
                merge(arr, l, m, r);
            }
            return true;
        }
        public static void merge(List<Worker> arr, int l, int m, int r)
        {
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
                R[j] = arr[m+ 1 + j];

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
                if (Int32.Parse(L[i].getSalary()) >= Int32.Parse(R[j].getSalary()))
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
    }
}
