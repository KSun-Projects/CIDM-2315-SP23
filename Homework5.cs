namespace Homework5;
class Program
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        int result = Largest(a,b,c,d);
         Console.WriteLine($"The largest number is: {result}" );

        createAccount();
        Console.ReadKey(true);
     }
     public static int Largest(int a, int b)
     {
         int result= (a > b) ? a : b;
         return result;
     }
     public static int Largest(int a, int b, int c, int d)
     {
         return Largest(Largest(a,b),Largest(c,d));
    }
    public static bool checkAge(int birth_year)
    {
        int age=2022-birth_year;
        if(age>=18)
            return true;
        else
            return false;
    }
        public static void createAccount()
        {
            String userName,password,retypedPassword;
            int birthYear;
            
            Console.WriteLine("Enter Your Username:");
            userName=Console.ReadLine();
            Console.WriteLine("Enter Your Password:");
            password=Console.ReadLine();
            Console.WriteLine("Enter Your Password Again:");
            retypedPassword=Console.ReadLine();
            Console.WriteLine("Enter Your Birthyear:");
            birthYear=Convert.ToInt32(Console.ReadLine());
            
            if(checkAge(birthYear))
            {
                if(password==retypedPassword)
                    Console.WriteLine("Account is created successfully");
                else
                    Console.WriteLine("Wrong password");
            }
            else
                Console.WriteLine("Could not create an account.");
    }

}
