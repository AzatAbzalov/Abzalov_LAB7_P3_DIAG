using Abzalov_LAB7_P3_DIAG;

class Horse : Transport,INalog 
{
    public Horse(Person owner, double cost, string name, double capacity, int age, double weight) : base(owner, cost, name, capacity)
    {
        Age = age;
        Weight = weight;
    }
    public Horse() : base()
    {
        Age = 0;
        Weight = 0;
    }
   
    public int Age { get; set; }
    public double Weight { get; set; }
    public double Nalog()
    {
        return 200;
    }
 public override void Output()
 {
  Console.WriteLine("Лошадь");
    base.Output();
  Console.WriteLine("Возраст: " + Age);
  Console.WriteLine("Вес: " + Weight);
 }


}