using System;

namespace CSLab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ho ten khong theo chuan. Chinh lai theo chuan va xuat ra.");
            Console.WriteLine();

            Console.Write("Nhap ho ten (khong can theo chuan): ");
            string fullname = Console.ReadLine();

            string SEPERATOR = " ";

            string[] parts = fullname.Split(new string[] { SEPERATOR }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length >= 3)
            {
                string ho = parts[0].Substring(0, 1).ToUpper() + parts[0].Substring(1, parts[0].Length - 1).ToLower();
                string tenlot = parts[1].Substring(0, 1).ToUpper() + parts[1].Substring(1, parts[1].Length - 1).ToLower();
                string ten = parts[2].Substring(0, 1).ToUpper() + parts[2].Substring(1, parts[2].Length - 1).ToLower();

                Console.WriteLine("Ten theo dung chuan la: {0} {1} {2}", ho, tenlot, ten);
            }
            else
            {
                Console.WriteLine("Vui lòng nhập đầy đủ họ, tên lót và tên!");
            }

            Console.ReadKey(true);
        }
    }
}