using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskUni.Models
{
    internal class Student : Person
    {
        public int Course { get; set; }
        public string UniName { get; set; }
        private bool _isGraduated = false;

        public Student(string name, string surname, byte age, int course, string uniName) : base(name, surname)
        {
            Course = course;
            UniName = uniName;

        }

        public bool IsGraduated
        {
            get
            {
                return _isGraduated;
            }
            set
            {
                if (Course == 4 && Course > 0 && Course < 5)
                {
                    _isGraduated = true;
                }


            }
        }

        public override void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age} {Course} {UniName}");
        }



    }
}
