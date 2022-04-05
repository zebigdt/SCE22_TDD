﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesManager
{
    public class Utility
    {
        private static String[] namesArray = File.ReadAllLines("names.txt", Encoding.GetEncoding("Windows-1255"));
        private static String[] lastNamesArray = File.ReadAllLines("lastnames.txt", Encoding.GetEncoding("Windows-1255"));
        private static String[] heArr = File.ReadAllLines("hebrewletters.txt", Encoding.GetEncoding("Windows-1255"));

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


        private static Random generator = new Random(DateTime.Now.Millisecond);
        public static String generateFirstName()
        {

            return namesArray[generator.Next(namesArray.Length + 1)];
        }

        public static String generateLastName()
        {
            return lastNamesArray[generator.Next(namesArray.Length + 1)];
        }

        public static String generateID()
        {
            String firstNum = generator.Next(2, 4).ToString();
            return firstNum + generator.Next(10000000, 99999999).ToString();
        }

        public static String generateSalary()
        {
            return generator.Next(3000, 50000).ToString();
        }

        public static String he_en(String he)
        {
            for(int i = 0; i < he_en_letters.GetLength(0); i++)
            {
                if(he_en_letters[i, 0] == he)
                {
                    return he_en_letters[i, 1];
                }
            }

            return "-";
        }
        public static String generateEmail(String firstName, String lastName)
        {
            String email = "";
            foreach(char c in firstName)
            {
                email += he_en(c.ToString());
            }
            foreach(char c in lastName)
            {
                email += he_en(c.ToString());
            }

            return email + "@walla.co.il";
        }
    }
}
