namespace HomeTask_Lecture4.TaskSolutions
{
    internal class FirstTaskSolution
    {
        public void ResolveWithLinq(List<int> numbers)
        {
            Console.WriteLine($"First task:");
            Console.WriteLine($"Remove all items divided by the first number of the list");
            Console.WriteLine($"Initial list: {string.Join(", ", numbers)}");
            
            var firstNumber = numbers.First();
            Console.WriteLine($"First number: {firstNumber}");

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % firstNumber == 0)
                    numbers.RemoveAt(i--); // стоит обратить внимание, что после удаления элемента, мы должны вернуть индекс назад *
            }

            Console.WriteLine($"Result: {string.Join(", ", numbers)}");
        }

        /// * суть в том, что после удаления элемента, например первого, теперь на его место стал второй элемент списка.
        /// и если не вернуть индекс назад, на следующем заходе цикла, мы будем проверять уже второй элемент и пропустим ~новый~ первый, который раньше был вторым

    }
}
