using Abzalov_LAB7_P3_DIAG;

class Stead : Holding, INalog
{
    public Stead(Person owner, double cost, double area)
    {
        Owner = owner;
        Cost = cost;
        Area = area;
    }
    public Stead() : this(new Person(), 0, 0) { }
    
    public double Area { get; set; }        // площадь
    public double Nalog()
    {
        if (Owner.Age() >= 65 || Owner.Age() >= 60 && Owner.Gender == 'ж')
            return 0;
        return Cost * 0.003;
    }
public override void Output()
    {
        Console.WriteLine("Участок земли");
        base.Output();
        Console.WriteLine("Площадь: " + Area);
    }
}
