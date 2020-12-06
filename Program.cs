using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primetiveDatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int teller = 20;

            //int som = 0;
            //string fn = "saif";

            //string firstName = "saif"; //camel case - local variavle
            //string strFirstNAme; //Hungarian case
            //string FirstName = saif; // pascal case
            //Console.WriteLine(firstName);
            //Console.WriteLine(teller);

            //int som = 0;
            //Console.WriteLine("min value:" + int.MinValue  + "max value:" + int.MaxValue );

            //float foatnomber = 3.141114F;
            //double doublenumber = 5.364567;
            // decimal decimalnumber = 150.2512312313m;

            //string firstName = "saif";
            //int year = 2000;
            //double doublenumber = 200.4554;
            //float floatnumber = 2000.4554f;
            //decimal decimalnuber = 2000.4554m;
            //char charsign = 'a';
            //bool boolvalue = true;
            //byte number = 25;

            // Console.WriteLine("int :" + "min value" +int.MinValue + "max value" + int.MaxValue);
            // Console.WriteLine("double :" + "min value" + double.MinValue + "max value" + double.MaxValue);
            // Console.WriteLine("float :" + "min value" + float.MinValue + "max value" + float.MaxValue);
            // Console.WriteLine("decimal :" + "min value" + decimal.MinValue + "max value" + decimal.MaxValue);
            //Console.WriteLine("char :" + "min value" +char.MinValue + "max value" + char.MaxValue);
            //Console.WriteLine("bool has min value of false and max valuve of true");
            //Console.WriteLine("byte :" + "min value" + byte.MinValue + "max value" + byte.MaxValue);

            // byte byteNumber = 0;// more than 255 will cose an error
           // Console.WriteLine(byteNumber);
           //Console.WriteLine("--------____________________------------___________");
           //int monthInYear = 10;
           //Console.WriteLine(monthInYear);


            //implicit converstion no data loss
            // byte byteNumber = 1;
            // int integerNumber = byteNumber;
            //Console.WriteLine("this is the value of integerNumber" + integerNumber);


            //implicit converstion there is a data loss
            //int intNumber = 900;
            //byte byteNumber = (byte)intNumber;

            //Console.WriteLine(byteNumber);

            //int intNumber = 300;

            //explicit converstion
            //float floatNumber = 1226.234f;
            //int intNumber = (int)floatNumber;
            //Console.WriteLine(intNumber);


            //convert from one type ro a different tybe
            //string stringNumber = "23434";
            //int integerNumber = Convert.ToInt32(stringNumber);
            //Console.WriteLine(integerNumber);


            //tryparse
            //string aantalTaxt = "5884s0";
            //int aantalGetal;


            //if (int.TryParse(aantalTaxt, out aantalGetal))
            //{
            //    Console.WriteLine("conversi gelukt");
            //    Console.WriteLine(aantalGetal);
            //}
            //else
            //{
            //    Console.WriteLine("conversi mislukt");
            //   Console.WriteLine(aantalGetal);
            //}

            //int b1 = 100;
            //int b2 = 250;


            //byte sum = checked((byte)(b1 + b2));
            //Console.WriteLine("de sum is : " + sum);

            char mychar = 's';
            int intNr = (int) 's';

            Console.WriteLine(intNr);

            // $ is string iterpolation
            Console.WriteLine($"value of mychar{mychar} int value  {intNr}");



        }

    }
}
