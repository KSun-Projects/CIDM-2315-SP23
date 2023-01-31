namespace Homework2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a letter grade: ");
        char letter_grade = Console.ReadLine()[0];
        switch(letter_grade) {
            case 'A': Console.WriteLine("GPA point: 4");
                    break;
            case 'B': Console.WriteLine("GPA point: 3");
                    break;
            case 'C': Console.WriteLine("GPA point: 2");
                    break;
            case 'D': Console. WriteLine("GPA point: 1");
                    break;
            case 'F': Console.WriteLine("GPA point: 0"); 
                    break;
            default:  Console.WriteLine("Wrong Letter Grade!");
                    break;
                             }
            
            //part 2
        Console.WriteLine("Please input the first num:");
        int a = Convert.ToInt16(Console.ReadLine()); 
        Console.WriteLine("Please input the second num:");
        int b = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the third num:");
        int c = Convert.ToInt16(Console.ReadLine());
        int smallest=0;
        if(a<b) {
            if(a<c) {
                smallest=a;
            }
        }
        if(b<a) {
            if(b<c) {
                smallest=b;
            }
        }
        if(c<a) {
            if(c<b) {
                smallest=c;
            }
        }
        Console.WriteLine("The smallest value is: {0}",smallest);

      //part3
        int check_year;
        Console.Write("Input a year : ");
        check_year= Convert.ToInt32(Console.ReadLine());
        if ((check_year % 400) == 0){
    Console.WriteLine($"{check_year} is a leap year.", check_year);
        }
        else if ((check_year % 100) == 0){
    Console.WriteLine($"{check_year} is not a leap year.", check_year);
        }
        else if ((check_year % 4) == 0){
    Console.WriteLine($"{check_year} is a leap year.", check_year);
        }
        else
    Console.WriteLine($"{check_year} is not a leap year.", check_year);
        }

}