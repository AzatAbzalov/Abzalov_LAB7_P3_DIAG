class Transport : Holding
{
    public Transport(Person owner, double cost, string name, double capacity)
    {
        Owner = owner;
        Cost = cost;
        Name = name;
        Capacity = capacity;
    }
    public Transport() : this(new Person(), 0, "undefined", 0) { }
    
    public string Name { get; set; }        // название
    public double Capacity { get; set; }        // грузоподъемность
public override void Output()
    {
        base.Output();
        Console.WriteLine("Название: " + Name);
        Console.WriteLine("Грузоподъемность в кг.: " + Capacity);
    }
}
