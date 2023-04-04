namespace Homework9;
class Program
{
    static void Main(string[] args)
    {
        // Step 2: Create 4 students
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        // Step 3: Create a dictionary named gradebook and add name-grade pairs
        Dictionary<string, double> gradebook = new Dictionary<string, double>()
        {
            {"Alice", 4.0},
            {"Bob", 3.6},
            {"Cathy", 2.5},
            {"David", 1.8}
        };

        // Step 4: Check if "Tom" is in gradebook, and insert Tom with GPA of 3.3 if not
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }

        // Step 5: Calculate average GPA and print it out
        double sum = 0;
        foreach (KeyValuePair<string, double> pair in gradebook)
        {
            sum += pair.Value;
        }
        double averageGPA = sum / gradebook.Count;
        Console.WriteLine($"The average GPA is: {averageGPA}");

        // Step 6: Print info about students with GPA greater than average
       // Console.WriteLine("Students with GPA greater than average:");
        foreach (Student student in Student.studentList)
        {
            if (gradebook.ContainsKey(student.StudentName) && gradebook[student.StudentName] > averageGPA)
            {
                student.PrintInfo();
            }
        }
    }
}
class Student // Step 1: Create Student class with info 
{
    private int studentID;
    private string studentName;
    public static List<Student> studentList = new List<Student>();
    
    public int StudentID
    {
        get { return studentID; } 
        set { studentID = value; } 
    }

    public string StudentName
    {
        get { return studentName; }
        set { studentName = value; }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Name: {StudentName}");
    }

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this); //current object
    }
}