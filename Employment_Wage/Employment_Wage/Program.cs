using System;

class EmployeeWage
{
    private string companyName;

    public EmployeeWage(string companyName)
    {
        this.companyName = companyName;
    }

    public void CheckAttendance()
    {
        Random rand = new Random();
        int empCheck = rand.Next(0, 2);

        if (empCheck == 1)
            Console.WriteLine("Employee Present - 8 Hours");
        else
            Console.WriteLine("Employee Absent - 0 Hours");
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeWage emp = new EmployeeWage("TCS");
        emp.CheckAttendance();
    }
}