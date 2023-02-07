namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
        bool flag = true;
        Console.WriteLine("Input an integer: ");
        string input = Console.ReadLine();
        int number = Convert.ToInt16(input);
        for(int i=2;i<number/2;i++)
        {
            if(number%i==0)
            {
                flag = false;
                break;
            }
        }
        if(flag){
            Console.WriteLine( input + " is Prime ");
        }
        else{
            Console.WriteLine( input + " is not prime ");
        }
    // Q2
        Console.WriteLine("Assign an int value to N: ");
        int n = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(n);
        
        for(int row = 0;row<n;row++)
        {
            
            for(int col =0;col<n;col++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
       

    // Q3

        Console.WriteLine("Assign an int value to N:");
		int N=Convert.ToInt16(Console.ReadLine());
		for(int row=0;row<N;row++) 
        {
			for(int col=0;col<N;col++) 
            {
				if(row<col)
					Console.Write(" ");
				else
					Console.Write("*");

			}
			Console.Write("\n");
        }

    // Bonus
         int x, y, z, k;
         Console.WriteLine("Assign an int value to N: ");
        k = Convert.ToInt16(Console.ReadLine());
        for (x = 1; x <= k; x++) 
        {
            for (y = 0; y < k - x; y++)
            {
                Console.Write (" ");
	        }
	            for (z = 1; z <= x; z++)
                {
	                Console.Write (x);
	            }
	            Console.WriteLine ();
        }
    }
}

