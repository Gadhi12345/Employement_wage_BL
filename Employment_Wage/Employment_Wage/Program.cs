using System;

class EmployeeWage
{
    private string companyName;
    private int wagePerHour;

    public EmployeeWage(string companyName, int wagePerHour)
    {
        this.companyName = companyName;
        this.wagePerHour = wagePerHour;
    }

    public int GetDailyHours()
    {
        Random rand = new Random();
        int empCheck = rand.Next(0, 3);

        return (empCheck == 1) ? 8 : (empCheck == 2 ? 4 : 0);
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

        int totalSalary = totalHours * wagePerHour;

        Console.WriteLine("Total Wage: " + totalSalary);
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeWage emp = new EmployeeWage("TCS", 20);
        emp.ComputeWageWithLimit();
    }
}