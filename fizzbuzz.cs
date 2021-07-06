using System;

namespace FizzBuzz
{
    class Program {
        static void Main() {

            for (int i = 1; i <= 30; i++) {
                string result = (i % 3 == 0) ? "fizz" : "";
                result += (i % 5 == 0) ? "buzz" : "";
                result += (result == "") ? i.ToString() : "";

                Console.WriteLine(result);
            }
        }
    }
}
