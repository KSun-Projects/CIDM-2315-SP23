namespace Homework4;
class Program
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int result = Compare(a,b);
        Console.WriteLine($"a= {a}; b={b}");
        Console.WriteLine($"The largest number is: {result}" );
        
        int N = Convert.ToInt32(Console.ReadLine()); 
        string shape = Console.ReadLine(); 
        Console.Write($"N is: {N}; shape is {shape} \n"); 
        Triangle(N,shape);
    }

     static int Compare(int a , int b)
    {
        int res = (a > b) ? a : b;
        return res;
    }
    static void Triangle(int N,string shape)
    {
        int x,y,z; 
        if(shape=="left")
        {
            for(x=1;x<=N;x++)
            {
                for(y=1;y<=x;y++)                
                    Console.Write("*");
                    Console.Write("\n");
            }
        }
        else if(shape=="right")
        {
            for (x=1;x<=N;x++)
            {
                for (y=1;y<=N-x;y++)
                {
                    Console.Write(" ");
                }
                for (z=1;z<=x;z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
