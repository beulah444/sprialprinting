using System;
using System.Drawing;

    class Program
    {
        static void Main()
        {
       // int[] u = new int[5];
        //int[,] array2D = new int[,] { { 1, 2, 3 ,4,5,6,7,8}, { 9,10,11,12,13,14,15,16 }, { 17,18,19,20,21,22,23,24}, {25,26,27,28,29,30,31,32},{ 33,34,35,36,37,38,39,40},{ 41,42,43,44,45,46,47,48},
        //    { 49,50,51,52,53,54,55,56} ,{ 57,58,59,60,61,62,63,64} };
        int[,] array2D = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine("Original Matrix");
            for(int i=0;i<array2D.GetLength(0);i++)
            {
            Console.Write("\n");
            for (int j=0;j<array2D.GetLength(1);j++)
              {
                Console.Write(string.Format("{0}\t", array2D[i, j]));
               
              }
            //Console.Write("\n\n");
            //Console.WriteLine(Environment.NewLine + Environment.NewLine);
            }
        Console.WriteLine("\n..........................................................");
        Console.WriteLine("\nSprial Marix");
        //Console.WriteLine("Rows={0}", array2D.GetLength(0));
        //Console.WriteLine("Columns={0}", array2D.GetLength(1));
        //Console.WriteLine("Rows={0}", array2D.GetLength(0));
        for (int i = array2D.GetLength(0)-1, j = 0; i >= 0;i--, j++)
        {
            
            for (int k = j; k <= i; k++)
            {
                Console.Write(string.Format("{0}\t", array2D[j, k])+" ");
            }
           
            for (int k = j + 1; k < i; k++)
            {
                Console.Write(string.Format("{0}\t", array2D[k, i] + " "));
            }
           

            for (int k = i; k > j; k--)
            {
                Console.Write(string.Format("{0}\t", array2D[i, k] + " "));
            }
          

            for (int k = i; k > j; k--)
            {
                Console.Write(string.Format("{0}\t", array2D[k, j] + " "));
            }
           

        }
        Console.WriteLine("\nPress any key to exit");
        Console.ReadKey();
    }
    }

