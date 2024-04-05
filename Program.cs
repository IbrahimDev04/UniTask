using taskUni.Models;

namespace taskUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor Ibrahim = new Doctor("Ibrahim", "Xusmandi", 25, 400, 5, "Cerrah");
            Student Qarib = new Student("Qarib", "Qaribzade", 14, 3, "Aztu");
            Employee Eli = new Employee("Eli", "Shukurov", 13, 500, 3);

            Qarib.GetInfo();
            Ibrahim.GetInfo();
            Ibrahim.Heal(Qarib);
            Eli.GetInfo();
        }
    }
}