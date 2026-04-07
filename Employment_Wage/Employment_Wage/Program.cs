using System;

class EmployeeWage
{
    private string companyName;
    private int wagePerHour;
    private int workingDays;
    private int empType;

    public EmployeeWage(string companyName, int wagePerHour, int workingDays, int empType)
    {
        this.companyName = companyName;
        this.wagePerHour = wagePerHour;
        this.workingDays = workingDays;
        this.empType = empType;
    }


    public void ComputeEmployeeWage()
    {
        int dailyHours = GetDailyHours();

        int totalHours = workingDays * dailyHours;
        int totalSalary = totalHours * wagePerHour;

        Console.WriteLine("Company: " + companyName);
        Console.WriteLine("Working Days: " + workingDays);
        Console.WriteLine("Employee Type: " + (empType == 1 ? "Full Time" : "Part Time"));
        Console.WriteLine("Total Hours: " + totalHours);
        Console.WriteLine("Total Wage: " + totalSalary);
    }


    public void ComputeWageWithLimit()
    {
        int dailyHours = GetDailyHours();

        int totalHours = 0;
        int totalDays = 0;

        while (totalHours < 100 && totalDays < 20)
        {
            totalDays++;
            totalHours += dailyHours;
        }

        int totalSalary = totalHours * wagePerHour;

        Console.WriteLine("\n Monthly Wage by the Condition given ");
        Console.WriteLine("Company: " + companyName);
        Console.WriteLine("Employee Type: " + (empType == 1 ? "Full Time" : "Part Time"));
        Console.WriteLine("Days Worked (limit): " + totalDays);
        Console.WriteLine("Hours Worked (limit): " + totalHours);
        Console.WriteLine("Total Wage (limit): " + totalSalary);
    }


    private int GetDailyHours()
    {
        switch (empType)
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
        EmployeeWage emp1 = new EmployeeWage("TCS", 20, 10, 1);
        emp1.ComputeEmployeeWage();
        emp1.ComputeWageWithLimit();

        Console.WriteLine();

        EmployeeWage emp2 = new EmployeeWage("Maatrum", 40, 10, 2);
        emp2.ComputeEmployeeWage();
        emp2.ComputeWageWithLimit();
    }
}