namespace taskUni.Models
{
    internal class Master : Student
    {
        public string MasterUniName;
        public Master(string name, string surname, byte age, int course, string uniName, string masterUniName) : base(name, surname, age, course, uniName)
        {
            MasterUniName = masterUniName;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age} {Course} {UniName} {MasterUniName}");
        }
    }
}
