using System;
class Program{
    static void Main(string[] args){
        string[] inputArr = Console.ReadLine().Split(' ');
        int N = int.Parse(inputArr[0]);
        int K = int.Parse(inputArr[1]);

        int[] populations = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int maxCustomers = 0;

        for (int i = K; i <= N; i++)
        {
            int totalCustomers = 0;
            for (int j = i - K; j <= i + K && j < N; j++)
            {
                totalCustomers += populations[j];
            }

            if (totalCustomers > maxCustomers)
            {
                maxCustomers = totalCustomers;
            }
        }

        Console.WriteLine(maxCustomers);
    }
}
