// // เขียนโปรแกรมเปลี่ยนตัวเลขจำนวนเต็มบวก (รวมทั้งเลขศูนย์) ให้เป็นคำอ่าน เหลือ interface

// using System;

// namespace myproject
// {
//     class Program
//     {
//         public static string cv(string num){
     
//             string[][] th_num = new string[3][];
//             string[] th_digit = { "", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน" }; 
 
//             th_num[0] = new string[10] { "", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า" };
//             th_num[1] = new string[2] {"หนึ่ง", "เอ็ด" };
//             th_num[2] = new string[2] { "สอง", "ยี่" };

//             int ln = num.Length;

//             string t = "";
//             for (int i = ln; i > 0; i--) {
//                 var x = i - 1;
//                  var n = Convert.ToInt32(num.Substring(ln - i, 1));
//                  var digit = x % 6;
//                 if (n != 0) {
//                     if (n == 1) {
//                         t += (digit == 1) ? "" : th_num[1][digit == 0 ? 1 : 0];
//                     } else if (n == 2) {
//                         t += th_num[2][digit == 1 ? 1 : 0];
//                     } else {
//                         t += th_num[0][n];
//                     }
//                     t += th_digit[(digit == 0 && x > 0 ? 6 : digit)];
//                 } else {
//                     t += th_digit[digit == 0 && x > 0 ? 6 : 0];
//                 }
//             }
//             return t;
//         }
//         static void Main(string[] args)
//         {
//             Console.Write("input Number : ");
//             string num = Console.ReadLine();
//             string convert = cv(num);

//             Console.WriteLine(convert);
//             System.Console.ReadKey();
//         }
//     }
// }