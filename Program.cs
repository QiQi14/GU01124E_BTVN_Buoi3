using System;
using System.Globalization;
namespace buoi3_BTVN1
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhap thoi gian 12h (hh:mm:ss tt): ");
                    string inputTime12H = Console.ReadLine();
                    string outputTime24H = Convert12HTo24H(inputTime12H);
                    Console.WriteLine("Thoi gian 24h la: " + outputTime24H);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Khong dung dinh dang");
                }
            }
        }

        static string Convert12HTo24H(string time12H)
        {
            DateTime time12HFormat = DateTime.ParseExact(time12H, "hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
            string time24HFormat = time12HFormat.ToString("HH:mm:ss");

            return time24HFormat;

        }
    }
}