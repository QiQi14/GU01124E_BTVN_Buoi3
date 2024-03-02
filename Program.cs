namespace BTVN_Buoi3 {
//Bài 1: Viết chương trình chuyển đổi ngày giờ từ định dạng 12h sang định dạng 24h.
//VD: input = 12:00:01AM => output = 00:00:00; input = 01:30:00PM => 13:30:00.
//Bài 2: Có 1 danh sách học viên bao gồm tên và điểm, viết chương trình làm tròn điểm,
//nếu điểm dưới 3.5 thì giữ nguyên kết quả, nếu điểm của học viên + 0.2 > điểm nguyên thì làm tròn lên
//và xuất ra kết quả nếu học viên có số điểm tb dưới 4 thì học lại, điểm từ >=4 <6 là trung bình,
//từ >6 <8 là khá, >=8 là giỏi. VD:
//Input: A : 3.8; B: 3.5; C 6.5; D; 7.9; E 7.8
//Output: 3.8 + 0.2 = 4 => A: 4
	 //3.5 + 0.2 = 3.7 < 4 => B: 3.5
	 //6.5 + 0.2 = 6.7 < 7 => C = 6.5
	 //7.9 + 0.2 = 8.1 > 8 => D = 8
	 //7.8 + 0.2 = 8.0 == 8 => E = 8

    class Program
    {
        static void Main(string[] args)
        {
            //12:00:00PM => 12:00:00
            //12:00:00AM => 00:00:00

            //Console.WriteLine("Ket qua bai 1: " + BaiGiai1());
            Console.WriteLine("Ket qua bai 2: ");
            Console.WriteLine(BaiGiai2());
        }

        public static string BaiGiai1()
        {
            string inputHour = "12:00:00AM"; //+12 15:00:00

            string ampm = inputHour.Substring(inputHour.Length - 2, 2);
            int hour = Convert.ToInt32(inputHour.Substring(0, 2));
            string body = inputHour.Substring(2, inputHour.Length - 4);

            if (ampm.Equals("PM"))
            {
                if (hour < 12)
                    hour += 12;
            }
            else
            {
                if (hour == 12)
                {
                    hour = 0;
                }
            }

            return "" + hour + body;
        }

        public static string BaiGiai2()
        {
            string[] name = { "Hung", "Sang", "Tu" };
            Console.WriteLine(name);
            float[] grade = { 4.8F, 7.9F, 2.8F };
            string[] type = { "Yeu", "Yeu", "Yeu" };

            for (int i = 0; i < grade.Length; i++)
            {
                if (grade[i] < 3.8)
                {
                    continue;
                }

                float different = (grade[i] * 10 % 5) * 0.1F;
                if (different > 0.2)
                {
                    float roundedGrade = grade[i] + 0.5F - different;
                    grade[i] = (float)Math.Round(roundedGrade, 2);
                }

                if (grade[i] >= 4 && grade[i] < 6)
                {
                    type[i] = "TB";
                    continue;
                }

                if (grade[i] > 6 && grade[i] < 8)
                {
                    type[i] = "Kha";
                    continue;
                }

                type[i] = "Gioi";
            }

            return "" + String.Join(",", name) + 
                "\n" + String.Join(",", grade) +
                "\n" + String.Join(",", type);
        }
    }
}
