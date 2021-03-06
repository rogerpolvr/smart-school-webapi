namespace SmartSchool.WebAPI.Models
{
    public class StudentSubject
    {
        public StudentSubject() { }

        public StudentSubject(int studentId, int subjectId)
        {
            this.StudentId = studentId;
            this.SubjectId = subjectId;
        }

        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}