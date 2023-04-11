using Abzalov_LAB7_P3_DIAG;
class Building : Holding, INalog
{
    public Building(Person owner, double cost, string address)
    {
        Owner = owner;
        Cost = cost;
        Address = address;
    }
    public Building() : this(new Person(), 0, "undefined") { }
    
    public string Address { get; set; }        
    public double Nalog()
    {
        if (Owner.Age() >= 65 || Owner.Age() >= 60 && Owner.Gender == 'ж')
            return 0;
        return Cost * 0.015;
  
    }
public override void Output()
    {
        Console.WriteLine("Здание");
        base.Output();
        Console.WriteLine("Адрес: " + Address);
    }
}
