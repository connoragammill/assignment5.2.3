namespace assignment5._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Enter a number");
			int x = Convert.ToInt32(Console.ReadLine());
			RecursionNumbers(x);
		}
		static void RecursionNumbers(int n)
		{
			if (n > 0)
			{
				Console.WriteLine($"{n}");
				RecursionNumbers(n - 1);
			}
		}
    }
}
