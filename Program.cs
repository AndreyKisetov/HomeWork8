namespace HelloWorld
{
    // Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. (не включая N)
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{N} -> ");
            for (int i = 2; i < N+1; i = i +2)
            {
                if (i < N)
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
        }
    }
}
