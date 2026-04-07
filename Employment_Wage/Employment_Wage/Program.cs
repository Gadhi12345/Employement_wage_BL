using System;

class EmployeeWage
{
    private string companyName;

    public EmployeeWage(string companyName)
    {
        this.companyName = companyName;
    }

    public void Display()
    {
        Console.WriteLine("Company: " + companyName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeWage emp = new EmployeeWage("TCS");
        emp.Display();
    }
}