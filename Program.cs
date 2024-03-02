using System;
namespace BTVN2
{
    class Program
    {
        static void Main()
        {
            List<(string, double, string)> students = new List<(string, double, string)>();

            while (true)
            {
                Console.Write("Nhap ten hoc vien (Nhap 'exit' de thoat): ");
                string name = Console.ReadLine();

                if (name == "exit")
                {
                    break;
                }

                try
                {
                    Console.Write("Nhap diem hoc vien: ");
                    double grade = double.Parse(Console.ReadLine());

                    double roundedGrade = lamTronDiem(grade);
                    string result = hocLuc(roundedGrade);
                    students.Add((name, roundedGrade, result));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("khong hop le vui long nhap lai");
                }
            }
            Console.WriteLine("Ket Qua:");
            foreach (var student in students)
            {
                Console.WriteLine("Ten: {0}, Diem: {1}, Xep loai: {2}", student.Item1, student.Item2, student.Item3);
            }
        }
        static double lamTronDiem(double grade)
        {
            if (grade < 3.5)
            {
                return grade;
            }
            else if (grade + 0.2 >= Math.Ceiling(grade))
            {
                return Math.Ceiling(grade);
            }
            else
            {
                return Math.Floor(grade);
            }
        }
        static string hocLuc(double grade)
        {
            if (grade < 4)
            {
                return "Hoc lai";
            }
            else if (grade < 6)
            {
                return "Trung binh";
            }
            else if (grade < 8)
            {
                return "Kha";
            }
            else
            {
                return "Gioi";
            }
        }
    }
}