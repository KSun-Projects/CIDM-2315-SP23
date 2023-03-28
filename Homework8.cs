namespace Homework8;
class Program
{
 //*** Do NOT change the code in Main ***

    public static void Main (string[] args) {
        // Test Q1
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);


        // Input 2d array for Q2
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };


        // Test Q2.1
        PrintAllOddNumber(array_2d);


        // Test Q2.2
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");


        // Test Q2.3
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
            Console.Write(num +" ");
        }
    }


 // **Compete the following methods, then run the program to check outputs**
    // Q1: calculate the sum of elements in a given int_array (4 points)
    public static void ArraySum(int[] int_array){
        // put your answer below
        int sum = 0;
        foreach(int i in int_array){
            sum += i;
        }
        Console.WriteLine($"The Sum of int_array is: {sum}");    
    }


    //Q2.1: given a 2d array, print all the odd elements (2 points)
    public static void PrintAllOddNumber(int[ , ] array_2d){
        //put your answer below
        foreach (int j in array_2d){
            if (j%2!=0){
                Console.Write($"{j} ");
            }
        }
    }
    //Q2.2: given a 2d array, return the sum of all elements (2 points)
    public static int ElementSum(int[ , ] array_2d){
        //put your answer below
        int sum = 0;
        foreach(int i in array_2d){
            sum+=i;
        }
        return sum;     
    }


    // Q2.3: given a 2d array, double its element values and return it (2 points)
    public static int[ , ] DoubleArray(int[ , ] array_2d){
         //put your answer below
        int[,] doubledArray = new int[array_2d.GetLength(0), array_2d.GetLength(1)];
        // get first array [0] length
        for (int i = 0; i < array_2d.GetLength(0); i++) 
        {
            // get second array [1] length
            for (int j = 0; j < array_2d.GetLength(1); j++)
            {
                // create way to multiply both
                doubledArray[i, j] = array_2d[i, j] * 2;
            }
        }
        return doubledArray;
    }
}
