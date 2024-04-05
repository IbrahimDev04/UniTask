namespace taskUni.Models
{
    internal class Doctor : Employee
    {
        public string Type { get; set; }

        public override byte Age
        {
            get => base.Age;
            set
            {
                if (Age > 24 && Age < 68)
                {
                    base.Age = value;
                }
            }
        }

        public Doctor(string name, string surname, byte age, decimal salary, double experience, string type) : base(name, surname, salary, experience, age)
        {
            Type = type;
            Age = age;
        }

        public void Heal(Person person)
        {
            Console.WriteLine($"{person.Name} sagaldi.");
        }

        public override void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age} {Salary} {Experience} {Type}");
        }

        
    }
}
