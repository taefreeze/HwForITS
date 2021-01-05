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
            List<int> List = new List<int>();
            List<int> pos = new List<int>();
            // ลำดับคนที่ สร้างมารับ
            int order = 1;
            // initial ของการทำงาน ให้รับค่าแรกของน้ำหนัก
            Console.WriteLine("Please enter Weight of #"+ order);
            int Weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Height of #" + order);
            int Height = Convert.ToInt32(Console.ReadLine());
            List.Add(Weight);
            pos.Add(order);

            //ถ้าสูง ไม่ใช่ 170-185
            while (Height - Weight != 100)
            {
                // ลำดับ + 1
                order += 1;
                // รับค่าของคนถัดไป
                Console.WriteLine("Please enter Weight of #" + order);
                Weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Height of #" + order);
                Height = Convert.ToInt32(Console.ReadLine());
                List.Add(Weight);
            }
            //ถ้าสูง 170-185 และส่วนต่าง = 100
            if (Height - Weight == 100 && Height >= 175 && Height <= 180)
            {
                Console.Clear();
                Console.WriteLine("The best is number : " + order + "\nweight = " + Weight + "\nheight = " + Height);
                Console.WriteLine(new string('-', 50));


                int Min = List.Min();
                int indexMin = List.IndexOf(List.Min()) +1;
                Console.WriteLine("The slim is number : " + indexMin + "\nweight = " + Min);
                Console.WriteLine(new string('-', 50));


                int Max = List.Max();
                int indexMax = List.IndexOf(List.Max()) +1;
                Console.WriteLine("The fat is number : " + indexMax + "\nweight = " + Max);
            }
        }
    }
}
