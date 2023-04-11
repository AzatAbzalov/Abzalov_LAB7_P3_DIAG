using Abzalov_LAB7_P3_DIAG;

class Car : Transport, INalog
{
    public Car(Person owner, double cost, string name, double capacity, double power) : base(owner, cost, name, capacity)
    {
        Power = power;
    }
    public Car() : base() { Power = 0; }
    public double Power { get; set; }   // мощность двигателя в л.с.
    
    public double Nalog()
    {
        if (Power < 100) 
            return Power * 2.5;
        else if (Power < 150) 
            return Power * 3.5;
        else if (Power < 200) 
            return Power * 5;
        else if (Power < 250) 
            return Power * 7.5;
        else if (Power < 410) 
            return Power * 15;
        else return Power * 300;
    }
public override void Output()
    {
        Console.WriteLine("Автомобиль");
        base.Output();
        Console.WriteLine("Мощность двигателя в л.с.: " + Power);
    }

}