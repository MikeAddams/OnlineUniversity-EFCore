namespace OnlineUniversity.Domain
{
    public class Lecturer : BaseEntity
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int SubjectId { get; set; }

        public Subject Subject { get; set; }
    }
}