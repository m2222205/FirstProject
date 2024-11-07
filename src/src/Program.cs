namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 xonali son kirit");
            var number = Convert.ToInt32(Console.ReadLine());
            var digit1 = number % 10;
            var digit2 = number / 10 % 10;
            var digit3 = number / 100 % 10;
            var digit4 = number / 1000 % 10;
            var result = digit1 + digit2 + digit3 + digit4;
            Console.WriteLine(result);




        }
    }
}
