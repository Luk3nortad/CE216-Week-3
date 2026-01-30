using System;

namespace CheckNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("แบบฝึกหัดที่ 1 : ตรวจสอบ เลขคู่/คี่ และบวก/ลบ");
            Console.Write("ป้อนตัวเลข : ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine(number + " เป็นจำนวนบวก");

                if (number % 2 == 0)
                {
                    Console.WriteLine(number + " เป็นเลขคู่");
                }
                else
                {
                    Console.WriteLine(number + " เป็นเลขคี่");
                }
            }
            else if (number < 0)
            {
                Console.WriteLine(number + " เป็นจำนวนลบ");

                if (number % 2 == 0)
                {
                    Console.WriteLine(number + " เป็นเลขคู่");
                }
                else
                {
                    Console.WriteLine(number + " เป็นเลขคี่");
                }
            }
            else
            {
                Console.WriteLine(number + " เป็นศูนย์");
            }

            Console.ReadKey();
        }
    }
}
