namespace taskUni.Models
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        private byte _age;
        public virtual byte Age
        {
            get { return _age; }
            set 
            { 
                if (_age > 0)
                {
                    _age = value;
                }
                
            }
        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age}");
        }

        
    }
}
