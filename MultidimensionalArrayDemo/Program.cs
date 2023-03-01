class Program
{
    static void Main()
    {
        int[] numbers = new int[] { 1, 2, 3 };
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i]} ");
        }
        Console.WriteLine();

        // int[,] numbers1 = new int[2][] { { 1,2}, { 3,4} };
        // array of arrays
        //int[][] numbers1 = new int[][]
        //{
        //new int[3] { 1, 2, 3 },
        //new int[2] { 4,5},
        //new int[4] { 6,7,8,9}
        //};

        int[][] numbers1 = new int[3][];
        numbers1[0] = new int[3] { 1, 2, 3 };
        numbers1[1] = new int[3] { 4, 5, 6 };
        numbers1[2] = new int[3] { 7, 8, 9 };

        for (int i = 0; i < numbers1.Length; i++)
        {
            for (int j = 0; j < numbers1[i].Length; j++)
            {
                // if (i == 1 && j == 1)
                if (i == j)
                {
                    Console.Write($"* ");
                }
                else
                {
                    Console.Write($"{numbers1[i][j]} ");
                }
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}