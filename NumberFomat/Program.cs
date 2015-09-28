using System;
using System.Text;

namespace NumberFomat {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Input number");
            int value;
            string line = Console.ReadLine();
            if(int.TryParse(line, out value) ) {
                StringBuilder sb = new StringBuilder();
                sb.Append(String.Format("C  => {0:c}", value)).Append("\n").
                    Append(String.Format("D8 => {0:d8}", value)).Append("\n").
                    Append(String.Format("F4 => {0:f4}", value)).Append("\n").
                    Append(String.Format("N  => {0:n}", value)).Append("\n").
                    Append(String.Format("E  => {0:E}", value)).Append("\n").
                    Append(String.Format("e  => {0:e}", value)).Append("\n").
                    Append(String.Format("x  => {0:x}", value)).Append("\n").
                    Append(String.Format("X  => {0:X}", value));
                Console.WriteLine(sb);
            } else {
                Console.WriteLine(new FormatException());
            }
            Console.ReadKey();
        }
    }
}
