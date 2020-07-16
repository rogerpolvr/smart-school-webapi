using System.Collections.Generic;

namespace SmartSchool.WebAPI.Models
{
    public class Student
    {
        public Student() { }

        public Student(int id, string name, string surname, string phoneNumber)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.PhoneNumber = phoneNumber;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public IEnumerable<StudentSubject> StudentsSubjects { get; set; }


    }
}