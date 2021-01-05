using System;
// นำเข้า LinQ ในการเรียงข้อมูล
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
// นำเข้า  collection เพื่อใช้ในการ สร้าง List
using System.Collections.Generic;

namespace man
{
    class Program
    {
        static void Main(string[] args)
        {   
            // สร้าง List ชื่อ "Weight"
            List<string> Weight = new List<string>();
            // ลำดับคนที่ สร้างมารับ
            int number = 0;
            // initial ของการทำงาน ให้รับค่าแรกของน้ำหนัก
            Console.WriteLine("Please enter an integer");
            string input = Console.ReadLine();
            Weight.Add(input);
            //ถ้าสูง ไม่ใช่ 170-185
            while (input != "")
            {
                // รับค่าของคนถัดไป
                Console.WriteLine("Please enter another integer: ");
                input = Console.ReadLine();
                Weight.Add(input);
                // ลำดับ + 1
                number += 1;
            }
            //ถ้าสูง 170-185 และส่วนต่าง = 100
            if (input == "")
            {
                // วนรอบ เอาค่าใน List ออกมา
                foreach (string value in Weight)
                {
                    Console.WriteLine(value);
                }
                Console.ReadLine();
            }
            // ทดสอบ เรียงข้อมูลใน List
            // สร้างตัวแปรเรียงลำดับ
            var DecendingOrder = Weight.OrderByDescending(i => i);
            // วนรอบ เอาค่าใน List ออกมา (เรียงมากไปน้อยแล้ว)
            foreach(string dinosaur in DecendingOrder)
            {
            Console.WriteLine(dinosaur);
            }
        }
    }
}
