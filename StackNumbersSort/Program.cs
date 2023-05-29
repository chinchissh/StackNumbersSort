using System;

namespace StackNumbersSort
{
    class Program
    {
        static void Main()
        {
            string input = "31254672839";
            string output = SortNumbers(input);
            Console.WriteLine(output);
        }

        static string SortNumbers(string input)
        {
            // Создаем два стека: один для четных чисел, другой для нечетных
            Stack<char> evenStack = new Stack<char>();
            Stack<char> oddStack = new Stack<char>();

            // Проходим по каждой цифре входных данных
            foreach (char digit in input)
            {
                // Если цифра четная, добавляем ее в стек четных чисел
                if (digit % 2 == 0)
                    evenStack.Push(digit);
                // Если цифра нечетная, добавляем ее в стек нечетных чисел
                else
                    oddStack.Push(digit);
            }

            string sortedOutput = "";

            // Извлекаем числа из стека четных чисел и добавляем их в отсортированный вывод
            while (evenStack.Count > 0)
                sortedOutput += evenStack.Pop();

            // Извлекаем числа из стека нечетных чисел и добавляем их в отсортированный вывод
            while (oddStack.Count > 0)
                sortedOutput += oddStack.Pop();

            // Возвращаем отсортированный вывод
            return sortedOutput;
        }
    }
}