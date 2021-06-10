// // เหลือทำ interface

// using System;

// namespace myproject
// {
//     class Program
//     {
//         static int NO_OF_CHARS = 256;
//         static char[] count = new char[NO_OF_CHARS];

//         static void getCharCountArray(string text)
//         {
//             for (int i = 0; i < text.Length; i++)
//                 count[text[i]]++;
//         }

//         static int FirstDuplicateCharactor(string text)
//         {
//             getCharCountArray(text);
//             int FDu = -1, i, j;
//             for (i = 0; i < text.Length; i++)
//             {
//                 for (j = i + 1; j < text.Length; j++)
//                 {
//                     if (text[i] == text[j])
//                     {
//                         FDu = i;
//                         break;
//                     }
//                 }
//                 if (FDu != -1)
//                 {
//                     break;
//                 }
//             }
//             return FDu;
//         }

//         static int FirstNotDuplicateCharactor(string text)
//         {
//             getCharCountArray(text);
//             int FNotDu = -1, i;

//             for (i = 0; i < text.Length; i++)
//             {
//                 if (count[text[i]] == 1)
//                 {
//                     FNotDu = i;
//                     break;
//                 }
//             }

//             return FNotDu;
//         }

//         static void Main(string[] args)
//         {
//             Console.Write("input : ");
//             string text = Console.ReadLine();
//             int FNotDu = FirstNotDuplicateCharactor(text);
//             int FDu = FirstDuplicateCharactor(text);
//             if (FDu == -1)
//                 Console.WriteLine("First duplicate charactor is : -");
//             else
//             Console.WriteLine("First duplicate charactor is : " + text[FDu]);

//             Console.WriteLine(FNotDu == -1 ? "First not duplicate charactor is : -" : "First not duplicate charactor is : " + text[FNotDu]);
//         }
//     }
// }