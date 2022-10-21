namespace HomeTask_Lecture4.TaskSolutions
{
    internal class SecondTaskSolution
    {
        public void Resolve(List<int> numbers)
        {
            Console.WriteLine($"Second task:");
            Console.WriteLine($"Remove all items divided by the first number of the list");
            Console.WriteLine($"Initial list: {string.Join(", ", numbers)}");

            for (int i = 0; i < numbers.Count -1; i++)
            {
                var firstNumber = numbers[i];
                var secondNumber = numbers[i + 1];

                if (firstNumber % 2 == 0 && secondNumber % 2 == 0 ||
                    firstNumber % 2 != 0 && secondNumber % 2 != 0)
                    numbers.Insert(i++ +1, 0); // тут сдвигаем индекс вперёд, чтоб не вставлять 0 между только что вставленным нулём и другими числами
            }

            Console.WriteLine($"Result: {string.Join(", ", numbers)}");
        }
    }
}
