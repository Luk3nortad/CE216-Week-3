using System;

namespace CheckVotingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("แบบฝึกหัดที่ 3 : ระบบตรวจสอบสิทธิ์ เลือกตั้ง");

            Console.Write("ป้อนอายุของคุณ: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("สัญชาติ (ไทย/อื่นๆ): ");
            string nationality = Console.ReadLine();

            Console.WriteLine();

            if (age >= 18 && nationality == "ไทย")
            {
                Console.WriteLine("คุณมีสิทธิ์ เลือกตั้ง");
            }
            else
            {
                Console.WriteLine("คุณไม่มีสิทธิ์ เลือกตั้ง");

                if (nationality != "ไทย")
                {
                    Console.WriteLine("เหตุผล: ไม่ใช่สัญชาติไทย");
                }
                else if (age < 18)
                {
                    Console.WriteLine("เหตุผล: อายุต่ำกว่า 18 ปี");
                }
            }

            Console.ReadKey();
        }
    }
}
