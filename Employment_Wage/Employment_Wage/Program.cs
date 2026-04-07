using System;

class EmployeeWage
{
    private string companyName;

    public EmployeeWage(string companyName)
    {
        this.companyName = companyName;
    }

    public int GetDailyHours()
    {
        Random rand = new Random();
        int empCheck = rand.Next(0, 3);

        switch (empCheck)
        {
            case 1: return 8;
            case 2: return 4;
            default: return 0;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeWage emp = new EmployeeWage("TCS");
        Console.WriteLine("Daily Hours: " + emp.GetDailyHours());
    }
}