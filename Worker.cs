using Abzalov_LAB7_P3_DIAG;

class Worker : Person, INalog
{
    public double Salary { get; set; }
    public int Bonus { get; set; }
    public Worker() : this("noname", "", new DateTime(), 'м', 0, 0) { }
    public Worker(string fn, string sn, DateTime d, char s, double sal, int p) :
        base(fn, sn, d, s)
    {
        Salary = sal;
        Bonus = p;
    }
    
    public double TotalPay()            
    {
        return Salary * (1 + Bonus / 100.0);
    }
    public double Nalog()
    {
        return TotalPay() * 0.13;
    }
    public override void Output()
    {
        base.Output();
        Console.WriteLine("Оклад: " + Salary);
        Console.WriteLine("Премия: " + Bonus);
    }
}