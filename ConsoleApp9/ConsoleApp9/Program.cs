using System;

namespace DrinkMenuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("แบบฝึกหัดที่ 4 : เมนู เครื่องดื่ม");
            Console.WriteLine();
            Console.WriteLine("=== เมนู เครื่องดื่ม ===");
            Console.WriteLine("1. กาแฟ (Coffee) - 45 บาท");
            Console.WriteLine("2. ชา (Tea) - 35 บาท");
            Console.WriteLine("3. นม (Milk) - 30 บาท");
            Console.WriteLine("4. น้ำส้ม (Orange Juice) - 40 บาท");
            Console.WriteLine("5. น้ำเปล่า (Water) - 10 บาท");
            Console.WriteLine();

            Console.Write("เลือก เครื่องดื่ม (1-5): ");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            string drinkName = "";
            int price = 0;

            switch (choice)
            {
                case 1:
                    drinkName = "กาแฟ (Coffee)";
                    price = 45;
                    break;
                case 2:
                    drinkName = "ชา (Tea)";
                    price = 35;
                    break;
                case 3:
                    drinkName = "นม (Milk)";
                    price = 30;
                    break;
                case 4:
                    drinkName = "น้ำส้ม (Orange Juice)";
                    price = 40;
                    break;
                case 5:
                    drinkName = "น้ำเปล่า (Water)";
                    price = 10;
                    break;
                default:
                    drinkName = "ไม่มีในเมนู";
                    break;
            }

            if (choice >= 1 && choice <= 5)
            {
                Console.WriteLine("คุณ เลือก: " + drinkName);
                Console.WriteLine("ราคา: " + price + " บาท");
            }
            else
            {
                Console.WriteLine("คุณ เลือก: " + drinkName);
                Console.WriteLine("กรุณา เลือก เมนูที่ถูกต้อง (1-5)");
            }

            Console.ReadKey();
        }
    }
}
