using System;
//Sololearn Arrays Week 9 Quiz Notes
class Program {
  public static void Main (string[] args) {
    
        // string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };

            // Problem: Write a program to take N number as input and output the corresponding game with N index from the array. If user enters an invalid number that is out of array range, the program should output "Invalid number".

            //your code goes here
            Console.WriteLine("Input a number--5 max");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N<5){
                Console.Write(games[N]);
            }
            else {
                Console.WriteLine("Invalid number");
            }
    
        // array with loop, loop reads the values as long as k is less than 10(array length) and returns value,-- only prints 10 numbers increment by 2 therefore even numbers) displays the values of the elements of the array.The variable k is used to access each array elementThe variable k is used to access each array element.
        int[ ] a = new int[10];
            for (int k = 0; k < 10; k++) {
                a[k] = k*2;
            }
            for (int k = 0; k < 10; k++) {
                Console.WriteLine(a[k]);
            } 
    //The variable k is used to access each array element. The last index in the array is 9, so the for loop condition is k<10.

        foreach is similar
        int[ ] a = new int[10];
            for (int k = 0; k < 10; k++) {
                a[k] = k*2;
            }
            foreach (int k in a) {
                Console.WriteLine(k);
            }

        // To review the code below, we declared an array and a variable sum that will hold the sum of all the elements. Next, we utilized a foreach loop to iterate through each element of the array, adding the corresponding element's value to the sum variable. The "Array class" provides some useful methods that will be discussed in the coming lessons.
        int[ ] arr = {11, 35, 62, 555, 989};
            int sum = 0; 
            
            foreach (int x in arr) {
                sum += x;
            }
            Console.WriteLine(sum);


        // Complete the program to go through the array and output the the sum of even numbers.
         int[] numbers = new int[5];
            int count = 0;
            while (count <5)
            {
                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            //your code goes here
            int sum = 0;
            foreach (int z in numbers){
                if (z%2==0){
                sum += z;
                }
            }
            Console.WriteLine(sum);

    // Multidimensional Arrays: We have used two nested for loops, one to iterate through the rows and one through the columns. The Console.WriteLine(); statement moves the output to a new line after one row is printed.
          int[ , ] someNums = { {2, 3}, {5, 6}, {4, 6} }; 
            for (int k = 0; k < 3; k++) {
                for (int j = 0; j < 2; j++) {
                    Console.Write(someNums[k, j]+" ");
                }
                Console.WriteLine();
              }

            // program below to output this array in the form of a table (without separation):
// 123
// 456
// 789
          int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int c=0;c<3;c++){
                for (int d=0;d<3;d++){
                    Console.Write(num[c,d]);
                }
                Console.WriteLine();
            }
    
        // A jagged array is an array whose elements are arrays. So it is basically an array of arrays. The following is a declaration of a single-dimensional array that has three elements, each of which is a single-dimensional array of integers. int[ ][ ] jaggedArr = new int[3][ ]; is how to declare. Each dimension is an array, so you can also initialize the array upon declaration like this:
        int[ ][ ] jaggedArr = new int[ ][ ] 
        {
          new int[ ] {1,8,2,7,9},
          new int[ ] {2,4,6},
          new int[ ] {33,42}
        };
// A jagged array is an array-of-arrays, so an int[ ][ ] is an array of int[ ], each of which can be of different lengths and occupy their own block in memory.

// A multidimensional array (int[,]) is a single block of memory (essentially a matrix). It always has the same amount of columns for every row.

    // The jagged array you are given represents the list of all participants, divided by the number of days(there are 3 arrays inside the main one, each representing the participants who took part on that day).Write a program to take the numbers of each day's winners as input and output them.
// Sample Input:
// 2
// 3
// 4
// Sample Output:
// Bridgette Ramona
// Fran Mayur
// Kristian Dana
    // Remember that the indexing starts from 0, so, if you want  to output Nth participant, you should use the N-1 index.
    
        int day1Winner=Convert.ToInt32(Console.ReadLine());
        int day2Winner=Convert.ToInt32(Console.ReadLine());
        int day3Winner=Convert.ToInt32(Console.ReadLine());
    
        string[][] olympiad = new string[][]
            {
        //day 1 - 5 participants
        new string[] { "Jill Yan", "Bridgette Ramona", "Sree Sanda", "Jareth Charlene", "Carl Soner" },                   //day 2 - 7 participants
        new string[] { "Anna Hel", "Mariette Vedrana", "Fran Mayur", "Drake Hilmar", "Nikolay Brooks", "Eliana Vlatko", "Villem Mario" },
        //day 3 - 4 participants
        new string[] { "Hieremias Zavia", "Ziya Ollie", "Christoffel Casper", "Kristian Dana", }
            };
            //your code goes here
            Console.WriteLine(olympiad[0] [day1Winner-1]);
            Console.WriteLine(olympiad[1] [day2Winner-1]);
            Console.WriteLine(olympiad[2] [day3Winner-1]);

    
        // The Array class in C# provides various properties and methods to work with arrays. For example, the Length and Rank properties return the number of elements and the number of dimensions of the array, respectively. You can access them using the dot syntax, just like any class members:
    
        int[ ] arr = {2, 4, 7, 3};
            Console.WriteLine(arr.Length); 
            Console.WriteLine(arr.Rank);
    

    // There are a number of methods available for arrays.
        //   Max returns the largest value.
        //   Min returns the smallest value.
        //   Sum returns the sum of all elements
    
          int[ ] arr = { 2, 4, 7, 1};
          Console.WriteLine(arr.Max());
          Console.WriteLine(arr.Min());
          Console.WriteLine(arr.Sum());

         //your code goes here
            Console.WriteLine("Please input 5 numbers");
            int[] arrayA = new int [5];
            int cnt = 0;    //code above and below
            while (cnt<5) { // *take 5 numbers as input
                arrayA [cnt] = Convert.ToInt32(Console.ReadLine());
                cnt++;
            }
            // // *sum of the maximum and the minimum
            Console.WriteLine(arrayA.Max() + arrayA.Min());


    // It’s common to think of strings as arrays of characters. In reality, strings in C# are objects. When you declare a string variable, you basically instantiate an object of type String. String objects support a number of useful properties and methods:
// Length returns the length of the string.
    string a = "some text";
    Console.WriteLine(a.Length);
//Outputs 9
// IndexOf(value) returns the index of the first occurrence of the value within the string.
    Console.WriteLine(a.IndexOf('t'));
//Outputs 5
// Insert(index, value) inserts the value into the string starting from the specified index.
    a = a.Insert(0, "This is ");
    Console.WriteLine(a);
//Outputs "This is some text"
// Remove(index) removes all characters in the string from the specified index.
    a = a.Remove(4);
    Console.WriteLine(a);
//Outputs "I am"
// Replace(oldValue, newValue) replaces the specified value in the string.
    a = a.Replace("This is", "I am");
    Console.WriteLine(a);
//Outputs "I am some text"
// Substring(index, length) returns a substring of the specified length, starting from the specified index. If length is not specified, the operation continues to the end of the string.
    a = a.Substring(2);
    Console.WriteLine(a);
//Outputs "am"
// Contains(value) returns true if the string contains the specified value.
    if(a.Contains("some"))
    Console.WriteLine("found");
//Outputs "found" 
//access characters of string by index:
    string a = "some text";
            Console.WriteLine(a[2]);
//Outputs "m"

    
    // Write a program to output "Invalid", if  it contains any disallowed symbols. If the password requirement is satisfied, program shouldn't output anything.(Use the for/foreach loop to iterate through the array of disallowed symbols and check the condition, then use the break keyword to stop the iteration if the condition is evaluated as true.)
    
    string password = Console.ReadLine();
            char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' };

            //your code goes here
            foreach(char i in notAllowedSymbols){ 
                if(password.Contains(i)){ 
                    Console.WriteLine("Invalid"); 
                    break;
                } 
            }

// index string 
    string s = "SoloLearn is awesome";
    Console.Write(s.IndexOf('e'));
//Output "5"

    
    // take a string, replace all occurrences of the word "dog" with "cat" and output the first sentence only
    
    string text = "This is some text about a dog. The word dog appears in this text a number of times. This is the end.";
    text = text.Replace("dog", "cat");
    text = text.Substring(0, text.IndexOf(".")+1);
    Console.WriteLine(text);
    // The code above replaces all occurrences of "dog" with "cat". After that it takes a substring of the original string starting from the first index until the first occurrence of a period character. We add one to the index of the period to include the period in the substring. You could, for example, find the number of times a specific word appears in a book with ease, using those methods.

  }
}