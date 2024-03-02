using System;

namespace BTVN_Buoi3
{
    class Program
    {
        static void Main(string[] args)
        {
            //abc


            // Bài 1

            Console.Write("Nhap thoi gian dinh dang 12h, vi du 01:30:00PM): ");
            string input = Console.ReadLine();

            try
            {
                string hourPart = input.Substring(0, 2);
                string minsecPart = input.Substring(2, input.Length - 4);
                string amPmPart = input.Substring(input.Length - 2);

                int hour = int.Parse(hourPart);
                if (amPmPart == "PM" && hour < 12)
                    hour += 12;
                else if (amPmPart == "AM" && hour == 12)
                    hour = 0;

                string output = hour + minsecPart;
                Console.WriteLine("Thoi gian dinh dang 24 gio la: " + output);
            }
            catch (FormatException)
            {
                Console.WriteLine("Dinh dang khong hop le. Vui long nhap thoi gian dinh dang 12 gio!");
            }
                // Bài 2

                Console.Write("Nhap ten hoc vien: ");
            string name = Console.ReadLine();

            Console.Write("Nhap diem cua hoc vien: ");
            double diemGoc = double.Parse(Console.ReadLine());

            double diemMoi = diemGoc + 0.2;

            double diemLamTron = Math.Round(diemMoi);

            Console.WriteLine("Diem goc:" + diemGoc);
            Console.WriteLine("Diem lam tron:" + diemLamTron);

            if (diemLamTron >= 4 && diemLamTron < 6)
                Console.WriteLine("Trung binh");
            else if (diemLamTron >= 6 && diemLamTron < 8)
                Console.WriteLine("Kha");
            else if (diemLamTron >= 8)
                Console.WriteLine("Gioi");
            else
                Console.WriteLine("Hoc lai");
        }
    }
}
