internal class Program
{
    private static void Main(string[] args)
    {
        List<string> products = new List<string> { "Product1", "Product2", "Product3" };
        List<int> stock = new List<int> { 5, 15, 3 };

        for (int i = 0; i < stock.Count; i++)
        {
            if (stock[i] < 10)
            {
                stock[i] += 20;  // Restock by adding 20
                Console.WriteLine($"{products[i]} restocked to {stock[i]}");
            }
        }
    }
}