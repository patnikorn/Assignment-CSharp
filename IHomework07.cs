// // คำซ้ำ เหลือ interface

// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace myproject
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string RemoveAndSortTextByAlphabetical;
//             Console.Write("Input Words : ");
//             RemoveAndSortTextByAlphabetical = Console.ReadLine();

//             string[] text = RemoveAndSortTextByAlphabetical.Split(" ");

//             var words = new List<string>(text);

//             words.Sort();
//             Console.WriteLine("Output Words : " +string.Join(" ",words.Distinct()));
//         }
//     }
// }