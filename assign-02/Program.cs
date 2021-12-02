﻿using System;

namespace assign_02
{
    class Program
    {

        static string findSum(string str1, string str2)
        {

            if (str1.Length > str2.Length)
            {
                string t = str1;
                str1 = str2;
                str2 = t;
            }


            string str = "";


            int n1 = str1.Length, n2 = str2.Length;


            char[] ch = str1.ToCharArray();
            Array.Reverse(ch);
            str1 = new string(ch);
            char[] ch1 = str2.ToCharArray();
            Array.Reverse(ch1);
            str2 = new string(ch1);

            int carry = 0;
            for (int i = 0; i < n1; i++)
            {

                int sum = ((int)(str1[i] - '0') +
                        (int)(str2[i] - '0') + carry);
                str += (char)(sum % 10 + '0');


                carry = sum / 10;
            }


            for (int i = n1; i < n2; i++)
            {
                int sum = ((int)(str2[i] - '0') + carry);
                str += (char)(sum % 10 + '0');
                carry = sum / 10;
            }


            if (carry > 0)
                str += (char)(carry + '0');


            char[] ch2 = str.ToCharArray();
            Array.Reverse(ch2);
            str = new string(ch2);

            return str;
        }


        static void Main(string[] args)
        {
            string str1 = "13351351516515151513513513513135135131321315313513135135156456484946543546546546";
            string str2 = "9566489413hdMoZEcwnhwPxo3Dd8ziPbFtaCYCqdoF";
            Console.WriteLine(findSum(str1, str2));
            Console.ReadLine();

        }
    }
}
