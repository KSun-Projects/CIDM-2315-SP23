namespace Homework7;
class Program
{
    static void Main(string[] args)
    {
        //call constructors to create objects with given info
        Customer c1 = new Customer(cus_id:110, cus_name:"Alice", cus_age:28);
        Customer c2 = new Customer(cus_id:111, cus_name:"Bob", cus_age:30);
        c1.PrintCusInfo();
        c2.PrintCusInfo();
        c1.ChangeID(220); //changes ID but doesnt reprint info
        c2.ChangeID(221);
        c1.PrintCusInfo(); // prints info with updated ID
        c2.PrintCusInfo();
        c1.CompareAge(c2); // compares ages of c1 and c2 for max_age
    }
}

class Customer {
    private int cus_id;
    public string cus_name;
    public int cus_age;
    public Customer(int cus_id, string cus_name, int cus_age) { //constructor used when object is created
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }
    public void ChangeID(int new_id) { // method used to change customer ID
        cus_id = new_id;
    }
    public void PrintCusInfo() { // method used to print customer info (id, name, age)
        Console.WriteLine($"Customer: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }
    public void CompareAge(Customer objCustomer) { // method used to compare the current object's age with the objCustomer's age & prints name of older customer
        var max_age = (this.cus_age >= objCustomer.cus_age) ? this.cus_name : objCustomer.cus_name;
        Console.WriteLine($"{max_age} is older");
    }
}