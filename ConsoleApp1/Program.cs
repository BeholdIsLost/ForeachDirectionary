namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<int, string>
            {
                {1, "Tallinna Tööstushariduskeskus"},
                {2, "Tallinna Nõmme Põhikool"},
                {3, "Ristiku Põhikool"},
            };

            result.ToList().ForEach(x => Console.WriteLine($"{x.Key} - {x.Value}"));
        }
    }
}