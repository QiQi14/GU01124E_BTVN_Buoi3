using System.Text.RegularExpressions;
using static System.Formats.Asn1.AsnWriter;

internal class Program
{
    public static void Main(string[] args)
    {
        /*bai 1*/
        string pattern12h = "^(([1][0-2])|([0][1-9])):[0-5][0-9]:[0-5][0-9](AM|PM)$";
        string timeInput;
        while (true)
        {
            Console.WriteLine("nhap ngay gio dinh dang 12h vi du 12:12:12AM");
            timeInput = Console.ReadLine();
            if (Regex.IsMatch(timeInput, pattern12h))
            {
                Console.WriteLine(timeInput);
                break;
            }
            Console.WriteLine("nhap sai, moi nhap lai");
        }

        string identify = timeInput.Substring(8, 2);
        string hour = timeInput.Substring(0, 2);
        int hour2 = Convert.ToInt32(hour);
        if (identify == "PM") { hour = Convert.ToString(hour2 + 12); }

        string minute = timeInput.Substring(3, 2);
        string second = timeInput.Substring(6, 2);

        Console.WriteLine("Time 24h: " + hour + ":" + minute + ":" + second);


        /*bai 2*/
        while (true)
        {

            /*nhap ten va diem*/
            string name;
            double score;
            while (true)
            {
                Console.WriteLine("nhap ten");
                name = Console.ReadLine();
                try
                {
                    Console.WriteLine("nhap diem");
                    score = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("nhap diem sai, moi nhap lai");
                }

            }
            /*end nhap ten va diem*/


            /*xu ly ten va diem*/
            if (score >= 3.5)
            {
                if (score  >= ((int) score) + 0.8) { score = (int) score + 1; }
            }

            Console.WriteLine("hoc vien: " + name);

            Console.WriteLine("diem: " + score);

            if (score < 4)
            {
                Console.WriteLine("hoc lai");
            } else if (score < 6)
            {
                Console.WriteLine("trung binh");
            } else if (score < 8)
            {
                Console.WriteLine("kha");
            } else
            {
                Console.WriteLine("gioi");
            }

           

            /* end xu ly ten va diem*/


            /* end while true */
            Console.WriteLine("nhap Y neu muon tiep tuc");
            string yes = Console.ReadLine();
            if (yes != "y" & yes != "Y")
            {
                break;
            }
            /*end while true */
        }





    }
}