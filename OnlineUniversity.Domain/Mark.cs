using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineUniversity.Domain
{
    public class Mark : BaseEntity
    {
        public int Value { get; set; }

        public int StudentId { get; set; }

        public int SubjectId { get; set; }
    }
}
