// โปรแกรมควบคุมแผงหลอดไฟ LED เหลือ interface

using System;

namespace myproject

{
    class Program
    {

        static void Main(string[] args)
        {
            string[] box = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
            string[] Noled = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };

            foreach (var assig in box)
            {
                Console.Write(assig+" ");
            }

            Console.WriteLine();

            foreach (var index in Noled)
            {
                Console.Write(" "+index+"  ");
            }

            Console.WriteLine();

            while (true)
            {
                Console.Write("Please choose LED to turn On/Off: ");
                string ledNo = Console.ReadLine();

                int n = 0;

                foreach (var number in Noled)
                {
                    if (ledNo == number && box[n] == "[ ]")
                    {
                        box[n] = "[!]";
                        foreach (var assig in box)
                        {
                            Console.Write(assig+" ");
                        }

                        Console.WriteLine();
                        foreach (var index in Noled)
                        {
                            Console.Write(" "+index+"  ");
                        }
                        Console.WriteLine();
                    }
                    else if (ledNo == number && box[n] == "[!]")
                    {
                        box[n] = "[ ]";
                        foreach (var assig in box)
                        {
                            Console.Write(assig+" ");
                        }

                        Console.WriteLine();
                        foreach (var index in Noled)
                        {
                            Console.Write(" "+index+"  ");
                        }
                        Console.WriteLine();
                    }
                    n++;
                }
            }

        }
    }
}