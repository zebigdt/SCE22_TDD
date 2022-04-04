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
        public static String generateID()
        {
            Random generator = new Random();
            return generator.Next(100000000,999999999).ToString();
        }

        public static String generateSalary()
        {
            Random generator = new Random();
            return generator.Next(3000, 50000).ToString();
        }

        public static String generateName()
        {
            Encoding enc = Encoding.GetEncoding("Windows-1255");
            Random generator = new Random();
            String[] arr = File.ReadAllLines("names.txt", enc);
            return arr[generator.Next(0, arr.Length)] + " " + arr[generator.Next(0, arr.Length)];
        }
    }
}
