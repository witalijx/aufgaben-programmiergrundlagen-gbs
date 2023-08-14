namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fak = new int[7];
            int seven = 7;

            for (int i = 0; i < seven; i++)
            {
                fak[i] = i + 1;
            }
            
            int fakultat = 1;
            foreach (int i in fak)
            {
                fakultat *= i;
            }

            Console.WriteLine("7! = {0}", fakultat);
        }
    }
}