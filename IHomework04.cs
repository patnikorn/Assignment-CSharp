// แปลงเลขฐาน 2 เป็นฐาน 10 เหลือต่อ Interface

// using System;

// namespace myproject

// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string text;
//             Console.Write("Enter Binary Number : ");
//             text = Console.ReadLine();

//             string[] number = text.Split(",");

//             foreach (var binary in number)
//             {
//                int i = (binary.Length - 1);
//                 double sum = 0, j = 0;
//                 while (i >= 0)
//                 {
//                     sum += Convert.ToDouble(binary.Substring(i, 1)) * 
//                         Convert.ToDouble(Math.Pow(2.00, Convert.ToDouble(j)));
//                     j++;
//                     i--;
//                 }
                
//                 if (sum %5 == 0)
//                 {
//                     Console.Write(binary+" ");
//                 }
//             }
//         }
//     }
// }

