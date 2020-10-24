﻿namespace OnlineUniversity.Domain
{
    class StudentSubject
    {
        public int StudentId { get; set; }

        public int SubjectId { get; set; }

        public Student Student { get; set; }

        public Subject Subject { get; set; }
    }
}
