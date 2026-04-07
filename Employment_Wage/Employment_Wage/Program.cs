using System;

class EmployeeWage
{
    private string companyName;
    private int wagePerHour;
    private int workingDays;

    public EmployeeWage(string companyName, int wagePerHour, int workingDays)
    {
        this.companyName = companyName;
        this.wagePerHour = wagePerHour;
        this.workingDays = workingDays;
    }

    private int GetDailyHours()
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

    public void ComputeEmployeeWage()
    {
        int totalHours = 0;

        for (int i = 0; i < workingDays; i++)
        {
            totalHours += GetDailyHours();
        }

        Console.WriteLine("Company: " + companyName);
        Console.WriteLine("Total Wage: " + totalHours * wagePerHour);
    }

    public void ComputeWageWithLimit()
    {
        int totalHours = 0;
        int totalDays = 0;

        while (totalHours < 100 && totalDays < 20)
        {
            totalDays++;
            totalHours += GetDailyHours();
        }

        Console.WriteLine("Company: " + companyName);
        Console.WriteLine("Total Wage (Limit): " + totalHours * wagePerHour);
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeWage emp = new EmployeeWage("TCS", 20, 10);
        emp.ComputeEmployeeWage();
        emp.ComputeWageWithLimit();

        Console.WriteLine();

        EmployeeWage emp1 = new EmployeeWage("Maatrum", 40, 10);
        emp1.ComputeEmployeeWage();
        emp1.ComputeWageWithLimit();
    }
}