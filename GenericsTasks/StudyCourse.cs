using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTasks
{
    public class StudyCourse
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }


        public override string ToString()
        {
            return $"Course: { CourseId }: { CourseName } - { Description }";
        }

    }
}
