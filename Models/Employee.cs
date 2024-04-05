namespace taskUni.Models
{
    internal class Employee : Person
    {

        public decimal Salary { get; set; }
        public double Experience { get; set; }


        public override byte Age
        {
            get => base.Age;
            set
            {
                if (Age > 18 && Age < 68)
                {
                    base.Age = value;
                }
                
            }
        }

        public Employee(string name, string surname, decimal salary, double experience, byte age) : base(name, surname)
        {
            Salary = salary;
            Experience = experience;
            Age = age;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age} {Salary} {Experience}");
        }

        
    }
}
