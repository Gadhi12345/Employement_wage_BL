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

    public int GetDailyHours()
    {
        Random rand = new Random();
        int empCheck = rand.Next(0, 3);

        return (empCheck == 1) ? 8 : (empCheck == 2 ? 4 : 0);
    }

    public void ComputeEmployeeWage()
    {
        int totalHours = 0;

        for (int i = 0; i < workingDays; i++)
        {
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
        EmployeeWage emp = new EmployeeWage("TCS", 20, 10);
        emp.ComputeEmployeeWage();
    }
}