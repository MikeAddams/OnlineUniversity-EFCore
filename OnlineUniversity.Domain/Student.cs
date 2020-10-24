using System.Collections.Generic;

namespace OnlineUniversity.Domain
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }

        public int MatriculationYear { get; set; }

        public ICollection<Mark> Marks { get; set; }
    }
}
