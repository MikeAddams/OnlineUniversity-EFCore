namespace OnlineUniversity.Domain
{
    public class Subject : BaseEntity
    {
        public string Title { get; set; }

        public int NumberOfCredits { get; set; }

        public Lecturer Lecturer { get; set; }
    }
}
