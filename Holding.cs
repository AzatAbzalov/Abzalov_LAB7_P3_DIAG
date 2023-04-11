abstract class Holding : IComparable<object>
{
    public Person Owner { get; set; }       // владелец
    public double Cost { get; set; }        // стоимость
    
    public int CompareTo(object obj)
    {
        Holding h = obj as Holding;
        return Cost.CompareTo(h.Cost);
    }

public virtual void Output()
    {
        Owner.Output();
        Console.WriteLine("Стоимость имущества: " + Cost);
    }

}
