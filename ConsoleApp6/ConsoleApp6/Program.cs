using System;

namespace ElectricityBill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("แบบฝึกหัดที่ 2 : คำนวณค่าไฟฟ้า");
            Console.Write("ป้อนจำนวนหน่วยไฟฟ้าที่ใช้: ");
            int unit = int.Parse(Console.ReadLine());

            double rate = 0;
            double total;

            if (unit >= 0 && unit <= 150)
            {
                rate = 3;
            }
            else if (unit <= 400)
            {
                rate = 4;
            }
            else
            {
                rate = 5;
            }

            total = unit * rate;

            Console.WriteLine();
            Console.WriteLine("จำนวนหน่วยที่ใช้: {0} หน่วย", unit);
            Console.WriteLine("ค่าไฟฟ้ารวม: {0:F2} บาท", total);

            Console.ReadKey();
        }
    }
}
